﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage2_2_14681
{
    internal class _2_04
    {
        static void Main1(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x >0 && y > 0)
            {
                Console.WriteLine(1);
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
    }
}
