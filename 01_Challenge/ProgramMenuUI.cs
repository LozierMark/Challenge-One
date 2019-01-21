using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    class ProgramMenuUI
    {
        private MenuRepository _menuRepo;
        private List<Menu> _menus;
        private bool running = true;

        //This is a constructor for the ProgramMenuUI, inside of the constructor are items I want created when an instance of ProgramMenuUI is initialized.
        public ProgramMenuUI()
        {
            _menuRepo = new MenuRepository();
            _menus = _menuRepo.GetOrderedMenus();
        }

        public void Run()
        {
            StartDialogue();
            while (running)
            {
                Console.Clear();
                Menu();
            }
        }

        private void Menu()
        {
            Console.WriteLine("1. Add Menu Item\n" +
                "2. Print Menu Items\n" +
                "3. Remove Menu by Menu Number\n" +
                "4. Exit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AddMenuItem();
                    break;
                case 2:
                    PrintAllMenus();
                    break;
                case 3:
                    RemoveMenu();
                    break;
                case 4:
                    running = false;
                    break;
                default:

                    break;
            }
        }

        private void RemoveMenu()
        {
            Console.Clear();
            PrintAllMenus();

            Console.WriteLine("What is the meal number that you want to remove?");
            string mealNumber = Console.ReadLine();

            bool success = _menuRepo.RemoveMenu(mealNumber);
            if (success == true)
            {
                Console.WriteLine($"Meal number for {mealNumber} was successfully removed. press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The order for {mealNumber} was unable to be removed at this time. press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }

        private void StartDialogue()
        {
            Console.WriteLine("Weclome to  Mark's market...Would you like to order a meal or update the menu, yes or no?");
            string answer = Console.ReadLine().ToLower();
            bool response = false;
            if (answer == "yes")
            {
                response = true;
            }
            //    bool yes = bool.Parse(answer);
            if (response == true)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Thanks for your interest. The program is going to close now. press any key to continue");
                Console.ReadKey();
            }
        }

        private void AddMenuItem()
        {

            Console.WriteLine("Enter the meal number:\n" );
            string mealNumber = Console.ReadLine();

            Console.WriteLine("Please enter the meal name:\n");
            string mealName = Console.ReadLine();

            Console.WriteLine("Please enter description:\n");
            string description = Console.ReadLine();

            Console.WriteLine("Please enter ingredients:\n");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Please enter price:\n");
            decimal orderPrice = decimal.Parse(Console.ReadLine());
            Menu menuItem = new Menu(mealNumber, mealName, description, ingredients, orderPrice);

            _menuRepo.AddItemToMenu(menuItem);

            Console.WriteLine($"\"{menuItem.MealNumber}\" added to the menu. press any key to continue");
            Console.ReadKey();
        }

        private void PrintAllMenus()
        {
            bool menuEmpty = true;

            foreach (Menu menu in _menus)
            {
                Console.WriteLine($"{menu.MealNumber} {menu.MealName} {menu.Description} {menu.Ingredients} {menu.OrderPrice}");
                menuEmpty = false;

            }
            if (menuEmpty)
            {
                Console.WriteLine("menu is empty");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}