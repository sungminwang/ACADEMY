﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 증가, 감소 연산자 연습문제
 */
namespace Test
{
    internal class _1_04
    {
        static void Main4(string[] args)
        {
			int num = 1;
			int result;

			result = num++;
			Console.WriteLine("result : " + result);

			result = ++num;
			Console.WriteLine("result : " + result);

			result = num--;
			Console.WriteLine("result : " + result);

			result = --num;
			Console.WriteLine("result : " + result);
		}
    }
}
