//Diaz Firman Syam 22007135762

using System;
using System.Text.RegularExpressions;

namespace UTS4 //Enskripsi huruf atau mengubah huruf
{
    class program
    {
        public static void Main(string[] args) {
            String kata, enkripsi = "";
            String hurufalfabet = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            Regex rx = new Regex("[^a-z,A-Z ]");
            do
            {
                Console.Write("KATA : ");
                kata = Console.ReadLine();
            } while (String.IsNullOrEmpty(kata) || rx.IsMatch(kata));

            foreach (Char t in kata)
            {
                Char enk = ' ';
                for (int i = 0; i < hurufalfabet.Length; i++)
                {
                    Char c = hurufalfabet[i];
                    if (t.Equals(c)) {
                        enk = hurufalfabet[i+3];
                        break;
                    } else if (t.Equals(' ')) {
                        enk = ' '; 
                        break;
                    }
                }
                enkripsi = enkripsi + enk;
            }
            Console.WriteLine("Hasil Enkripsi : " + enkripsi); 
        }
    }
}
