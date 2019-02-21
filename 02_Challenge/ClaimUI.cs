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
        private bool claimsEmpty;

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
                Claim Claimitem = new Claim(1, "Car", "Car accident on 464.", 400.00, new DateTime(2018,04,25),new DateTime(2018,04,27), true);
                _claimRepo.Enqueue(Claimitem);
                Claim Claimitem2 = new Claim(2, "House", "House fire in kitchen.", 4000.00, new DateTime(2018,04,26),new DateTime(2018,04,28), true);
                _claimRepo.Enqueue(Claimitem2);
                Claim Claimitem3 = new Claim(3, "Theft", "Stolen pancakes.", 4.00, new DateTime(2018,04,27),new DateTime(2018,04,27), false);
                _claimRepo.Enqueue(Claimitem3);

            }
            
            if (response == true)
            {

            }
            else
            {
                Console.WriteLine("Thanks for your interest. The program is going to close now. press any key to continue");
                Console.ReadKey();
            }


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

            Console.WriteLine("Do you want to remove the next claim?");
            string answer = Console.ReadLine();

            if(answer == "yes")
            {
                _claimRepo.Dequeue();
                Console.WriteLine("Claim was successfully removed, press any key to continue");
                Console.ReadKey();
            }
                
        }

        private void ViewClaims()
        {
            Claim claim1 = _claimRepo.PeekAtClaimQueue();
        }
        private void EnterNewClaim()
        {

            Console.WriteLine("Enter the claim id:\n");
            int claimId = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the claim type:\n");
            string claimType = Console.ReadLine();

            Console.WriteLine("Please enter claim description:\n");
            string claimDescription = Console.ReadLine();

            Console.WriteLine("Please enter claim amount:\n");
            double claimAmount = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter incident date:\n");
            DateTime incidentDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please enter claim date:\n");
            DateTime claimDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please enter valid claim:\n");
            bool validClaim = bool.Parse(Console.ReadLine());

            Claim Claimitem = new Claim(claimId, claimType, claimDescription, claimAmount, incidentDate,claimDate, validClaim);

            _claimRepo.Enqueue(Claimitem);

            Console.WriteLine($"\"{Claimitem.ClaimID}\" added to the claim. press any key to continue");
            Console.ReadKey();
        }
    }
}
