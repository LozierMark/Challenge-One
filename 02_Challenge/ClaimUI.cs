using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    class ClaimUI
    {
        private ClaimRepository _claimRepo;
        private List<Claim> _claims;
        private bool running = true;
        public int claimToProcess = 0;

        //This is a constructor for the ProgramMenuUI, inside of the constructor are items I want created when an instance of ProgramMenuUI is initialized.
        public ClaimUI()
        {
            _claimRepo = new ClaimRepository();
            _claims = _claimRepo.GetClaims();
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
            Console.WriteLine("1. View All Claims\n" +
                "2. Process Next Claim\n" +
                "3. Enter New Claim\n" +
                "4. Edit Claim\n" +
                "5. Exit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ViewClaims();
                    break;
                case 2:
              //      PrintAllMenus();
              // May want to provide option in process next claim to edit and remove edit from the menu
                    break;
                case 3:
              //      RemoveMenu();
                    break;
                case 4:
               // Edit Claim
                    break;
                case 5:
                    running = false;
                    break;
                default:

                    break;
            }
        }
        private void StartDialogue()
        {
            Console.WriteLine("Do you want to process Claims? Please enter yes or no?");
            string answer = Console.ReadLine().ToLower();
            bool response = false;
            if (answer == "yes")
            {
                response = true;
                // Load initial Claim Data
                Claim claimItem = new Claim(1, "Car", "Car accident on 464.", 400.00, "4/25/18", "4/27/18", true);
                _claimRepo.AddClaim(claimItem);
                Claim claimItem2 = new Claim(2, "House", "House fire in kitchen.", 4000.00, "4/26/18", "4/28/18", true);
                _claimRepo.AddClaim(claimItem2);
                Claim claimItem3 = new Claim(3, "Theft", "Stolen pancakes.", 4.00, "4/27/18", "6/1/18", false);
                _claimRepo.AddClaim(claimItem3);

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
        private void ViewClaims()
        {
            bool claimsEmpty = true;

            foreach (Claim claim in _claims)
            {
                Console.WriteLine($"{claim.ClaimID} {claim.ClaimType} {claim.ClaimDescription} {claim.ClaimAmount} {claim.IncidentDate} {claim.ClaimDate} {claim.ValidClaim}");
                claimsEmpty = false;

            }
            if (claimsEmpty)
            {
                Console.WriteLine("There are no claims to view.");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
