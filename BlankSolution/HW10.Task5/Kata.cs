using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW10.Task5
{
    class Kata
    {
        public int[] integerList;
        public int[] valuesList;
        public Kata(int[] integerList, int[] valuesList)
        {
            this.integerList = integerList;
            this.valuesList = valuesList;
        }
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            return integerList.Where(x => !valuesList.Contains(x)).ToArray();
        }
    }
}
