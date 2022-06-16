using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage3_3_10950
{
    internal class _3_02
    {
        static void Main1(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();
                int num1 = int.Parse(s[0]);
                int num2 = int.Parse(s[1]);

                Console.WriteLine(num1+num2);
            }
        }
    }
}
