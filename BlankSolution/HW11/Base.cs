using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class Base
    {
        public int Square { get; set; }
        public int Side { get; set; }
        public string Name { get; set; }

        public Base (int side, string name)
        {
            Side = side;
            Name = name;
        }

        public virtual double GetSquare()
        {
            return Square;
        }
    }
}
