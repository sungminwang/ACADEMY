using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage1_9_10869
{
    internal class _1_09
    {
        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) - int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) * int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) / int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) % int.Parse(input[1]));

        }
    }
}
