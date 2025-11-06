using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 7, 9, 11 };
            int count = 0;
            bool isPrime = false;

            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = 2; j < i; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        if (arr[i] % arr[j] != 0)
                        {
                            isPrime = true;

                        }
                        else
                        {
                            isPrime = false;
                            break;


                        }
                        if (isPrime)
                        {
                            count++;
                        }
                    }
                }
            }
              Console.WriteLine($"The number of prime numbers are : {count}");
        }
    }
}
