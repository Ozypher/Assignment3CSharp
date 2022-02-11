using System;

namespace Array_Reverser
{
    class Array_Reverser
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }
        static int[] GenerateNumbers()
        {
            Console.WriteLine("Old Array: ");
            int[] test = new int[10];
            Random randNum = new Random();
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = randNum.Next(0, 10);
            }
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + ", ");
            }
            return test;
        }
        static void Reverse(int[] arr)
        {
            Array.Reverse(arr, 0, arr.Length);
        }

        static void PrintNumbers(int[] arr)
        {
            Console.WriteLine("\nNew Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
    }
}
