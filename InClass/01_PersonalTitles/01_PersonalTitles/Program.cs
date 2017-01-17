using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if(years>=16)
            {
                if(gender=="m")
                {
                    Console.WriteLine("Mr.");
                }
                else if(gender=="f")
                {
                    Console.WriteLine("Ms.");
                }
            }

            if (years < 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }


        }
    }
}
