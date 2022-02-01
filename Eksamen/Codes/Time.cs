using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen.Codes
{
    internal class Time
    {
        public static string PrintAndenInterval()
        {
            UgeConverter dag = new(new DateTime(2022, 02, 11));
            string returnMessage = "";
            //slut date
            Console.WriteLine($"{dag.DageResultat}");

            return returnMessage;
        }

        //overflødig kode

        //public static TimeModel Model { get; set; }

        //public DateTime dageResultat { get; set; }

        //public Time(DateTime weekDate)
        //{
        //    TimeSpan ts = DateTime.Now - weekDate;
        //    double timeSpanInTotalDays = ts.Days;

        //    Model = new TimeModel()
        //    {
        //        DageResultat = dageResultat
        //        TimeSpanInTotalDays = timeSpanInTotalDays
        //    };
        //}
    }
}
