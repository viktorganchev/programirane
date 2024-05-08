using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    internal class danni
    {
        private string name;
        
        private int broika;
       
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Broika
        {
            get { return broika; }
            set 
            { 
               broika = value;
            }
        }
        
        public void izhod1()
        {
            Console.WriteLine("ti denes si ql puti " + broika + " " + name);
        }
        public void izhod2() 
        {
        Console.WriteLine(" " + broika);
        }

    }
}
