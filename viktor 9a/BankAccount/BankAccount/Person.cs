using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Person
    {
        public string[] name;
        public int[] age;

        public string[] Name
        {
            get { return name; }
            set { name = value; }
        }

        public int[] Age
        {
            get { return age; }
            set { age = value; }
        }
       
        public void intr()
        {
            Console.Write("kolko puti che vuvehdash:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Age:");
                int[] Age = new int[n];
                Console.Write("Name:");
                string[] Name = new string[n];
            }

            for (int i = 0; i < n;i++)
            {
                Console.WriteLine($"Name{Name[i]}");
                Console.WriteLine($"Age {Age[i]}");
            }
        }
        
        
             
        
       
    }
}
