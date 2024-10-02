using System.Diagnostics.CodeAnalysis;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            int[] numbers = new int[3];

            FillArray(numbers);

            int sum = CalculateSum(numbers);

            double avg = CalculateAverage(numbers);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {avg}");
            Console.ReadLine();
        }

        void FillArray(int[] numbers)
        {
            Console.WriteLine("Enter 3 integers");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        int CalculateSum(int[] numbers)
        { 
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            return (double)sum / numbers.Length;
        }
    }
}
