using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4
{
    internal class grupa
    {
        private string name;
        private string adres;
        private double ocenka;

        public  String Name
        {
        get { return name; }
        set { name = value; }
        }
        public string Adres
        { 
        get { return adres; } 
        set {  adres = value; } 
        }
        public double Ocenka
        { 
        get { return ocenka; }
        set { ocenka = value; }
        }
        public void Izhod()
        {
            Console.WriteLine($"Kazvam se {Name}, jiveq na {Adres} i imam ocenka {Ocenka}");
            Console.WriteLine("Kazvam se " + name + ", jiveq na " + adres + " i imam ocenka " + ocenka);
            Console.WriteLine("Kazvam se {0}, jiveq na {1} i imam ocenka {2}",name,adres,ocenka);
        }
        public void Hristo()
        {
            Console.Write("Dai ime: ");
            this.name = Console.ReadLine();
            Console.Write("Dai adres: ");
            this.adres = Console.ReadLine();
            Console.Write("Dai ocrebnka: ");
            this.ocenka = double.Parse(Console.ReadLine());
        }
    }
}
