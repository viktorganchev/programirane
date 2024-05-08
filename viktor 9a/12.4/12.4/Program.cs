using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            grupa d = new grupa();
            d.Name = "Viktor";
            d.Adres = "geyiufy";
            d.Ocenka = 6;
            d.Izhod();
            grupa c  = new grupa();
            c.Hristo();
            c.Izhod();
        }
    }
}
