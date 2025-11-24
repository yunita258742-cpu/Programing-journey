using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik6._1_YUNITADWIPRATIWI_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat array dengan 5 elemen tipe data string
            string[] siswa = new string[5];

            // Menampilkan elemen array
            siswa[0] = "Andi";
            siswa[1] = "Budi";
            siswa[2] = "Citra";
            siswa[3] = "Dewi";
            siswa[4] = "Eka";

            // Menampilkan isi array tanpa perulangan
            Console.WriteLine("Daftar nama siswa: ");
            Console.WriteLine("Siswa ke-1: " + siswa[0]);
            Console.WriteLine("Siswa ke-2: " + siswa[1]);
            Console.WriteLine("Siswa ke-3: " + siswa[2]);
            Console.WriteLine("Siswa ke-4: " + siswa[3]);
            Console.WriteLine("Siswa ke-5: " + siswa[4]);

        }
    }
}
