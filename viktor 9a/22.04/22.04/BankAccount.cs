using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04
{
    internal class BankAccount
    {
        private int Id;
        private double balance;

        public int ID
        {
            get { return this.Id; } 
            set { this.Id = value; } 
        }   
        public double Balance 
        { 
            get { return this.balance;}
            set { this.balance = value;} 
        }

        public void Deposit (double amount)
        {
            this.balance += amount;
        }
        public void Withdraw (double amount)
        {
            this.balance -= amount;
        }
        public override string ToString()
        {
            return $"Acount {this.Id}, balance {this.balance}";
        }

    }
}
