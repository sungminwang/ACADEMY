using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage2_2_9498
{
    internal class _2_02
    {
        static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            int score = int.Parse(input);

            if (score >= 90)
            {
                Console.WriteLine('A');
            }
            else if(score >= 80)
            {
                Console.WriteLine('B');
            }
            else if(score >= 70)
            {
                Console.WriteLine('C');
            }
            else if(score >= 60)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine('F');
            }

        }
    }
}
