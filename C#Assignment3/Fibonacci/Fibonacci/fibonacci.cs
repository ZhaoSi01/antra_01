using System;
namespace Fibonacci
{
	public class fibonacci
	{
        public static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Fibonacci({0}): {1} ",i+1, fib(i));
                
            }
        }

        static int fib(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            int f0 = 1;
            int f1 = 1;

            int p2 = 1;

            while (p2 < n)
            {
                int tmp = f0;
                f0 = f1;
                f1 = tmp + f1;
                p2++;
            }
            return f1;

        }
    }
}

