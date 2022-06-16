using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage3_3_15552
{
    internal class _3_04
    {
        static void Main1(string[] args)
        {
            
            int round = int.Parse(Console.ReadLine());

            for (int i = 0; i < round; i++)
            {
                string[] input = Console.ReadLine().Split();

                int num1 = int.Parse(input[0]);
                int num2 = int.Parse(input[1]);

                Console.WriteLine(num1 + num2);

            }
        }
    }
}
