using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_08
{
    public class RiskRepository
    {
        public decimal SpeedingMod(Risk risk)
        {
            decimal speedMod = 1m;
            switch (risk.SpeedingInfractionsPerYear)
            {
                case 0:
                    speedMod = 0.95m;
                    return speedMod;
                case 1:
                    speedMod += 0.05m;
                    return speedMod;
                case 2:
                    speedMod += 0.1m;
                    return speedMod;
                case 3:
                    speedMod += 0.15m;
                    return speedMod;
                case 4:
                    speedMod += 0.2m;
                    return speedMod;
                default:
                    speedMod += 0.25m;
                    return speedMod;
            }

        }

        public decimal SwervingMod(Risk risk)
        {
            decimal swerveMod = 1m;
            switch (risk.SwervesPerMonth)
            {
                case 0:
                    swerveMod = 0.95m;
                    return swerveMod;
                case 1:
                    swerveMod += 0.05m;
                    return swerveMod;
                case 2:
                    swerveMod += 0.1m;
                    return swerveMod;
                case 3:
                    swerveMod += 0.15m;
                    return swerveMod;
                case 4:
                    swerveMod += 0.2m;
                    return swerveMod;
                default:
                    swerveMod += 0.25m;
                    return swerveMod;
            }

        }

        public decimal RollingStopMod(Risk risk)
        {
            decimal rollingStopMod = 1m;
            switch (risk.RollingStopsPerMonth)
            {
                case 0:
                    rollingStopMod = 0.95m;
                    return rollingStopMod;
                case 1:
                    rollingStopMod += 0.05m;
                    return rollingStopMod;
                case 2:
                    rollingStopMod += 0.1m;
                    return rollingStopMod;
                case 3:
                    rollingStopMod += 0.15m;
                    return rollingStopMod;
                case 4:
                    rollingStopMod += 0.2m;
                    return rollingStopMod;
                default:
                    rollingStopMod += 0.25m;
                    return rollingStopMod;
            }

        }

        public decimal TailgatingMod(Risk risk)
        {
            decimal tailgateMod = 1m;
            switch (risk.TailgatesPerMonth)
            {
                case 0:
                    tailgateMod = 0.95m;
                    return tailgateMod;
                case 1:
                    tailgateMod += 0.05m;
                    return tailgateMod;
                case 2:
                    tailgateMod += 0.1m;
                    return tailgateMod;
                case 3:
                    tailgateMod += 0.15m;
                    return tailgateMod;
                case 4:
                    tailgateMod += 0.2m;
                    return tailgateMod;
                default:
                    tailgateMod += 0.25m;
                    return tailgateMod;
            }

        }

        public decimal InsurancePremium(decimal speeding, decimal swerving, decimal tailgating, decimal rollingstops)
        {
            decimal premium = 200m;
            decimal riskModifier = 1 * speeding * swerving * tailgating * rollingstops;
            decimal result = premium * riskModifier;
            return result;
        }
    }
}
    

