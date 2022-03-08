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
        /*
         * A more efficient way of recording age is to collect a date of birth and set an age as a difference 
         * between that date and current date
         */
        #region Optional_Logic
        public DateTime DOB { get; set; }
        public int PatientAge
        {
            get
            {
                return DateTime.Today.Year - DOB.Year;
            }
        }

        #endregion

        public int TempInCelsius { get; set; }
        public int HeartRate { get; set; }
        public bool Cardiac { get; set; } 
        /*
         * Cardiac means heart-related. Better name would have been HasCardiacRelatedHistory
         */
        public bool DiabeticHistory { get; set; }
        public bool FeverSymptoms { get; set; }
        // Make use of Has and Is as prefixes for booleans...

        public override string ToString()
        {
            return $"Patient {Fullname}";
            /*
             * I love that you did an override of the ToString method based on what you learnt but 
             * with respect to the method name, I don't support this move.
             * ToString should be used to represent all or most of the information contained
             * within an object and not just the name. A better method name would have been GetName()
             * since you are returning only the patient name
             */
        }
    }
}
