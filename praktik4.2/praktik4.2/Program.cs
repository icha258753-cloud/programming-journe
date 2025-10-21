using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Memeriksa apakah sebuah bilangan positif
            Console.WriteLine("Masukan suhunya  : ");
            double suhu = double.Parse(Console.ReadLine());
            if (suhu > 0)
            Console.WriteLine("Suhu diatas titik beku (positif).");
        }
    }
}
