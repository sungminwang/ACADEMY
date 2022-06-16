using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage2_2_2753
{
    internal class _2_03
    {
        static void Main1(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(1);               
            }
            else if(year % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
