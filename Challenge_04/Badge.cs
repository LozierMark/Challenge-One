using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public class Badge
    {
            public int BadgeID { get; set; }
            public List<string> Doors { get; set; }

            public Badge(int badgeID, List<string> doorNumbers)
            {
                BadgeID = badgeID;
                Doors = doorNumbers;
            }
            
            public Badge()
            {
            }


        }
}
