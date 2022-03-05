using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class HealthAnalyzer
    {

        public int CheckTemperaturePercentage(int Xtemp)
        {
            IDictionary<int, int> tempMapper = new Dictionary<int, int>()
            {
                {39, 5 },
                {40, 10 },
                {41, 15 },
                {42, 20 }
            };
            if (Xtemp > 38 && Xtemp <= 42)
            {
                foreach (var kvp in tempMapper)
                {
                    if (Xtemp == kvp.Key)
                    {
                        
                        return kvp.Value;
                    }
                }
            }
            return 0;
            
        }

        //check heart rate
        public int CheckHeartRate(int Xbpm)
        {
            int chanceOfDying = 2;
            int lowerThanNormal = 0;
            if (Xbpm < 85)
            {
                lowerThanNormal += 85 - Xbpm;
                int result = lowerThanNormal / 5 * chanceOfDying;
                
                return result;
            }

            int higherThanNormal = 0;
            if (Xbpm > 85)
            {
                higherThanNormal += Xbpm - 85;
                int result = higherThanNormal / 5 * chanceOfDying;
                
                return result;
            }

            return 0;
        }

        //check cardiac related symptoms
        public int CheckCardiacRelated(bool Xage)
        {
            int cardiacChecker = Xage == true ? 7 : 0;
            
            return cardiacChecker;
        }

        //check diabetic history
        public int CheckDiabeticHistory(bool XDiabetic)
        {
            int result = XDiabetic == true ? 12 : 0;
            
            return result;
        }

        //check fever symptoms
        public int CheckFeverSymptoms(bool XFever)
        {
            int result = XFever == true ? 15 : 0;
            return result;
        }

    }
}
