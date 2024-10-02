using System.Buffers;

namespace assignment5
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
            int[] numbers = new int[100];

            ReadNumbers(numbers);

            Console.Write("Enter a search value: ");
            int searchValue = int.Parse(Console.ReadLine());
            
            int count = CountSearchValue(numbers, searchValue);

            Console.WriteLine($"The number {searchValue} occurs {count} time(s)");

            Console.ReadLine();
        }

        void ReadNumbers(int[] numbers)
        {
            int i = 0;
            int input;


            do
            {
                Console.Write("Enter a number (0 to stop): ");
                input = int.Parse(Console.ReadLine());

                if (input != 0)
                {
                    numbers[i] = input;
                    i++;
                }
            } while (input != 0 && i < numbers.Length);
        }

        int CountSearchValue(int[] numbers, int searchValue)
        {
            int count = 0;

            foreach (int number in numbers)
            {
                if (number == searchValue)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
