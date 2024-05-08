using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
        danni a  = new danni();
            Console.Write("kakvo qde dnes:");
            a.Name = Console.ReadLine();
            Console.Write("kolko puti:");
            a.Broika = int.Parse(Console.ReadLine());
            Console.Write("pil li si necho dnes ");
           
            a.izhod1();
            if (a.Broika > 5) 
            {
                Console.WriteLine(a.Broika * 2);
            }
            else
            {
                Console.WriteLine("ql si s natrupvane ");
            }

            pitieta c  = new pitieta();
            Console.Write("che piesh li oche ");
            c.Piene = Console.ReadLine();
            string[] drik = {" ","martini" , "vodka" , "voda" , "whiski" };
            
            if (c.Piene == "da")
            {
                Console.Write("Kakvo si ili izberi cifra ot 1 do 4 ");
                c.Pitie = int.Parse(Console.ReadLine());
                switch (c.Pitie)
                {
                    case 1: Console.WriteLine(" martini"); break;
                    case 2: Console.WriteLine("vodka"); break ;
                    case 3: Console.WriteLine("voda"); break;
                    case 4: Console.WriteLine("whiski"); break;
                }
                
            }
            else
            {
                Console.WriteLine("lek den");
            }
            Console.Write("che piesh li oche ");
            c.Piene = Console.ReadLine();

            if (c.Piene == "da")
            {
                Console.Write("Kakvo si ili izberi cifra ot 1 do 4 ");
                c.Pitie = int.Parse(Console.ReadLine());
                if (c.Pitie == 1)
                {
                    Console.WriteLine("Ti si pil " + drik[1]);
                }
                else
                    if (c.Pitie == 2)
                {
                    Console.WriteLine("Ti si pil " + drik[2]);
                }
                else
                if (c.Pitie == 3)
                {
                    Console.WriteLine("Ti si pil " + drik[3]);
                }
                else
                if (c.Pitie == 4)
                {
                    Console.WriteLine("Ti si pil " + drik[4]);
                }
            }
        }
    }
}
