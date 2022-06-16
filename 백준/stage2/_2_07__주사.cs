using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage2_2_2480
{
    internal class _2_07_2480
    {
        static void Main1(string[] args)
        {
            string[] number = Console.ReadLine().Split();

            int a = int.Parse(number[0]);
            int b = int.Parse(number[1]);
            int c = int.Parse(number[2]);

            Console.Clear();

            if (a == b)
            {
                if(a == c)
                {
                    Console.WriteLine(10000 + a * 1000);
                }
                else if(a != c)
                {
                    Console.WriteLine(1000+a*100);
                }            
            }
            
            else if(a != b && b != c)
            {
                if (a > b && a > c)
                {
                    Console.WriteLine(a * 100);
                }
                else if(b > a && b > c)
                {
                    Console.WriteLine(b * 100);
                }
                else if (c > a && c > b)
                {
                    Console.WriteLine(c * 100);
                }

            }
        }
    }
}
