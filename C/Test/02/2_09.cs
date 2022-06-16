﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 팩토리얼 연습문제
 */
namespace Test
{
    internal class _2_09
    {
		static void Main9(string[] args)
		{
			Console.WriteLine("3! = " + factorial(3));
			Console.WriteLine("4! = " + factorial(4));
			Console.WriteLine("5! = " + factorial(5));
		}

		public static int factorial(int n)
		{
			if (n <= 1)
			{
				return 1;
			}

			return n * factorial(n - 1);
		}
	}
}

