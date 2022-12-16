//Diaz Firman Syam 2207135762
using System;

namespace UTS3 //Tiket Bioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string hargatiket;
            Console.WriteLine("Nama : ");
            string Nama = Console.ReadLine();
            Console.WriteLine("Tahun Kelahiran : ");
            int tahunlahir = Convert.ToInt32(Console.ReadLine());

            int Usia = 2022 - tahunlahir;

            if(Usia < 10 || Usia > 60)
            {
                hargatiket = " Rp. 10.000";    
            }
            else
            {
                hargatiket = " Rp. 25.000";
            }
            Console.WriteLine("|*******************************|");
            Console.WriteLine("|             STUDIO 1          |");
            Console.WriteLine(string.Format("|{0,-16}        {1,-7}|",  "Nama  : ",   Nama ));
            Console.WriteLine(string.Format("|{0,-16}    {1,-11}|", "harga : ", hargatiket ));
            Console.WriteLine("|*******************************|");
        }
    }
}
