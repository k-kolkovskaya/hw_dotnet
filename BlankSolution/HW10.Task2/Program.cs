﻿using System;

namespace HW10.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classy Classes
            //Basic Classes, this kata is mainly aimed at the new JS ES6 Update introducing classes
            //Task
            //Your task is to complete this Class, the Person class has been created.You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return
            //johns age is 34

            Person Kris = new Person("Kr", 26);
            Kris.GetInfo();
        }
    }
}
