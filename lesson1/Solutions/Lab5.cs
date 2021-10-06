using System;
using System.Linq;

namespace lesson1.Solutions
{
    class Lab5
    {
        public void problem1()
        {
            int t = int.Parse(Console.ReadLine());
            if (t >= 40 || t < 0)
            {
                Console.WriteLine("ichkarida o'yna");               
            }
            else
            {
                Console.WriteLine("tashqarida o'yna");
            }
        }        
    }
}