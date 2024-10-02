namespace assignment4
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
            Console.Write("Enter course name: ");
            string coursename = Console.ReadLine();
            Console.Write("Number of students: ");

            string[] students = new string[int.Parse(Console.ReadLine())];
            Console.WriteLine();
            ReadNames(students);
            Console.WriteLine();

            int[] grades = new int[students.Length];
            ReadGrades(grades, students);

            int highestIntex = GetHighestGradeIndex(grades);

            Console.WriteLine($"\nStudent {students[highestIntex]} has the highest grade: {grades[highestIntex]}");

            Console.ReadLine();
        }

        void ReadNames(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                students[i] = Console.ReadLine();
            }
        }

        void ReadGrades(int[] grades, string[] students)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade of {students[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }

        int GetHighestGradeIndex(int[] grades)
        {
            int highestIndex = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > grades[highestIndex])
                {
                    highestIndex = i;
                }
            }
            return highestIndex;
        }
    }
}
