using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Patient
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public int TempInCelsius { get; set; }
        public int HeartRate { get; set; }
        public bool Cardiac { get; set; }
        public bool DiabeticHistory { get; set; }
        public bool FeverSymptoms { get; set; }

        public override string ToString()
        {
            return $"Patient {Fullname}";
        }
    }
}
