using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakyik7._2_YUNITADWIPRATIWI_XPPLG1
{
    internal class Program
    {
            static void Sapanama(string nama)
            {
                Console.WriteLine("Hallo, " + nama + "!");
                Console.WriteLine("Semengat belajar C# hari ini!");
            }
            static void Main(string[] args)
            {
                Console.Write("Masukkan nama anda: ");
                string namaSiswa = Console.ReadLine();
                Sapanama(namaSiswa); // Memanggil fungsi dengan argumen
            }
    }
}
