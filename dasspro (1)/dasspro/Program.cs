/*
Create by Diaz Firman Syam - 2207135762
*/
using System;

namespace daspro {
    class Program {
        static Random random = new Random();

        // deklarasi variabel
        static int kodeA;
        static int kodeB;
        static int kodeC;
        static int hasilTambah;
        static int hasilkurang;
        static int hasilKali;
        static int kesempatan = 3;
        static int level = 1;

        static string tebakanA;
        static string tebakanB;
        static string tebakanC;
        static bool bGameOver = true;

        static bool cancel = false;
        static int jumlahKode = 3;

        //Main Method
        static void Main(string[] args) {
            intro();

            while (bGameOver) {
                PlayGame();
                
                if(cancel == true){
                    break;
                }
            }
        }

        static void intro(){
            // intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui..");
        }

        static void PlayGame() {

            kodeA = random.Next(1, level);
            kodeB = random.Next(1, level);
            kodeC = random.Next(1, level);

            hasilTambah = kodeA + kodeB + kodeC;
            hasilkurang = kodeA - kodeB - kodeC;
            hasilKali = kodeA * kodeB * kodeC;

            Console.WriteLine("- level " + level);
            Console.WriteLine("- Password terdiri dari " + jumlahKode + " angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("- Jika dikurangkan hasilnya " + hasilkurang);
            Console.WriteLine("- Jika dikalikan hasilnya " + hasilKali);

            //input user
            Console.WriteLine("Masukkan Kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.WriteLine("Masukkan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.WriteLine("Masukkan Kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda " + tebakanA + " " + tebakanB + " " + tebakanC + "?");

            if (tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()) {
                Console.WriteLine("Anda benar!");

                // tambah level
                level = level + 1;

                if(level > 5){
                    Console.WriteLine("Mantap");
                    cancel = true;
                }

            } else {
                Console.WriteLine("Anda salah!");

                // kurang kesempatan
                 kesempatan = kesempatan - 1;
                 Console.WriteLine("salahh");

                if(kesempatan < 1){
                    Console.WriteLine("Game Over");
                    cancel = true;
                }
            }
        }
    }
}