using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // [100…200] или е 0. 

            int num = int.Parse(Console.ReadLine());
            if(num<100 || num>200)
            {
                    if (num != 0)
                    {
                        Console.WriteLine("invalid");
                    }
            }
        }
    }
}
