using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която въвежда тип прожекция (стринг), брой редове и брой колони в залата 
            //(цели числа) и изчислява общите приходи от билети при пълна зала. 

            string type = Console.ReadLine();
            double row = int.Parse(Console.ReadLine());
            double col = int.Parse(Console.ReadLine());

            double places = row * col;
            double price = 0;

            double result = 0;

            switch(type)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }

            result = places * price;
            Console.WriteLine(Math.Round(result, 2));
             
        }
    }
}
