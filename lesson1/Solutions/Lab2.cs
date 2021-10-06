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
            Console.Write("Birhdate\nEnter month: ");
            var month = Console.ReadLine();
            Console.Write("Enter date: ");
            var date = Console.ReadLine();
            Console.WriteLine("Birthday is " + int.Parse(month).ToString("D2") + "-" + int.Parse(date).ToString("D2"));
        }

        public void problem4()
        {
            Console.Write("Birhdate\nEnter month and date: ");
            var birthday = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Birthday is " + int.Parse(birthday[0]).ToString("D2") + "-" + int.Parse(birthday[1]).ToString("D2"));
        }
    
    }
}