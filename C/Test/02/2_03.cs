﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 배열 연습문제
 */
namespace Test
{
    internal class _2_03
    {
        static void Main3(string[] args)
        {
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// 현재 배열 출력
			for (int i = 0; i < 10; i++)
			{
                Console.Write(arr[i] + ", ");
			}
			Console.Write("\n");

			// 배열의 원소를 역순으로 정렬
			for (int j = 0; j < 5; j++)
			{
				int temp = arr[j];
				arr[j] = arr[9 - j];
				arr[9 - j] = temp;
			}

			// 역순으로 정렬된 배열 출력
			foreach(int n in arr)
			{
				Console.Write(n + ", ");
			}
		}
    }
}

