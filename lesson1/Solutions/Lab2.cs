using System;

namespace lesson1.Solutions
{
    class Lab2
    {
        public void problem1()
        {
            Console.WriteLine("222222\n2    2\n2    2\n222222");
        }

        public void problem2()
        {
            Console.WriteLine("  A\n A A\nAAAAA");
        }

        public void problem3()
        {
            Console.WriteLine("Birhdate\nEnter month: ");
            var month = Console.ReadLine();
            Console.WriteLine("Enter date: ");
            var date = Console.ReadLine();
            Console.WriteLine("Birthday is " + int.Parse(month).ToString("D2") + "-" + int.Parse(date).ToString("D2"));
        }
    }
}