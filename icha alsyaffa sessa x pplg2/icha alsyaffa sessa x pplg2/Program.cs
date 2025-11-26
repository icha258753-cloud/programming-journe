using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Program
{
    // Data kereta menggunakan array
    static string[] kodeKereta = { "SEN", "MAL", "KUT" };
    static string[] namaKereta = { "SENJA", "MALAM", "KUTARA" };
    static int[] hargaKereta = { 150000, 200000, 250000 };
    static string[] jamKereta = { "20.00", "18.30", "07.15" };

    // Method hitung total
    static int HitungTotal(int harga, int jumlah)
    {
        return harga * jumlah;
    }
    static void Main(string[] args)
    {
        // Method menampilkan laporan
        void TampilLaporan(string kode, string jenis, int harga, string jam, int jumlah, int total)
        {
            Console.WriteLine("\n===== LAPORAN PENJUALAN TIKET =====");
            Console.WriteLine($"Kode Tiket           : {kode}");
            Console.WriteLine($"Jenis Kereta         : {jenis}");
            Console.WriteLine($"Harga Tiket          : {harga}");
            Console.WriteLine($"Jam Keberangkatan    : {jam}");
            Console.WriteLine($"Jumlah Pembelian     : {jumlah}");
            Console.WriteLine($"Total Harga          : {total}");
            Console.WriteLine("====================================\n");
        }


        {
            string ulang = "y";

            while (ulang == "y" || ulang == "Y")
            {
                Console.Clear();
                Console.WriteLine("============================================");
                Console.WriteLine("      PENJUALAN TIKET KERETA API");
                Console.WriteLine("  Oleh: Icha Alsyaffa Sessa");
                Console.WriteLine("============================================\n");

                // Input kode tiket
                Console.Write("Masukkan Kode Tiket (SEN/MAL/KUT) : ");
                string kodeInput = Console.ReadLine().ToUpper();

                int index = -1;

                // Cari kereta sesuai kode
                for (int i = 0; i < kodeKereta.Length; i++)
                {
                    if (kodeInput.Contains(kodeKereta[i]))
                    {
                        index = i;
                        break;
                    }
                }

                // Jika kode tidak ditemukan
                if (index == -1)
                {
                    Console.WriteLine("\nKode tiket tidak ditemukan!");
                    Console.Write("Ulangi program? (y/n): ");
                    ulang = Console.ReadLine();
                    continue;
                }

                int harga = hargaKereta[index];
                string jenis = namaKereta[index];
                string jam = jamKereta[index];

                // Input jumlah pembelian
                Console.Write("Masukkan Jumlah Tiket : ");
                int jumlahTiket = int.Parse(Console.ReadLine());

                // Hitung total
                int totalBayar = HitungTotal(harga, jumlahTiket);

                // Tampilkan laporan
                TampilLaporan(kodeInput, jenis, harga, jam, jumlahTiket, totalBayar);

                Console.Write("Proses lagi? (y/n): ");
                ulang = Console.ReadLine();
            }

            Console.WriteLine("\nTerima kasih telah menggunakan aplikasi!");
        }
    }
}