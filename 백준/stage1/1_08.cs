using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage1_8_1008
{
    internal class _1_08
    {
        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(double.Parse(input[0]) / double.Parse(input[1]));
        }
    }
}
