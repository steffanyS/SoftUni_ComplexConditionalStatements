using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            if(product=="fruit" || product=="banana" || product=="apple" || product=="cherry" || product=="kiwi" || product=="lemon" || product=="grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product=="tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
