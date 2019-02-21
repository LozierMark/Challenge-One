using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public class BadgeRepository
    {
        Dictionary<int, Badge>  _badges = new Dictionary<int, Badge>();

        public void AddBadge(int badgeNbr, Badge badge)
        {
            _badges.Add(badgeNbr,badge);
        }
        public void AddDoor(string doorNbr, Badge badge)
        {
            badge.Doors.Add(doorNbr);
        }
        public void RemoveDoor(string doorNbr, Badge badge)
        {
            // loop through to find door to remove
            badge.Doors.Remove(doorNbr);
        }
        public Dictionary<int, Badge> GetBadges()
        {
            return _badges;
        }
    }
 }
