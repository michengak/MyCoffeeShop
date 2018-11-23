using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeeCost = 0;

            Console.WriteLine("Please select your coffee size:\n 1- small, 2- Meduim, 3- Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;

                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    break;
            }

            Console.WriteLine("Do you want to buy another coffee : Yes or No?");
                String UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {

            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);

        }
    }
}
