using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _22._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            

            Console.WriteLine(acc.ToString());
            
            var acounts  = new Dictionary<int, BankAccount>();

            string command;

            

            while ((command = Console.ReadLine()) != "end")
            {
                var cmdArgs = command.Split();
                var cmdType = cmdArgs[0];
                acc.ID = int.Parse(cmdArgs[1]);
                var id  = int.Parse(cmdArgs[1]);
                if (acounts.ContainsKey(14))
                    Console.WriteLine("Account already exists");
                else
                {
                    acc.ID = id;
                    acounts.Add(id, acc);
                }
                acc.Deposit(20);
                var depoait  = 
                acc.Withdraw(30);


                switch (cmdType) 
                {
                    case "Create": Create(cmdArgs, acounts); break;
                    case "Deposit": Deposit(cmdArgs, acounts); break;
                    case "Withdraw": Withdraw(cmdArgs, acounts); break;
                    case "Print": Print(cmdArgs, acounts); break;   
                }
            }
        }
    }
}
