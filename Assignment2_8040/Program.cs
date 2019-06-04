using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_8040
{
    class Program
    {
        public static int ValidateTriangleInput(string triSide)
        {
            int side = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {triSide} of your triangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out side);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }
                else if (side <= 0)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {triSide} of your triangle is {side}.\n");
                }
            }
            return side;
        }
        static void Main(string[] args)
        {
            bool validSelection = false;
            string triangleSelection;

            while (validSelection == false)
            {
                do
                {
                    Console.WriteLine("1 = Enter triangle dimensions");
                    Console.WriteLine("2 = Exit");
                    Console.WriteLine("Choose a menu item to begin:");

                    triangleSelection = Console.ReadLine();
                    Console.WriteLine();

                    if (triangleSelection != "1" && triangleSelection != "2")
                    {
                        Console.WriteLine("That's not a valid selection, please try again.\n");
                    }
                    else if (int.Parse(triangleSelection) == 1)
                    {
                        validSelection = true;
                        int side1;
                        int side2;
                        int side3;

                        side1 = ValidateTriangleInput("side 1");

                        side2 = ValidateTriangleInput("side 2");

                        side3 = ValidateTriangleInput("side 3");

                        Console.WriteLine(TriangleSolver.Analyze(side1, side2, side3));
                    }
                    else if (int.Parse(triangleSelection) == 2)
                    {
                        validSelection = true;
                    }
                    Console.WriteLine("");
                }
                while (triangleSelection != "2");
            }
        }
    }
}
