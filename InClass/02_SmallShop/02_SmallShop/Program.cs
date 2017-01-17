using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double result = 0;


            if(town=="Sofia")
            {
                if(product=="coffee")
                {
                    result = quantity * 0.50;
                }

                if (product == "water")
                {
                    result = quantity * 0.80;
                }

                if (product == "beer")
                {
                    result = quantity * 1.20;
                }

                if (product == "sweets")
                {
                    result = quantity * 1.45;
                }

                if (product == "peanuts")
                {
                    result = quantity * 1.60;
                }
            }

            if(town=="Plovdiv")
            {
                if (product == "coffee")
                {
                    result = quantity * 0.40;
                }

                if (product == "water")
                {
                    result = quantity * 0.70;
                }

                if (product == "beer")
                {
                    result = quantity * 1.15;
                }

                if (product == "sweets")
                {
                    result = quantity * 1.30;
                }

                if (product == "peanuts")
                {
                    result = quantity * 1.50;
                }
            }

            if(town=="Varna")
            {
                if (product == "coffee")
                {
                    result = quantity * 0.45;
                }

                if (product == "water")
                {
                    result = quantity * 0.70;
                }

                if (product == "beer")
                {
                    result = quantity * 1.10;
                }

                if (product == "sweets")
                {
                    result = quantity * 1.35;
                }

                if (product == "peanuts")
                {
                    result = quantity * 1.55;
                }
            }

            Console.WriteLine(result);
        }
    }
}
