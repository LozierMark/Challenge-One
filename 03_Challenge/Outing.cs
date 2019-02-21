using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public enum OutingType { Golf,Bowling,AmusementPark,Concert }
    public class OutingEvent
    {
        public OutingType EventType { get; set; }
        public int NumberPeople  { get; set; }
        public DateTime OutingDate  { get; set; }
        public decimal OutingCPP { get; set; }
        public decimal CostPerEvent { get; set; }
        
        public OutingEvent(OutingType eventType, int numberPeople,DateTime outingDate, decimal outingCPP, decimal costPerEvent)
        {
            
            NumberPeople = numberPeople;
            OutingDate = outingDate;
            OutingCPP = outingCPP;
            CostPerEvent = costPerEvent;
            EventType = eventType
        }

        public OutingEvent()
        {
        }
    }
}
