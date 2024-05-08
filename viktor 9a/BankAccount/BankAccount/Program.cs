using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            Person person = new Person();
            
            acc.ID = 1;
            Console.Write("kolko che vkarvah: ");
            acc.Deposit(0);
            Console.Write("kolko che izvahdash: ");
            acc.Withdraw(0);
            Console.WriteLine(acc.ToString());

            person.intr();
            
        }
    }
}
