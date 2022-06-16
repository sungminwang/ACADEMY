using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage1_13_2588
{
    internal class _1_13
    {
        static void Main1(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());

            int input2 = int.Parse(Console.ReadLine());


            Console.WriteLine(input1*(input2%10));
            Console.WriteLine(input1*((input2/10)%10));
            Console.WriteLine(input1*(input2/100));
            Console.WriteLine(input1*input2);

        }

    }
}
