using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("               Welcome to Starbucks              ");
        Start:

            int SizeCost = 0;
            int TotalTypeCost = 0;

            Console.WriteLine("\nChoose Your Coffee Size: ");
            Console.WriteLine("1. Tall ($1)");
            Console.WriteLine("2. Grande ($2)");
            Console.WriteLine("3. Venti ($3)");

            Console.WriteLine("\n");
            int CoffeeSize = 0;

            CoffeeSize = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (CoffeeSize)
            {
                case 1:
                    {
                        SizeCost += 1;
                    TypeOfCoffee:
                        Console.WriteLine("\nChoose Type of Coffee:");
                        Console.WriteLine("--> Mocha ($3)");
                        Console.WriteLine("--> Frap ($5)");
                        Console.WriteLine("\n");
                        string TypeofCofee = Console.ReadLine();
                        switch (TypeofCofee.ToUpper())
                        {
                            case "MOCHA":
                                {
                                    TotalTypeCost += 3;
                                    break;
                                }
                            case "FRAP":
                                {
                                    TotalTypeCost += 5;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("\nInvalid Input. Please try again");
                                    goto TypeOfCoffee;
                                }
                        }
                        break;
                    }


                case 2:
                    {
                        SizeCost += 1;
                    TypeOfCoffee:
                        Console.WriteLine("Choose Type of Coffee: Mocha or Frap");
                        Console.WriteLine("--> Mocha ($3)");
                        Console.WriteLine("--> Frap ($5)");
                        string TypeofCofee = Console.ReadLine();
                        switch (TypeofCofee.ToUpper())
                        {
                            case "MOCHA":
                                {
                                    TotalTypeCost += 3;
                                    break;
                                }
                            case "FRAP":
                                {
                                    TotalTypeCost += 5;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("\nInvalid Input. Please try again");
                                    goto TypeOfCoffee;
                                }
                        }
                        break;
                    }

                case 3:
                    {
                        SizeCost += 3;
                    TypeOfCoffee:
                        Console.WriteLine("Choose Type of Coffee: Mocha or Frap");
                        Console.WriteLine("--> Mocha ($3)");
                        Console.WriteLine("--> Frap ($5)");
                        string TypeofCofee = Console.ReadLine();
                        switch (TypeofCofee.ToUpper())
                        {
                            case "MOCHA":
                                {
                                    TotalTypeCost += 3;
                                    break;
                                }
                            case "FRAP":
                                {
                                    TotalTypeCost += 5;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("\nInvalid Input. Please try again");
                                    goto TypeOfCoffee;
                                }

                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("\nYour choice of {0} is invalid. Please try again", CoffeeSize);
                        goto Start;
                    }

            }


            Console.WriteLine("\nDo you want to order another coffee?");
            string ChoiceToContinue = Console.ReadLine();
            switch (ChoiceToContinue.ToLower())
            {
                case "yes":
                    {
                        goto Start;
                    }
                case "no":
                    {
                        break;
                    }
            }

            Console.WriteLine("\n\nThank you for shopping");
            int TotalCost = SizeCost + TotalTypeCost;
            Console.WriteLine("Your total bill is : ${0}", TotalCost);
            Console.ReadLine();
        }
    }
}
