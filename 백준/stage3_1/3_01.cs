using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage3_3_2739
{
    internal class _3_01
    {

        static void Main1(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(number+" * "+i+" = "+(number*i));
            }
            return;
        }       
    }
}
