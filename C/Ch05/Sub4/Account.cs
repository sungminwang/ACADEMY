﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Account
    {
        // 속성 - private 캡슐화 적용
        protected string bank;
        protected string id;
        protected string name;
        protected int balance;

        // 생성자 - 캡슐화된 속성을 초기화 하기 위한 메서드
        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        // 기능
        public void Deposit(int money) 
        {
            this.balance += money;
        }

        public void Withdraw(int money) 
        {
            this.balance -= money;
        }

        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("은행명 : "+bank);
            Console.WriteLine("계좌번호 : "+id);
            Console.WriteLine("입금주 : "+name);
            Console.WriteLine("현재잔액 : "+balance);            
        }
    }
}
