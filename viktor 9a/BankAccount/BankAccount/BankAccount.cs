using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private int Id;
        private double balance;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit (double amount)
        {
            this.balance += double.Parse(Console.ReadLine());
        }

        public void Withdraw (double amount)
        {
            this.balance -= double.Parse(Console.ReadLine()); ;
        }
        public override string ToString()
        {
            return $"Acount {this.Id} , balance {this.balance}";
        }

        //public void balans()
        //{
        //    if (Withdraw > Deposit)
        //    {
        //        Console.WriteLine($"Balance ne ti dostigat{this.Balance}");
        //    }
        //}


    }
}
