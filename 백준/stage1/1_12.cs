using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage1_12_10430
{
    internal class _1_12
    {
        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            Console.WriteLine((A+B)%C);
            Console.WriteLine(((A%C)+(B%C))%C);
            Console.WriteLine((A*B)%C);
            Console.WriteLine(((A%C)*(B%C))%C);

        }

    }
}
