namespace assignment6
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
            int[] dice = new int[6];
            int numberOfThrows = 6000;

            for (int i = 0; i < 6; i++)
            {
                dice[i] = 0;
            }

            ThrowDice(dice, numberOfThrows);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Number of throws of value {i+1} = {dice[i]}");
            }

            Console.ReadLine();
        }

        void ThrowDice(int[] dice, int numberOfThrows)
        {
            Random random = new Random();
            for (int i = 0; i < numberOfThrows; i++)
            {
                int throws = random.Next(1,7);
                dice[throws-1] = dice[throws-1] +1;
            }
        }
    }
}
