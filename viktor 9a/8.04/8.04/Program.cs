using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kak ti e imeto:");
            string str = " Hello, viktor v C#";
            string name  = Console.ReadLine();
            Console.WriteLine("Hi, " + name);
            Console.Write("kak ti e familiqta:");
            string last_name = Console.ReadLine();
            Console.WriteLine("hi,{0}",name + " " + last_name);
            Console.Write("kak ti e familiqta:");
            string famili_name = Console.ReadLine();    
            Console.WriteLine($"hi,{name} {last_name} {famili_name}!");
            string str1 = name;
            string str2 = last_name;
            string str3 = famili_name;
            int result = string.Compare(str1, str2, true);
            Console.WriteLine(result);

            string str4 = string.Concat(name, famili_name);
            Console.WriteLine(str4);
            int firstindex = str.IndexOf(",");
            Console.WriteLine(firstindex);
            int lastindex = str.LastIndexOf("v", 1);
            Console.WriteLine(lastindex);

            string name1 = str.Substring(8, 6);
            Console.WriteLine(name1);
            string name2 = str.Substring(1, 5);
            Console.WriteLine(name2);
            string name3 = str.Replace("C#", "si otiva");
            Console.WriteLine(name3);
        }
    }
}
