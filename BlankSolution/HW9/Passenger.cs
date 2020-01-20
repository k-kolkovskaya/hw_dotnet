using System;
using System.Collections.Generic;
using System.Text;

namespace HW9
{
    class Passenger
    {
        public string FullName { get; set; }
        public int DateOfBirth { get; set; }
        public string Passport { get; set; }
        public string Flight { get; set; }

        public Passenger(string fullName, int dateOfBirth, string passport, string flight)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Passport = passport;
            Flight = flight;
        }

        
    }
}
