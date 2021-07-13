using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        static void main(string[] args)
        {
            // deklarasi objek collection untuk menampung objek mahasiswa
            List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
            daftarMahasiswa.Add(new Mahasiswa() { NIM = "001", Nama = "Anis", Jeniskelamin = "Laki-laki"});
            daftarMahasiswa.Add(new Mahasiswa() { NIM = "002", Nama = "Septi", Jeniskelamin = "Perempuan" });
            daftarMahasiswa.Add(new Mahasiswa() { NIM = "003", Nama = "Abdul", Jeniskelamin = "Laki-laki" });
            daftarMahasiswa.Add(new Mahasiswa() { NIM = "004", Nama = "Risa", Jeniskelamin = "Perempuan" });

            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine(mahasiswa);
            }
            static void Main(string[] args)
            {
                Console.Title = "Responsi UAS Matakuliah Pemrograman";

                while (true)
                {
                    TampilMenu();

                    Console.Write("\nNomor Menu [1..4]: ");
                    int nomorMenu = Convert.ToInt32(Console.ReadLine());

                    switch (nomorMenu)
                    {
                        case 1:
                            TambahMahasiswa();
                            break;

                        case 2:
                            HapusMahasiswa();
                            break;

                        case 3:
                            TampilMahasiswa();
                            break;

                        case 4:
                             Keluar();
                            return;

                        default:
                            break;
                    }
                }
            }

            static void TampilMenu()
            {
                Console.Clear();

                // PERINTAH: lengkapi kode untuk menampilkan menu
                Console.WriteLine("1. Tambah Mahasiswa");
                Console.WriteLine("2. Hapus Mahasiswa");
                Console.WriteLine("3. Tampilkan Mahasiswa");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("");
                Console.WriteLine("Nomor Menu [1..4]: 1");
            }

            static void TambahMahasiswa()
            {
                Console.Clear();

                // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
                Console.WriteLine("Tambah Data Mahasiswa");
                Console.WriteLine("");
                Console.WriteLine("NIM: 001");
                Console.WriteLine("Nama: Anis");
                Console.WriteLine("Jenis Kelamin[L/P]: L");
                Console.WriteLine("IPK: 3.73");


                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }

            static void HapusMahasiswa()
            {
                Console.Clear();

                // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }

            static void TampilMahasiswa()
            {
                Console.Clear();

                // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

                Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
            }
        }
    }
}
