using System;

namespace while_loop_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.while_loop();
            p.do_while();
            
        }

        void while_loop()
        {

            Console.Write("Please the enter a number : ");
            int target = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= target)
            {
                Console.Write(start + " ");
                start += 2;
            }
        }

        void do_while()
        {
            string choice = " ";

            do
            {
                Console.Write("Please the enter a number : ");
                int target = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= target)
                {
                    Console.Write(start + " ");
                    start += 2;
                }

                do
                {
                    Console.WriteLine("Do you Want to continue - Yes or No ");

                    choice = Console.ReadLine().ToUpper();

                    if (choice != "YES" && choice != "NO")
                    {
                        Console.WriteLine("Invalid Choice please Enter Yes or No");
                    }
                }
                while (choice != "YES" && choice != "NO");
            } while (choice == "YES");
        }
    }
}
