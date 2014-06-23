using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drool.App_Code
{
    public class InitRecords
    {
        public static Records allRecords;
        public static Records GetRecords(List<List<string>> table)
        {
            Records recs = new Records();
            foreach (List<string> sublist in table)
            {
                int count = 0;
                Record newRecord = new Record();
                foreach (string item in sublist)
                {
                    switch (count)
                    {
                        case 0: newRecord.CurrencyName = item; break;
                        case 1: newRecord.CurrencySymbol = item; break;
                        case 2: newRecord.SDRFactor = Convert.ToDouble(item); break;
                        case 3: newRecord.UpdateDate = item; break;
                        case 4: newRecord.FactorSource = item; break;
                        case 5: newRecord.SigFig = Convert.ToInt32(item); break;
                        case 6: newRecord.SmallUnit = Convert.ToDouble(item); break;
                        default: break;
                    }
                    ++count;

                }
                recs.Add(newRecord);
            }
            return recs;
        }
    }
}