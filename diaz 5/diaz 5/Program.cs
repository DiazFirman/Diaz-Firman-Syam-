//Diaz Firman Syam 2207135762

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace UTS5 //Membuat Game HANGMAN
{
    class program
    {    
        
       
           
        static void Main(string[] args)
        {
            Console.WriteLine("Ini adalah HANGMAN GAME berupa tebak kata");
            Console.WriteLine("Kamu diharuskan menebak per kata dan menggunakan huruf KAPITAL");
            Console.WriteLine("Clue nya adalah nama negara");
            Console.WriteLine("Selamat berjuang...!");
            
            
            int kesalahan = 0;
            String jawab = "";
            bool salah = false, menang = false, kalah = false, benar = false;
            Console.Clear();
            string[] hasil = new string[10];
            hasil[0] = "INDONESIA";
            hasil[1] = "TIMUR LESTE";
            hasil[2] = "MALAYSIA";
            hasil[3] = "MYANMAR";
            hasil[4] = "SINGAPURA";
            hasil[5] = "LAOS";
            hasil[6] = "THAILAND";
            hasil[7] = "BRUNEI";
            hasil[8] = "FILIPINA";
            hasil[9] = "VIETNAM";
            Random rand = new Random();
            var random = rand.Next(0, 9);
            string soalGame = hasil[random];
            char[] guess = new char[soalGame.Length];
 
            for (int p = 0; p < soalGame.Length; p++) {
                guess[p] = '_';
            }
 
            while (menang == false && kalah == false)
            {
                Console.Write("Huruf tebakan : ");
                char player = char.Parse(Console.ReadLine());
                for (int j = 0; j < soalGame.Length; j++)
                {
                    if (player == soalGame[j]) {
                        benar = true;
                        guess[j] = player;
                    } else if (j == soalGame.Length - 1 && benar == false){
                        salah = true;
                    }
                }
                Console.Clear();
                jawab = new String(guess);
                if (salah == true) {
                    Console.WriteLine("Tebakan anda salah!");
                    kesalahan++;
                    salah = false;
                }
                benar = false;
                Console.WriteLine(guess);
                Console.WriteLine();
                switch (kesalahan)
                {
                    case 1:
                        Console.WriteLine(" |");
                        Console.WriteLine(" |__");
                        break;
                    case 2:
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |___");
                        break;
                    case 3:
                        Console.WriteLine(" __ ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |___");
                        break;
                    case 4:
                        Console.WriteLine(" _________");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |___");
                        break;
                    case 5:
                        Console.WriteLine(" __________");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |___");
                        break;
                    case 6:
                        Console.WriteLine(" __________");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |       (_)");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |___");
                        break;
                    case 7:
                        Console.WriteLine(" __________");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |       (_)");
                        Console.WriteLine(" |       \\|/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |___");
                        break;
                    case 8:
                        Console.WriteLine(" __________");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |       (_)");
                        Console.WriteLine(" |       \\|/");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |___");
                        break;
                    case 9:
                        Console.WriteLine(" __________");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |       (_)");
                        Console.WriteLine(" |       \\|/");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |       / \\");
                        Console.WriteLine(" |___");
                        break;
                    case 10:
                        Console.WriteLine(" __________");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |       (_)");
                        Console.WriteLine(" |       \\|/");
                        Console.WriteLine(" |        |");
                        Console.WriteLine(" |       / \\");
                        Console.WriteLine(" |___");
                        break;

                    default:
                        break;
                }

                if (jawab == soalGame) {
                    Console.WriteLine("Anda berhasil, pemain selamat...!");
                    menang = true;
                } else if (kesalahan == 10 && jawab != soalGame) {
                    Console.WriteLine("Kamu gagal, HANGMAN...!");
                    kalah = true;
                }
            }
        }
    }
}
