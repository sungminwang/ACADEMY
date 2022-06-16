﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/14
 * 이름 : 김철학
 * 내용 : 자주 사용하는 내장 클래스 실습하기
 */
namespace Ch06
{
    internal class _6_InternalClass
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////
            // Math 클래스 교재 p215
            ///////////////////////////////////////////
            //Math math = new Math();
            Console.WriteLine("PI : "+Math.PI);
            Console.WriteLine("9  제곱근 : "+Math.Sqrt(9));
            Console.WriteLine("16 제곱근 : "+Math.Sqrt(16));
            Console.WriteLine("절대값 : "+Math.Abs(-5));
            Console.WriteLine("올림값 : "+Math.Ceiling(1.2));
            Console.WriteLine("올림값 : "+Math.Ceiling(1.8));
            Console.WriteLine("내림값 : "+Math.Floor(1.2));
            Console.WriteLine("내림값 : "+Math.Floor(1.8));
            Console.WriteLine("반올림 : "+Math.Round(1.2));
            Console.WriteLine("반올림 : "+Math.Round(1.8));
            Console.WriteLine();

            ///////////////////////////////////////////
            // Random 클래스 교재 p207
            ///////////////////////////////////////////
            Random random = new Random();

            int rand1 = random.Next();
            Console.WriteLine("rand1 : "+ rand1);

            int rand2 = random.Next(10);
            Console.WriteLine("rand2 : " + rand2); // 0 ~ 9 사이의 임의의 정수

            int rand3 = random.Next(1, 11);
            Console.WriteLine("rand3 : " + rand3); // 1 ~ 10 사이의 임의의 정수

            double num1 = random.NextDouble();
            Console.WriteLine("num1 : "+num1); // 0 ~ 1 사이의 임의의 실수

            double num2 = num1 * 10;
            Console.WriteLine("num2 : " + num2); // 0 ~ 10 사이의 임의의 실수

            double num3 = Math.Ceiling(num2);
            Console.WriteLine("num3 : " + num3); // 1 ~ 10 사이의 임의의 정수
            Console.WriteLine();

            ///////////////////////////////////////////
            // DateTime 클래스            
            ///////////////////////////////////////////
            // 싱글톤 객체
            DateTime now = DateTime.Now;

            Console.WriteLine("now : "+now);

            // 개별 시간 데이터 출력
            Console.WriteLine("년 : "+now.Year);
            Console.WriteLine("월 : "+now.Month);
            Console.WriteLine("일 : "+now.Day);
            Console.WriteLine("시 : "+now.Hour);
            Console.WriteLine("분 : "+now.Minute);
            Console.WriteLine("초 : "+now.Second);

            // 문자열 Format
            string result1 = now.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 : "+result1);

            string result2 = now.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("result2 : " + result2);
        }
    }
}
