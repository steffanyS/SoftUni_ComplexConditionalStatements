using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double S = double.Parse(Console.ReadLine());
            double result = 0;
            double percent = 0;

            if (town == "Sofia")
            {
                if (S > 0)
                {
                    if (S <= 500)
                    {
                        percent = 0.05;
                    }
                    else if (S > 500 && S <= 1000)
                    {
                        percent = 0.07;
                    }
                    else if (S > 1000 && S <= 10000)
                    {
                        percent = 0.08;
                    }
                    else if (S > 10000)
                    {
                        percent = 0.12;
                    }

                    result = S * percent;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
                
            else if(town=="Varna")
            {
                if (S > 0)
                {
                    if (S <= 500)
                    {
                        percent = 0.045;
                    }
                    else if (S > 500 && S <= 1000)
                    {
                        percent = 0.075;
                    }
                    else if (S > 1000 && S <= 10000)
                    {
                        percent = 0.1;
                    }
                    else if (S > 10000)
                    {
                        percent = 0.13;
                    }

                    result = S * percent;
                    Console.WriteLine(Math.Round(result,2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(town=="Plovdiv")
            {
                if (S > 0)
                {
                    if (S <= 500)
                    {
                        percent = 0.055;
                    }
                    else if (S > 500 && S <= 1000)
                    {
                        percent = 0.08;
                    }
                    else if (S > 1000 && S <= 10000)
                    {
                        percent = 0.12;
                    }
                    else if (S > 10000)
                    {
                        percent = 0.145;
                    }

                    result = S * percent;
                    Console.WriteLine(Math.Round(result, 2));
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
