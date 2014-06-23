using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;
using System.Xml.Linq;
using Drool.App_Code;
using System.Net;
using System.Xml.Serialization;
using System.IO;

namespace Drool
{
    public partial class Default : System.Web.UI.Page
    {
        public static Records allRecords = new Records();
        public static double MainSDR;
        public static double SecSDR;
        public double[] SDRS = new double[500];
        public int initRun = 0;
        public void Initialize()
        {
            initRun = 1;
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString("http://coinmill.com/sources.html");
            
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(page);

            List<List<string>> table = doc.DocumentNode.SelectSingleNode("//table[@class='currencyexchange']")
                        .Descendants("tr")
                        .Skip(1)
                        .Where(tr => tr.Elements("td").Count() > 1)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                        .ToList();

            allRecords.CollectionName = "Records";
            allRecords = InitRecords.GetRecords(table);
            InitRecords.allRecords = allRecords;
            XmlSerializer x = new XmlSerializer(typeof(Records));
            string path = AppDomain.CurrentDomain.BaseDirectory;
            TextWriter writer = new StreamWriter(path+"\\App_Data\\"+"Records.xml");
            x.Serialize(writer, allRecords);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (initRun == 0) Initialize();
            }
            catch(Exception ex)
            {
                string  p = ex.Message;
            }
            if (!Page.IsPostBack)
            {
                List<string> currencies = GetCurrencies();
                Currency1.DataSource = currencies;
                Currency1.DataBind();
                Currency2.DataSource = currencies;
                Currency2.DataBind();
                Currency3.DataSource = currencies;
                Currency3.DataBind();
            }
            string cur1 = Currency1.SelectedValue;
            string cur2 = Currency2.SelectedValue;

        }

        
        public List<string> GetCurrencies()
        {
            List<string> records = new List<string>();
            foreach(Record rec in allRecords)
            {
                records.Add(rec.CurrencyName);
            }
            return records; 
        }

        protected void Convert_Click(object sender, EventArgs e)
        {
            var cur1 = Currency1.SelectedItem.Value;
            var cur2 = Currency2.SelectedItem.Value;
            string sim1="";
            string sim2="";
            foreach (Record rec in allRecords)
            {
                if (rec.CurrencyName == cur1) { MainSDR = rec.SDRFactor; sim1=rec.CurrencySymbol; }
                if (rec.CurrencyName == cur2) { SecSDR = rec.SDRFactor; sim2=rec.CurrencySymbol; }
            }
            double val1 = double.Parse(TextBox1.Text.Trim());
            double val2 = Math.Truncate(val1 * MainSDR / SecSDR * 100000)/100000;
            Label1.Text = TextBox1.Text + " " + sim1 + " = " + val2 + " " + sim2;
        }

        [System.Web.Services.WebMethod]
        public static string AddCurency(string name, double amount)
        {
            double result=0;
            string sim=null;
            foreach(Record rec in allRecords)
            {
                if (rec.CurrencyName == name){ result = amount * MainSDR / rec.SDRFactor; sim = rec.CurrencySymbol; }
            }

            result = Math.Truncate(result * 100000) / 100000;
            return result.ToString() + " " + sim;
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            var cur3 = Currency3.SelectedItem.Value;
            double newSDR = 0;
            string sim2 = "";
            foreach (Record rec in allRecords)
            {
                if (rec.CurrencyName == cur3) { newSDR = rec.SDRFactor; sim2 = rec.CurrencySymbol; }
            }
            double val1 = double.Parse(TextBox1.Text.Trim());
            double val2 = Math.Truncate(val1 * MainSDR / newSDR * 100000) / 100000;
            Label2.Text = val2 + " " + sim2;
        }
    }
}