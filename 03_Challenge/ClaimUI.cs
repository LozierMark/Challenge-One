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
        private Queue<Claim> _claims;
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
                "4. Exit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ViewClaims();
                    break;
                case 2:
                    PrintAllClaims();
                    break;
                case 3:
                  EnterNewClaim();
                    break;
                case 4:
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
                _claimRepo.Enqueue(claimItem);
                Claim claimItem2 = new Claim(2, "House", "House fire in kitchen.", 4000.00, "4/26/18", "4/28/18", true);
                _claimRepo.Enqueue(claimItem2);
                Claim claimItem3 = new Claim(3, "Theft", "Stolen pancakes.", 4.00, "4/27/18", "6/1/18", false);
                _claimRepo.Enqueue(claimItem3);

            }
               bool yes = bool.Parse(answer);
            if (response == true)
            {
               
            }
            else
            {
                Console.WriteLine("Thanks for your interest. The program is going to close now. press any key to continue");
                Console.ReadKey();
            }
            private void EnterNewClaim()
            {

                Console.WriteLine("Enter the claim id:\n");
                string claimId = Console.ReadLine();

                Console.WriteLine("Please enter the claim type:\n");
                string claimType = Console.ReadLine();

                Console.WriteLine("Please enter claim description:\n");
                string claimDescription = Console.ReadLine();

                Console.WriteLine("Please enter claim amount:\n");
                double ClaimAmount = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter incident date:\n");
                DateTime incidentDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Please enter valid claim:\n");
                bool validClaim = bool.Parse(Console.ReadLine());
                
                Claim claimItem = new Claim(claimId, claimType, claimDescription, claimAmount, incidentDate);

                _claimRepo.AddItemToClaim(claimItem);

                Console.WriteLine($"\"{claimItem.ClaimID}\" added to the claim. press any key to continue");
                Console.ReadKey();
            }
            private void ViewClaims()
            {
            Claim claim1 = _claimRepo.PeekAtClaimQueue();
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
        private void PrintAllClaims()
            {
                bool claimsEmpty = true;

                foreach (Claim claim in _claims)
                {
                    Console.WriteLine($"{claim.ClaimID} {claim.ClaimType} {claim.ClaimDescription} {claim.ClaimAmount} {claim.IncidentDate} {claim.ClaimDate} {claim.ValidClaim}");
                claimsEmpty = false;

                }
                if (claimsEmpty)
                {
                    Console.WriteLine("claims is empty");
                }
                Console.WriteLine("press any key to continue");
                Console.ReadKey();

            }
        private void RemoveClaims()
        {
            Console.Clear();
            PrintAllClaims();

            Console.WriteLine("What is the claim id that you want to remove?");
            string claimId = Console.ReadLine();

            bool success = _claimRepo.Dequeue(claimId);
            if (success == true)
            {
                Console.WriteLine("Claim id for {claimId} was successfully removed. press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The claim for {claimId} was unable to be removed at this time. press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }
}
