using System;
using System.Collections.Generic;
using System.Text;

namespace BangunRuang
{
    class Menu
    {
        public int pilih;
        public void menu()
        {
            Console.WriteLine("Program Menghitung Luas Bangun Ruang");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Segipanjang");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Segiempat");
            Console.Write("Masukkan Pilihan : ");
            pilih = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (pilih)
            {
                case 1:
                    {
                        Segipanjang a = new Segipanjang();

                        Console.WriteLine("Menghitung Luas Segipanjang");
                        Console.Write("Panjang : ");
                        a.panjang = (int.Parse(Console.ReadLine()));
                        Console.Write("Lebar   : ");
                        a.lebar = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas    = {0} cm", a.luas_segipanjang());
                        ulang();
                        break;
                    }
                case 2:
                    {
                        Segitiga b = new Segitiga();

                        Console.WriteLine("Menghitung Luas Segitiga");
                        Console.WriteLine("------------------------");
                        Console.Write("Alas   : ");
                        b.alas = (int.Parse(Console.ReadLine()));
                        Console.Write("Tinggi : ");
                        b.tinggi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas   = {0} cm", b.luas_segitiga());
                        ulang();
                        break;
                    }
                case 3:
                    {
                        Segiempat c = new Segiempat();

                        Console.WriteLine("Menghitung Luas Segiempat");
                        Console.WriteLine("-------------------------");
                        Console.Write("Sisi : ");
                        c.sisi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas = {0} cm", c.luas_segiempat());
                        ulang();
                        break;
                    }
                default:
                    {
                        menu();
                        break;
                    }
            }
        }

        public void ulang()
        {
            Console.Write("Apakah Anda Ingin Menghitung Lagi? (Y/N)");
            string Pilihan = Console.ReadLine();
            if (Pilihan == "Y" || Pilihan == "y")
            {
                menu();
            }
            else if (Pilihan == "N" || Pilihan == "n")
            {
                Console.WriteLine("Matur Nuwun Dab");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}