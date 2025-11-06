namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {-2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int currentSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            Console.Write(maxSum);
        }
    }
}
