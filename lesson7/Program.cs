using System;
using System.Threading;
using System.Threading.Tasks;
 
namespace FactorialApp
{
    class Program
    {
        delegate void Operation(int n);
    	static void Factorial(int n)
    	{
        	int result = 1;
        	for (int i = 1; i <= n; i++)
        	{
            	result *= i;
        	}
        	Thread.Sleep(5000);
        	Console.WriteLine($"{n} faktorial {result} ga teng");
    	}
        static void Fib(int n)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"{n} fibonacci {Fibo(n)} ga teng");
        }
        static void Kub(int n)
        {
            Console.WriteLine($"{n} sonining kubi {n*n*n}ga teng");
        }
        static int Fibo(int n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }
            return Fibo(n-1) + Fibo(n-2);
        }
    	static async void FactorialAsync(int n)
    	{
        	Console.WriteLine("Metodning boshlanishi FactorialAsync"); 
        	await Task.Run(() => Factorial(n));            
        	Console.WriteLine("Metodning tugashi FactorialAsync");
    	}
        static async void FibAsync(int n)
        {
            Console.WriteLine("Metodning boshlanishi FibAsync"); 
        	await Task.Run(() => Fib(n));            
        	Console.WriteLine("Metodning tugashi FibAsync");
        }
        static int Test()
        {
            Console.WriteLine($"Sana 5 gacha");
            
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}");
                Thread.Sleep(1000);
            }
            return 1;
        }
    	static void Main(string[] args)
    	{
        	Console.WriteLine("Son kiriting: ");
        	int n = Int32.Parse(Console.ReadLine());
            Operation del = FactorialAsync;
            del += FibAsync;
            del += Kub;
            // int t = Test();
            del?.Invoke(n);
            int t = Test();
            // del(n);
            // FactorialAsync(n);   // asinxron metodni chaqiradi
        	Console.WriteLine($"Sonning kvadrati {n * n}");
        	Console.Read();
    	}
	}
}