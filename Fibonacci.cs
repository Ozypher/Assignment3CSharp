using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int fiboindex;
            Console.WriteLine("What number in the sequence are you looking for?");
            fiboindex = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacciroll(fiboindex));
            
        }
        static int fibonacciroll(int index)
        {
            if(index <= 2)
            {
                return 1;
            }
            else
            {
                return fibonacciroll(index - 1) + fibonacciroll(index - 2);
            }
        }
    }
}
