namespace assignment7
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
            bool[] seats = new bool[10];

            InitializeSeats(seats);

            Console.WriteLine("Initial seating arrangement: ");
            DisplaySeatingArrangement(seats);

            Console.Write("\nEnter the seat number you want to book (1-10): ");
            int seatNumber = int.Parse(Console.ReadLine());

            BookSeat(seats, seatNumber);

            Console.WriteLine("\nUpdated seat arrangement: ");
            DisplaySeatingArrangement(seats);

            Console.ReadLine();
        }

        void InitializeSeats(bool[] seats)
        {
            Random random = new Random();
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = random.Next(2) == 0;
            }
        }

        void DisplaySeatingArrangement(bool[] seats)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                Console.WriteLine($"Seat {i + 1}: {(seats[i] ? "Avaliable" : "Booked")}");
            }
        }

        void BookSeat(bool[] seats, int seatNumber)
        {
            if (seats[seatNumber - 1])
            {
                seats[seatNumber - 1] = false;
                Console.WriteLine($"Seat {seatNumber} has been successfully booked!");
            }
            else
            {
                Console.WriteLine($"Seat {seatNumber} is already booked.");
            }
        }
    }
}
