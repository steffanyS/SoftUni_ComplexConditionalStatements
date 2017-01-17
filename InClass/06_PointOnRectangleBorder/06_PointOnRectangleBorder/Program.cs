using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1 < y2).
            //Да се отпечата “Border” (точката лежи на някоя от страните) или “Inside / Outside”
            //x съвпада с x1 или x2 и същевременно y е между y1 и y2
            //y съвпада с y1 или y2 и същевременно x е между x1 и x2

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if((x == x1 || x == x2) && y >= y1 && y <= y2)
            {
                Console.WriteLine("Border");
            }
            else if ((y == y1 || y == y2) && x >= x1 && x <= x2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
