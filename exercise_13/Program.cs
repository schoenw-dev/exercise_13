using System;

namespace exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string userResponse = "";

            while (repeat)
            {
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);

                for (int i = userNumber; i >= 0; i--)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine("Would you like to continue? (y|n)");
                userResponse = Console.ReadLine();

                if (userResponse == "y")
                {
                    repeat = true;
                }
                else if (userResponse == "n")
                {
                    repeat = false;
                }

            }

            Console.WriteLine("Goodbye!");
        }
    }
}
