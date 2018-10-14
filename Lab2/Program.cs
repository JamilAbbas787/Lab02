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

            if (doesUserWantToContinue == "y")
            {
                while (doesUserWantToContinue == "y")
                {
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
                Console.WriteLine("Invalied Entry!!!");
            }

            Console.ReadKey();

        }
    }
}
