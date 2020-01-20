using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task3
{
    public class Ball
    {
        public string ballType { get; set; }

        public Ball(string ballType = "regular")
        {
            this.ballType = ballType;
        }
    }
}
