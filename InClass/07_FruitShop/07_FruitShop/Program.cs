using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double result = 0;

            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    result = quantity * 2.70;
                    Console.WriteLine(result);
                }
                else if (fruit == "apple")
                {
                    result = quantity * 1.25;
                    Console.WriteLine(result);
                }
                else if (fruit == "orange")
                {
                    result = quantity * 0.90;
                    Console.WriteLine(result);
                }
                else if (fruit == "grapefruit")
                {
                    result = quantity * 1.60;
                    Console.WriteLine(result);
                }
                else if (fruit == "kiwi")
                {
                    result = quantity * 3.00;
                    Console.WriteLine(result);
                }
                else if (fruit == "pineapple")
                {
                    result = quantity * 5.60;
                    Console.WriteLine(result);
                }
                else if (fruit == "grapes")
                {
                    result = quantity * 4.20;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    result = quantity * 2.50;
                    Console.WriteLine(result);
                }
                else if (fruit == "apple")
                {
                    result = quantity * 1.20;
                    Console.WriteLine(result);
                }
                else if (fruit == "orange")
                {
                    result = quantity * 0.85;
                    Console.WriteLine(result);
                }
                else if (fruit == "grapefruit")
                {
                    result = quantity * 1.45;
                    Console.WriteLine(result);
                }
                else if (fruit == "kiwi")
                {
                    result = quantity * 2.70;
                    Console.WriteLine(result);
                }
                else if (fruit == "pineapple")
                {
                    result = quantity * 5.50;
                    Console.WriteLine(result);
                }
                else if (fruit == "grapes")
                {
                    result = quantity * 3.85;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
                }
        }
    }

