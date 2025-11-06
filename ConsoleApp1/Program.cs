using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 7, 9, 11 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isPrime = true;

                if (arr[i] <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 2; j * j <= arr[i]; j++)
                    {
                        if (arr[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    count++;
                }
            }

            Console.WriteLine($"The number of prime numbers are : {count}");
        }
    }
}
