using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            do
            {
                Console.Write("Enter Length: ");
                string userLength = Console.ReadLine();
                float length = float.Parse(userLength);

                Console.Write("Enter Width: ");
                string userWidth = Console.ReadLine();
                float width = float.Parse(userWidth);

                float area = length * width;
                float perimeter = 2 * (length + width);

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Width: {width}");

                bool isValidYesNo = false;
                do
                {
                    Console.Write("Continue? (y/n): ");
                    string input = Console.ReadLine();
                    if (input.Trim().ToLower() == "n")
                    {
                        playAgain = false;
                        isValidYesNo = true;
                    }
                    else if (input.Trim().ToLower() == "y")
                    {
                        isValidYesNo = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please just enter a 'y' or an 'n'.");
                    }
                } while (isValidYesNo == false);


            } while (playAgain == true);

            Console.WriteLine($"Thanks for playing! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
