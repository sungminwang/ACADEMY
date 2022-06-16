using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage3_3_8393
{
    internal class _3_03
    {
        static void Main1(string[] args)
        {            
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                sum += i;        
            }

            Console.WriteLine(sum);
        }
    }
}
