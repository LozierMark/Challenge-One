using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_08
{
    public class RiskUI
    {
        RiskRepository _repo = new RiskRepository();
        Risk Risk = new Risk();

        public void Run()
        {
            bool userContinue = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to our Risk Assessor! " +
                    "Please select an action: " +
                    "\n1) Add new Risk " +
                    "\n2) Exit\n  ");
                int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        AddRisk();
                        break;
                    default:
                        break;
                }
            }
            while (userContinue == true);
        }

        public void AddRisk()
        {
            Risk Risk = new Risk();
            Console.WriteLine("How many speeding violations have they had this year?");
            Risk.SpeedingInfractionsPerYear = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times per month do they swerve outside the lines?");
            Risk.SwervesPerMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rolling stops do they perform per month?");
            Risk.RollingStopsPerMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("How often do they tailgate per month?");
            Risk.TailgatesPerMonth = int.Parse(Console.ReadLine());

            decimal speedMod = _repo.SpeedingMod(Risk);
            decimal swerveMod = _repo.SwervingMod(Risk);
            decimal rollingStopMod = _repo.RollingStopMod(Risk);
            decimal tailgaitingMod = _repo.TailgatingMod(Risk);

            decimal totalCost = _repo.InsurancePremium(speedMod, swerveMod, tailgaitingMod, rollingStopMod);
            Console.WriteLine("Your insurance premium will be $" + Decimal.Round(totalCost, 2) + " per month.");
            Console.ReadKey();
        }

    }
}
    

