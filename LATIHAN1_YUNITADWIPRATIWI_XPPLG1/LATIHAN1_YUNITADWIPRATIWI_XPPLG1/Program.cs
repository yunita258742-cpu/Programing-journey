using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN1_YUNITADWIPRATIWI_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Menghitung Luas & Volume ===");
            Console.WriteLine("1. Luas Permukaan Kubus");
            Console.WriteLine("2. Volume Kubus");
            Console.WriteLine("3. Luas Permukaan Balok");
            Console.WriteLine("4. Volume Balok");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Write("Masukan panjang sisi kubus: ");
                    double sisi1 = double.Parse(Console.ReadLine());
                    double luaskubus = 6 * sisi1 * sisi1;
                    Console.WriteLine($"Luas Permukaan Kubus = {luaskubus}"); break;

                case 2:
                    Console.Write("Masukan panjang sisi kubus: ");
                    double sisi2 = double.Parse(Console.ReadLine());
                    double volumekubus = sisi2 * sisi2 * sisi2;
                    Console.WriteLine($"Volume kubus = {volumekubus}"); break;

                case 3:
                    Console.Write("Masukan panjang balok: ");
                    double p = double.Parse(Console.ReadLine());
                    Console.Write("Masukan lebar balok: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Masukan tinggi balok: ");
                    double t = double.Parse(Console.ReadLine());
                    double luasbalok = 2 * ((p * l) + (p * t) + (l * t));
                    Console.WriteLine($"Luas permukaan balok = {luasbalok}"); break;

                case 4:
                    Console.Write("Masukan panjang balok: ");
                    double pb = double.Parse(Console.ReadLine());
                    Console.Write("Masukan lebar balok: ");
                    double lb = double.Parse(Console.ReadLine());
                    Console.Write("Masukan tinggi balok: ");
                    double tb = double.Parse(Console.ReadLine());
                    double volumebalok = pb * lb * tb;
                    Console.WriteLine($"Volume balok = {volumebalok}"); break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia!"); break;
            }

            Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
        }
    }
}
        
    

