/*
Created by Diaz Firman Syam - 2207135762
*/

using System;

namespace daspro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            const int a = 5;
            const int b = 4;
            const int c = 7;

            const int tambah = a+b+c;
            const int kali = a*b*c;
            const int kurang = a-b-c;
            const int bagi = a/b/c;

            //Menuliskan Narasi 
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya "+tambah);
            Console.WriteLine("- Jika dikalikan hasilnya "+kali);
            Console.WriteLine("- Jika dikurangkan hasilnya "+kurang);
            Console.WriteLine("- Jika dibagikan hasilnya "+bagi);
            Console.Write("Enter code : ");        
        }
    }
}
