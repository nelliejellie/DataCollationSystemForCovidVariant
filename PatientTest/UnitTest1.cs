using System;
using Xunit;
using Core;

namespace PatientTest
{
    public class UnitTest1
    {
        //Arrange
        Patient raf = new Patient()
        {
            Fullname = "Raphael Isaac",
            Age = 24,
            TempInCelsius = 41,
            HeartRate = 95,
            Cardiac = false,
            DiabeticHistory = false,
            FeverSymptoms = false
        };
        HealthAnalyzer h = new HealthAnalyzer();
        [Fact]
        public void CheckIfToStringWorks()
        {
            //Act
            var expected = "Patient Raphael Isaac";
            var actual = raf.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckIfToTempWorks()
        {
            //Arrange

            //Act
            var expected = 15;
            var actual = h.CheckTemperaturePercentage(raf.TempInCelsius);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfToHeartIsHighOrLow()
        {
            //Arrange
           

            //Act
            var expected = 4;
            var actual = h.CheckHeartRate(raf.HeartRate);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckIfCardiac()
        {
            //Arrange
            

            //Act
            var expected = 0;
            var actual = h.CheckCardiacRelated(raf.Cardiac);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfDiabetic()
        {
            //Arrange
            

            //Act
            var expected = 0;
            var actual = h.CheckDiabeticHistory(raf.DiabeticHistory);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckAccumulatedResult()
        {
            //Arrange
            AccumulatedData d = new AccumulatedData();


            //Act
            var expected = 20;
            var actual = d.ChancePredictor(raf, h);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
