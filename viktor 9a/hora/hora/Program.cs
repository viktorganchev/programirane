using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("kolko puti che vuvehdash:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.Write("Name:");
                person.Name = Console.ReadLine();
                Console.Write("Age:");
                person.Age = int.Parse(Console.ReadLine());
                Console.Write("Grad:");
                person.Grad = Console.ReadLine();
                Console.WriteLine($"Name{person.Name}, age {person.Age}, Grad{person.Grad}");
            }

            if (person.Grad == "Sopot")
            {
                Console.WriteLine($"Name{person.Name}, age {person.Age}, Grad{person.Grad}");
            }
            else
            {
                Console.WriteLine("nqma sopotnenec");
            }
            
        }
    }
}
