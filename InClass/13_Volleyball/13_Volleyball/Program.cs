using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = int.Parse(Console.ReadLine());
            double weekends = int.Parse(Console.ReadLine());

            double saturdayGames = (48 - weekends)*3/4;
            double holidaySofiaGames = holidays * 2 / 3;

            double leapYear = 0;
            double totalGames = saturdayGames + holidaySofiaGames + weekends;

            if (yearType=="leap")
            {
                leapYear=totalGames*0.15;
                totalGames += leapYear;
            }
            else if(yearType=="normal")
            {
                leapYear = 0;
            }

            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
