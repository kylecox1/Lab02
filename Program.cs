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

                playAgain = AskToContinue();


            } while (playAgain == true);

            Console.WriteLine($"Thanks for playing! Press any key to exit.");
            Console.ReadKey();
        }

        public static bool AskToContinue()
        {

            bool isValidYesNo = false;
            bool playAgain = false;

            while (isValidYesNo = false)
            {
                Console.Write("Continue? (y/n): ");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "n")
                {
                    isValidYesNo = true;
                    playAgain = false;
                }
                else if (input.Trim().ToLower() == "y")
                {
                    isValidYesNo = true;
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine($"Please just enter a 'y' or an 'n'.");
                }
            }

            if (playAgain)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
