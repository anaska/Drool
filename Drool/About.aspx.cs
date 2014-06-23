using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Drool.App_Code;
using System.Net;

namespace Drool
{
    public partial class About : Page
    {
        public static Records allRecords = new Records();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
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
                repRecs.DataSource = allRecords;
                repRecs.DataBind();
            }
        }
    }
}