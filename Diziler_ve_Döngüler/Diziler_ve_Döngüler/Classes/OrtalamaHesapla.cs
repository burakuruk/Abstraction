using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_ve_Döngüler.Classes
{
    class OrtalamaHesapla
    {
        private int[] sayilar;
        private int toplam;

        public OrtalamaHesapla()
        {
            sayilar = new int[5];
            toplam = 0;
        }

        public void SayilariAl()
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. sayıyı girin: ");

                while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
                {
                    Console.Write("Hatalı giriş! Lütfen bir tam sayı girin: ");
                }

                toplam += sayilar[i];
            }
        }

        public void SonucuYazdir()
        {
            double ortalama = (double)toplam / sayilar.Length;
            Console.WriteLine($"\nGirilen sayıların toplamı: {toplam}");
            Console.WriteLine($"Girilen sayıların ortalaması: {ortalama:F2}");
        }
    }
}

