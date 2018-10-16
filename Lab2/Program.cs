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
            decimal.TryParse(userLengthInput, out decimal userLengthInputConverted);

            Console.Write("Enter Width: ");
            string userWidthInput = Console.ReadLine();
            decimal.TryParse(userWidthInput,out decimal userWidthInputConverted);

            decimal areaOfRoom = userLengthInputConverted * userWidthInputConverted;
            decimal perimeterOfRoom = (userLengthInputConverted * 2) + (userWidthInputConverted * 2);

            Console.WriteLine("Area = " + areaOfRoom);
            Console.WriteLine("Perimeter = " + perimeterOfRoom);


            Console.Write("Continue? (y/n): ");
            string doesUserWantToContinue = Console.ReadLine();

            if (doesUserWantToContinue.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                while (doesUserWantToContinue.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter Length: ");
                    userLengthInput = Console.ReadLine();
                    decimal.TryParse(userLengthInput, out userLengthInputConverted);

                    Console.Write("Enter Width: ");
                    userWidthInput = Console.ReadLine();
                    decimal.TryParse(userWidthInput, out userWidthInputConverted);

                    areaOfRoom = userLengthInputConverted * userWidthInputConverted;
                    perimeterOfRoom = (userLengthInputConverted * 2) + (userWidthInputConverted * 2);

                    Console.WriteLine("Area =  " + areaOfRoom);
                    Console.WriteLine("Perimeter = " + perimeterOfRoom);

                    Console.Write("Continue? (y/n): ");
                    doesUserWantToContinue = Console.ReadLine();
                    continue;             
                }
            }
            else if (doesUserWantToContinue.Equals("n", StringComparison.OrdinalIgnoreCase))
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
