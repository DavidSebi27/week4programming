namespace assignment1
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
            int num = 1;
            foreach (int i in numbers)
            {
                Console.WriteLine($"Element {num} is: {i}");
                num++;
            }
        }
    }
}
