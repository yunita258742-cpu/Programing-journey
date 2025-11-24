using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyekakhirsemester_yunitadwipratiwi_xpplg1
{
    internal class Program
        {
            // Fungsi untuk menyimpan data siswa
            class Program
            { 
            //Class untuk menyimpan data siswa
            class siswa
            {
                public string Nama { get; set; }
                public double nilai { get; set; }
            }

        

            static void Main(string[] args)
            {
                List<Siswa> daftarSiswa = new List<Siswa>();
                int pilihan;

               
                {
                    Console.Clear();
                    Console.WriteLine("=======================================");
                    Console.WriteLine("     APLIKASI DATA NILAI SISWA");
                    Console.WriteLine("=======================================");
                    Console.WriteLine("1. Tambah Data Siswa");
                    Console.WriteLine("2. Tampilkan Data Siswa");
                    Console.WriteLine("3. Hitung Statistik Nilai");
                    Console.WriteLine("4. Keluar");
                    Console.WriteLine("=======================================");
                    Console.Write("Pilih menu (1-4): ");

                    if (!int.TryParse(Console.ReadLine(), out pilihan))
                    {
                        pilihan = 0;
                    }

                    switch (pilihan)
                    {
                        case 1:
                            TambahData(daftarSiswa);
                            break;
                        case 2:
                            TampilkanData(daftarSiswa);
                            break;
                        case 3:
                            HitungStatistik(daftarSiswa);
                            break;
                        case 4:
                            Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                            break;
                        default:
                            Console.WriteLine("\nPilihan tidak valid! Silakan coba lagi.");
                            break;
                    }

                    if (pilihan != 4)
                    {
                        Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
                        Console.ReadLine();
                    }

                } while (pilihan != 4);
            }

            // Fungsi untuk menambah data siswa
            static void TambahData(List<Siswa> daftar)
            {
                Console.Clear();
                Console.WriteLine("=== Tambah Data Siswa ===");
                Console.Write("Masukkan Nama Siswa : ");
                string nama = Console.ReadLine();

                double nilai;
                Console.Write("Masukkan Nilai Siswa (0-100): ");
                while (!double.TryParse(Console.ReadLine(), out nilai) || nilai < 0 || nilai > 100)
                {
                    Console.Write("Nilai tidak valid! Masukkan nilai antara 0 - 100: ");
                }

                daftar.Add(new Siswa { Nama = nama, Nilai = nilai });
                Console.WriteLine("\nData siswa berhasil ditambahkan!");
            }

            // Fungsi untuk menampilkan semua data siswa
            static void TampilkanData(List<Siswa> daftar)
            {
                Console.Clear();
                Console.WriteLine("=== Daftar Nilai Siswa ===");

                if (daftar.Count == 0)
                {
                    Console.WriteLine("Belum ada data siswa yang dimasukkan.");
                    return;
                }

                int no = 1;
                foreach (var s in daftar)
                {
                    Console.WriteLine($"{no}. Nama: {s.Nama,-15} | Nilai: {s.Nilai}");
                    no++;
                }
            }

            // Fungsi untuk menghitung statistik nilai
            static void HitungStatistik(List <Siswa> daftar)
            {
                Console.Clear();
                Console.WriteLine("=== Statistik Nilai Siswa ===");

                if (daftar.Count == 0)
                {
                    Console.WriteLine("Belum ada data untuk dihitung.");
                    return;
                }

                double rata2 = daftar.Average(s => s.Nilai);
                double tertinggi = daftar.Max(s => s.Nilai);
                double terendah = daftar.Min(s => s.Nilai);

                Console.WriteLine($"Rata-rata Nilai : {rata2:F2}");
                Console.WriteLine($"Nilai Tertinggi : {tertinggi}");
                Console.WriteLine($"Nilai Terendah  : {terendah}");
            }
        }
    }

    

