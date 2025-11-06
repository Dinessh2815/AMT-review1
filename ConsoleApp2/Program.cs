namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {-2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int first = 0;
            int second = 0;
            int currentSum = 0;
            int maxSum = 0;

            while(second < arr.Length)
            {
                currentSum = arr[second];

                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
    }
}
