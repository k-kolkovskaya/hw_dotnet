using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task2
{
    class Person
    {
        public string Name;
        public int Age;
        public string info;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            info = $"{name}s age is{age}";
        }

        public string GetInfo()
        {
            return info;
        }
    }
}
