using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drool.App_Code
{
    public class Record
    {
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public double SDRFactor { get; set;}
        public string UpdateDate{ get; set; } 
        public string FactorSource{get; set; }
        public int SigFig{ get; set;}
        public double SmallUnit{ get; set;}
        public Record()
        {

        }
        public Record(string currencyName, string currencySymbol, double sdrFactor, string updateDate, string factorSource, int sigFig, double smallUnit)
        {
            CurrencyName = currencyName;
            CurrencySymbol = currencySymbol;
            SDRFactor = sdrFactor;
            UpdateDate = updateDate;
            FactorSource = factorSource;
            SigFig = sigFig;
            SmallUnit = smallUnit;
        }
    }
}