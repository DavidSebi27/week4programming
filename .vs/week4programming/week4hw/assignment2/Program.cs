namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        const int NumOfElements = 20;
        const int LowestValue = 1;
        const int HighestValue = 100;
        void Start()
        {
            int[] numbers = new int[NumOfElements];

            FillArray(numbers);

            DisplayArray(numbers);

            int smallest = GetSmallestNumber(numbers);

            Console.WriteLine($"\n\nSmallest number: {smallest}");

            Console.ReadLine();
        }

        void FillArray(int[] numbers)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(LowestValue, HighestValue);
            }
        }

        void DisplayArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
        }

        int GetSmallestNumber (int[] numbers)
        {
            int smallest = numbers[0];

            for (int i = 0; i < NumOfElements; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            return smallest;
        }
    }
}
