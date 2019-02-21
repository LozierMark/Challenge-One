using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    class ProgramBadgeUI
    {
        private BadgeRepository _badgeRepo;
        private Dictionary<int, Badge> _badges;

        public ProgramBadgeUI()
        {
            _badgeRepo = new BadgeRepository();
            _badges = _badgeRepo.GetBadges();
            DataList();
        }
        private void DataList()
        {
            List<string> doorsOne = new List<string> { "A1", "A2", "B1", "B2" };
            List<string> doorsTwo = new List<string> { "C1", "C2", "D1", "D2" };
            Badge badge = new Badge(101, doorsOne);
            Badge badgeTwo = new Badge(102, doorsTwo);

            _badgeRepo.AddBadge(101, badge);
            _badgeRepo.AddBadge(102, badgeTwo);
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin, what would you like to do?\n" +
                    "1. Add a Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. List All Badges\n" +
                    "4. Exit application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        AddBadge();
                        break;
                    case 2:
                        //UpdateBadge();
                        break;
                    case 3:
                        //ListAllBadges();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
        private void AddBadge()
        {
            Console.WriteLine("What is the number on the badge?");
            string badgeID = Console.ReadLine();
            int badgeNbr = int.Parse(badgeID);

            List<string> doorNames = new List<string>();
            bool addDoor = true;
            while (addDoor)
            {
                Console.WriteLine("List a door that this badge needs access to.");
                string response = Console.ReadLine().ToUpper();
                doorNames.Add(response);
                Console.WriteLine("Any other doors? (y/n) ");
                string yesNo = Console.ReadLine().ToUpper();
                if (yesNo == "N")
                {
                    // Add the badgeNbr and List to the BadgeRepo
                    Badge tempBadge = new Badge(badgeNbr, doorNames);
                    _badgeRepo.AddBadge(badgeNbr, tempBadge);
                    addDoor = false;
                }
            }

            //private void UpdateBadge()
            //{
            //    Console.WriteLine("What is the badge number to update?");
            //    string badgeID = Console.ReadLine();
            //    int badgeNbr = int.Parse(badgeID);
            //    foreach (KeyValuePair<int, Badge> badgeList in _badges)
            //    {
            //        foreach (string door in Badge.Value)
            //        {
            //            if (badgeList.Key = badgeID)
            //                Console.WriteLine($"Badge ID#{badgeID} has access to: {door} ");
            //        }
            //    }


        }
        private void ListAllBadges()
        {
            bool badgeEmpty = true;
            int tempBadgeNbr = 0;
            bool doorEmpty = false;

            foreach (KeyValuePair<int, Badge> badgeList in _badges)
            {
                tempBadgeNbr = badgeList.Key;
                doorEmpty = false;
                Badge temp = new Badge();
                temp = badgeList.Value;
                Console.WriteLine(temp.BadgeID);
                List<string> tempString = new List<string> { };
                tempString = temp.Doors;
                foreach (string doorNbr in tempString)
                {
                    Console.WriteLine(doorNbr);
                    doorEmpty = true;
                }
                if (doorEmpty == false)
                {
                    badgeEmpty = false;
                }
            }
            if (badgeEmpty)
            {
                Console.WriteLine("Badge is empty");

                Console.WriteLine("press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
