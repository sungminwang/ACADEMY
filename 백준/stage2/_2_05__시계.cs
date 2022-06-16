using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage2_2_2884  //출력은 맞는데 백준에서는 틀린걸로 나옴
{
    internal class _2_05
    {
        static void Main1(string[] args)
        {
            string[] inputtime = Console.ReadLine().Split(" ");

            int inputH = int.Parse(inputtime[0]);
            int inputM = int.Parse(inputtime[1]);

            if (inputM >= 45 && inputH >= 0)
            {                
                Console.WriteLine(inputH +(" ")+ (inputM-45));
            }

            if (inputM < 45)
            {
                inputH=inputH-1;

                if (inputH > 0)
                {
                    Console.WriteLine((inputH) + (" ") + (60 + (inputM - 45)));
                }

                if (inputH < 0)
                {
                    inputH = inputH + 24;

                    Console.WriteLine((inputH) + (" ") + (60 + (inputM - 45)));                 
                }

            }
            
        }
    }
}