namespace assignment8
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
            string[] albums = new string[100];
            int numOfAlbums = 0;
            DisplayAlbums(albums, numOfAlbums);

            string answer;
            do
            {
                Console.Write("Do you want to add an album? (yes/no): ");
                answer = Console.ReadLine();

                if (answer == "yes")
                {
                    if (numOfAlbums < albums.Length)
                    {
                        Console.Write($"Enter the name of album {numOfAlbums + 1}: ");
                        albums[numOfAlbums] = Console.ReadLine();
                        numOfAlbums++;
                    }
                    else
                    {
                        Console.WriteLine("No more space to add albums");
                    }
                }
                else
                {
                    break;
                }


            } while (answer != "no");

            if (numOfAlbums != 0)
            {
                Console.Write("Enter the name of the album you want to search for: ");
                string searchAlbum = Console.ReadLine();

                bool isAlbumInArray = FindAlbum(albums, numOfAlbums, searchAlbum);

                if (isAlbumInArray)
                {
                    Console.WriteLine($"The album {searchAlbum} is on your list!");
                }
                else
                {
                    Console.WriteLine($"The album {searchAlbum} in not on your list");
                }
            }
            else
            {
                Console.WriteLine("No albums added.");
            }


            Console.ReadLine();
        }

        void DisplayAlbums(string[] albums, int numOfAlbums)
        {
            if (numOfAlbums == 0)
            {
                Console.WriteLine("No albums added yet.");
                return;
            }
            
            for (int i = 0; i < numOfAlbums; i++)
            {
                Console.WriteLine($"{i + 1}. {albums[i]}");
            }
        }

        bool FindAlbum(string[] albums, int numOfAlbums, string searchAlbum)
        {
            for (int i = 0; i < numOfAlbums; i++)
            {
                if (albums[i] == searchAlbum)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
