using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "TAŞ KAĞIT MAKAS OYUNU ☺"; //@kod.manyagi
            int kazanan = 0;
            int kaybeden = 0;
            string kadi = "";
            string[] secenek = { "taş", "kağıt", "makas" };
            Console.WriteLine("-->>TAŞ KAĞIT MAKAS OYUNU 5 YAPAN KAZANIR<<--");

            do
            {

                Console.Write("\nTaş kağıt makas yazınız :");
                kadi = Console.ReadLine();
                Random pc = new Random();
                int i = pc.Next(0, 2);
                Console.Write("Kullanıcı = {0} PC = {1} ", kadi, secenek[i]);

                if (kadi == "taş" && secenek[i] == "kağıt")
                {
                    kaybeden++;
                    Console.WriteLine("Kaybettin");
                }

                if (kadi == "taş" && secenek[i] == "makas")
                {
                    kazanan++;
                    Console.WriteLine("Kazanandın ☺");
                }


                if (kadi == "makas" && secenek[i] == "kağıt")
                {
                    kazanan++;
                    Console.WriteLine("Kazanandın ☺");
                }

                if (kadi == "makas" && secenek[i] == "taş")
                {
                    kaybeden++;
                    Console.WriteLine("Kaybettin");
                }

                if (kadi == "kağıt" && secenek[i] == "taş")
                {
                    kazanan++;
                    Console.WriteLine("Kazanandın ☺");
                }

                if (kadi == "kağıt" && secenek[i] == "makas")
                {
                    kaybeden++;
                    Console.WriteLine("Kaybettin");
                }

                if (kadi == "kağıt" && secenek[i] == "kağıt")
                {
                    Console.WriteLine("Berabere");
                }

                if (kadi == "taş" && secenek[i] == "taş")
                {
                    Console.WriteLine("Berabere");
                }

                if (kadi == "makas" && secenek[i] == "makas")
                {
                    Console.WriteLine("Berabere");
                }
                Console.WriteLine("Skor Kullanıcı = {0} PC = {1}", kazanan,kaybeden);
                if(kazanan == 5)
                {
                    Console.Write("Tebrikler Kazamınız");
                    break;
                }
                else if(kaybeden == 5)
                {
                    Console.WriteLine("Malesef kaybettiniz");
                    break;
                }
            } while (kadi != "q");
            Console.ReadKey();

        }
    }
}