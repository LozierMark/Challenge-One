using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
     public class OutingUI
    {
            private OutingRepository _outingRepo;
            private List<OutingEvent> _outingEvent;
            private bool running = true;
            public int outingToProcess = 0;

        public void Run()
        {
            _outingRepo = new OutingRepository();
            _outingEvent = _outingRepo.EventOuting();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello, please start the aduiting?\n" +
                "1. Add All Outing to List\n" +
                "2. Combined Cost for Outings\n" +
                "3. Outing cost by type\n" +
                "4. Print all Outing\n" +
                "5. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        AddOutingToList();
                        break;
                    case 2:
                        CombinedCostforOutings();
                        break;
                    case 3:
                        CostByType();
                        break;
                    case 4:
                        PrintAllOuting();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:

                        break;
                }
            }
        }
        private void CombinedCostforOutings() // case2
        {

            decimal finalCost = _outingRepo.TotalCost();
            Console.WriteLine($"The Combined cost of all outings is ${finalCost}");
            Console.ReadKey();

        }
        private void CostByType() //case3

        {
            Console.WriteLine("Enter the number for the event type:\n" +
            "1. Golf\n" +
            "2. Bowling\n" +
            "3. Amusement Park\n" +
            "4. Concert");

            int outingType = ParseInput();

            OutingType type;
            switch (outingType)
            {
                default:
                case 1:
                    type = OutingType.Golf;
                    break;
                case 2:
                    type = OutingType.Bowling;
                    break;
                case 3:
                    type = OutingType.AmusementPark;
                    break;
                case 4:
                    type = OutingType.Concert;
                    break;
            }
            decimal totalCost = _outingRepo.CostByType(type);
            Console.WriteLine($"\"{type}\" outings have a total cost of  ${totalCost}");
            Console.ReadKey();
        }

        private void AddOutingToList()

        {
            Console.WriteLine("Enter the number for the type of event:\n" +
             "1. Golf\n" +
             "2. Bowling\n" +
             "3. Amusement Park\n" +
             "4. Concert");
            int outingType = ParseInput();

            OutingType type;
            switch (outingType)
            {
                default:
                case 1:
                    type = OutingType.Golf;
                    break;
                case 2:
                    type = OutingType.Bowling;
                    break;
                case 3:
                    type = OutingType.AmusementPark;
                    break;
                case 4:
                    type = OutingType.Concert;
                    break;

            }
            

            Console.WriteLine($"How many people attended");
            int numberPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of outing(dd/mm/yy");
            DateTime outingDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cost per person");
            decimal outingCpp = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cost per event");
            decimal costPerEvent = decimal.Parse(Console.ReadLine());

            OutingEvent outing = new OutingEvent(type, numberPeople, outingDate, outingCpp, costPerEvent);

            _outingRepo.AddOutingToList(outing);
            Console.WriteLine($"\"{outing.OutingCPP}\" added to list:");
            Console.ReadKey();
        }

        private void PrintAllOuting()
        {
            bool outingEmpty = true;

            foreach (OutingEvent outing in _outingEvent)
            {
                Console.WriteLine($"{outing.EventType} {outing.NumberPeople} {outing.OutingDate} {outing.OutingCPP} {outing.CostPerEvent}");
                outingEmpty = false;

            }
            if (outingEmpty)
            {
                Console.WriteLine("outing is empty");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

        private int ParseInput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }

    }
}
