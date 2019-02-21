using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class OutingRepository
    {
        List<OutingEvent> _outingEvent = new List<OutingEvent>();

        public void AddOutingToList(OutingEvent outing)
        {
            _outingEvent.Add(outing);
        }

        public List<OutingEvent> EventOuting()
        {
            return _outingEvent;
        }
        public decimal TotalCost()
        {
            decimal totalCost = 0;
            foreach (OutingEvent outing in _outingEvent)
            {
                totalCost += outing.CostPerEvent;
            }
            return totalCost;
        }

        public decimal CostByType(OutingType type)
        {
            decimal totalCost = 0m;
            foreach (OutingEvent outing in _outingEvent)
            {
               if(type  == outing.EventType)
                totalCost += outing.CostPerEvent;
            }
            return totalCost;
        }
           
    }
}
