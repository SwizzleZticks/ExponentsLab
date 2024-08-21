using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;

            do
            {
                Console.Clear();
                int userNumber = GetUserInput();
                PrintTable(userNumber);
                Console.WriteLine();

                isActiveLoop = GetUserChoice();
                Console.WriteLine();

            } while (isActiveLoop);

            Console.WriteLine("Thank you for using my app, press enter to close app...");
            Console.ReadLine();
        }

        static bool GetUserChoice()
        {
            string userInput = "";
            bool isActiveLoop = false;

            do
            {
                Console.Write("Would you like to continue? (Y/N)");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == "Y")
                {
                    isActiveLoop = true;
                }
                if (userInput == "N")
                {
                    isActiveLoop = false;
                }               

            } while (userInput != "Y" && userInput != "N");   
            
            return isActiveLoop;
        }
        static void PrintTable(int userInput)
        {

            Console.WriteLine("Number     Sqaured    Cubed");
            Console.WriteLine("=======    =======    =======");

            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine($"{i}\t   {i * i}\t      {i * i * i}");
            }
        }

        static int GetUserInput()
        {
            int userInput;
            bool isValidInput = false;
            do
            {
                Console.Write("Enter an integer: ");
                isValidInput = int.TryParse(Console.ReadLine(), out userInput);

                if(userInput.ToString().Substring(0,1) == "-" || userInput == 0)
                {
                    Console.WriteLine("Please enter a non-negative, non 0 number.");
                    isValidInput = false;
                }
                if(userInput >= 1290)
                {
                    Console.WriteLine("This number will not fit in a integer value, please use a number less than 1290.");
                    isValidInput = false;
                }
            } while (!isValidInput);

            return userInput;
        }
    }
}
