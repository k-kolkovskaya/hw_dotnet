using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class Circle : Base
    {
        public Circle(int side) : base(side, "circle")
        {

        }

        public override double GetSquare()
        {
            return Math.Round(((Math.PI) * Math.Pow(Side, 2)), 3);
        }
    }
}
