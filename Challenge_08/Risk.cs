using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_08
{
    public class Risk
    {
        
        public int SpeedingInfractionsPerYear { get; set; }
        public int SwervesPerMonth { get; set; }
        public int RollingStopsPerMonth { get; set; }
        public int TailgatesPerMonth { get; set; }

        public Risk(int speedingInfractionsPerYear, int swervesPerMonth, int rollingStopsPerMonth, int tailgatesPerMonth)
        {
            SpeedingInfractionsPerYear = speedingInfractionsPerYear;
            SwervesPerMonth = swervesPerMonth;
            RollingStopsPerMonth = rollingStopsPerMonth;
            TailgatesPerMonth = tailgatesPerMonth;
        }
        public Risk()
        {

        }
    }
}
    

