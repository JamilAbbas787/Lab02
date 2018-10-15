using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            Console.Write("Enter Length: ");
            string userLengthInput = Console.ReadLine();
            decimal userLengthInputConverted = decimal.Parse(userLengthInput);

            Console.Write("Enter Width: ");
            string userWidthInput = Console.ReadLine();
            decimal userWidthInputConverted = decimal.Parse(userWidthInput);

            decimal areaOfRoom = userLengthInputConverted * userWidthInputConverted;
            decimal perimeterOfRoom = (userLengthInputConverted * 2) + (userWidthInputConverted * 2);

            Console.WriteLine("Area = " + areaOfRoom);
            Console.WriteLine("Perimeter = " + perimeterOfRoom);



            Console.Write("Continue? (y/n): ");
            string doesUserWantToContinue = Console.ReadLine();

            // James - When comparing strings, I highly recommend you use the string "Equals" method built
            // into strings.  so you could do doesUserWantToContinue.Equals("y", StringComparison.OrdinalIgnoreCase)
            // instead, this will also take care of your casing issue.
            if (doesUserWantToContinue == "y")
            {
                while (doesUserWantToContinue == "y")
                {
                    // James - DRY, Don't repeat yourself ;) we will cover that as we progress
                    // in the course, but essentially you are doing the same work twice.
                    // what you could do is put the top part, starting on line 14 in a 
                    // while loop instead of this part, then you will get the same effect.
                    Console.Write("Enter Length: ");
                    string userLengthInputRoundTwo = Console.ReadLine();
                    decimal userLengthInputConvertedRoundTwo = decimal.Parse(userLengthInputRoundTwo);

                    Console.Write("Enter Width: ");
                    string userWidthInputRoundTwo = Console.ReadLine();
                    decimal userWidthInputConvertedRoundTwo = decimal.Parse(userWidthInputRoundTwo);

                    decimal areaOfRoomRoundTwo = userLengthInputConvertedRoundTwo * userWidthInputConvertedRoundTwo;
                    decimal perimeterOfRoomRoundTwo = (userLengthInputConvertedRoundTwo * 2) + (userWidthInputConvertedRoundTwo * 2);

                    Console.WriteLine("Area =  " + areaOfRoomRoundTwo);
                    Console.WriteLine("Perimeter = " + perimeterOfRoomRoundTwo);

                    // James - if the user enters a capital Y then it will also break out of the code
                    Console.Write("Continue? (y/n): ");
                    string doesUserWantToEnterAnotherRoom = Console.ReadLine();
                    if (doesUserWantToEnterAnotherRoom == "y")
                    {
                        continue;
                    }
                    else if (doesUserWantToEnterAnotherRoom == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry!!!");
                        break;
                    }


                }
            }
            else if (doesUserWantToContinue == "n")
            {
                Console.WriteLine("Good Bye!");
            }
            else
            {
                // I like that you are handling invalid entries! cool deal!
                Console.WriteLine("Invalied Entry!!!");
            }

            Console.ReadKey();

        }
    }
}
