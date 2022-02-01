using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen.Codes
{
    internal struct UgeConverter
    {
        public int DageResultat { get; set; }

        public UgeConverter(DateTime weekDate)
        {
            TimeSpan ts = weekDate - DateTime.Now;
            DageResultat = ts.Days;
        }
    }
}
