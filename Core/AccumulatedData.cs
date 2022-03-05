using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AccumulatedData
    {
        public int ChancePredictor(Patient person, HealthAnalyzer checker)
        {
            int data1 = checker.CheckTemperaturePercentage(person.TempInCelsius);
            int data2 = checker.CheckHeartRate(person.HeartRate);
            int data3 = checker.CheckCardiacRelated(person.Cardiac);
            int data4 = checker.CheckDiabeticHistory(person.DiabeticHistory);
            int data5 = checker.CheckFeverSymptoms(person.FeverSymptoms);

            int sum = data1 + data2 + data3 + data4 + data5 + 1;

            return sum;
        }
    }
}
