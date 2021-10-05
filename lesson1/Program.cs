using System;
using System.Linq;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = Console.ReadLine();
            // Console.WriteLine("Welcome, " + name + ".");
            // Console.WriteLine(float.MaxValue.ToString() + " " + int.MinValue.ToString());

            var inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // foreach(string input in inputs)
            // {
            //     int son = 0;
            //     bool parsed = int.TryParse(input, out son);
            //     if(parsed)
            //     {
            //         System.Console.WriteLine(son);
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Not integer");
            //     }
                
            // }
            var ints = inputs.Select(i => 
            {
                int son = int.Parse(i);
                Console.WriteLine(son);
                return son;
            }).ToList();
        }
    }
}
