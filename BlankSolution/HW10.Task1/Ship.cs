using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task1
{
    class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt()
        {
            double crewWeight = Crew * 1.5;
            double pureDraft = Draft - crewWeight;
            if (pureDraft > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
