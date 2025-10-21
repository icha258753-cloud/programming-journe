using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi varibel untuk menyimpan input
            string inputUser = "";

            Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar' .");

            // Perulangan selama isi variabel inputUser  TIDAK SAMA DDENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.WriteLine("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine(); // Baca  input dari user

                Console.WriteLine("Anda memgetik: " + inputUser);
            }
            Console.WriteLine("\nProgram selesai. Terima kasih!");
        }
    }
}
