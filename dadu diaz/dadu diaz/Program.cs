using System;

namespace dadu_diaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
                int computernum;
                int playerpoint = 0;
                int compoint = 0;
            
                Random random = new Random();

                for (int i = 0; i < 10; i++)
                {
                Console.WriteLine("Tekan apa saja untuk melempar dadu.");
                Console.ReadKey();

                playerRandomNum = random.Next(1,7);
                Console.WriteLine("jumlah dadu anda :" +playerRandomNum);

                computernum = random.Next(1,7);
                Console.WriteLine("jumlah dadu komputer :" +computernum);

                if(playerRandomNum > computernum)
                {
                playerpoint++;
                Console.WriteLine("Anda menang pada ronde ini");
                }
                else if(playerRandomNum < computernum)
                {
                compoint++;
                Console.WriteLine("Anda kalah pada ronde ini") ;  
                }
                else
                {
                Console.WriteLine("Anda seri pada ronde ini");
                }
                Console.WriteLine("Skor player : " + playerpoint + ". komputer : " + compoint + ".");
                Console.WriteLine();
                }
                if(playerpoint > compoint)
                {
                Console.WriteLine("Selamat, Kamu Menang!");
                }
                else if(playerpoint < compoint)
                {
                Console.WriteLine("waduh sayang, Kamu Kalah!");
                }
                Console.ReadKey();
        }
    }
}
