using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task4
{
    class Block
    {
        public int width;
        public int length;
        public int height;
        public Block(int[] args)
        {
            width = args[0];
            length = args[1];
            height = args[2];
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetVolume()
        {
            return (width * length * height);
        }

        public int GetSurfaceArea()
        {
            return 2 * (width * length + length * height + width * height);
        }
    }
}
