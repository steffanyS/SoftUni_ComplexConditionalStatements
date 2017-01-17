using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            //dog -> mammal
            //crocodile, tortoise, snake->reptile
            //others->unknown

            string animal = Console.ReadLine();

            switch(animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;


            }
        }
    }
}
