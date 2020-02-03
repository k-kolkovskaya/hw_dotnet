using System;
using System.Collections.Generic;
using System.Text;

namespace HW9
{
    class Greeting
    {
        public void Greet (string airport)
        {
            Console.WriteLine($"Добрый день. Вас приветствует аэропорт {airport}. Представьтесь, пожалуйста!");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}, пройдите, пожалуйста, на регистрацию!");
        }
    }
}
