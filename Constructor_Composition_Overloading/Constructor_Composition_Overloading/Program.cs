using Constructor_Composition_Overloading.Classes;
using System;
class Program
{
    public static void Main()
    {
        Marka bmw = new Marka { Ad = "BMW", Model = "X5", Fiyat = 2000000 };
        Kapi kapi = new Kapi { KapiSayisi = 4 };
        Pencere pencere = new Pencere { PencereSayisi = 4 };
        Kasa kasa = new Kasa { KasaTipi = "sedan" };

        Araba araba = new Araba(bmw, kapi, pencere, kasa);
        araba.BilgileriYazdir();

        Console.WriteLine("--MATEMATİK İŞLEMLERİ---");
 
        Matematik mat = new Matematik();

        Console.WriteLine("Toplama İşlemleri:");
        Console.WriteLine(mat.Topla(3, 5));
        Console.WriteLine(mat.Topla(2.5, 3.5));
        Console.WriteLine(mat.Topla(1, 2, 3));

        Console.WriteLine("\nÇarpma İşlemleri:");
        Console.WriteLine(mat.Carp(4, 5));
        Console.WriteLine(mat.Carp(2.5, 3.5));
        Console.WriteLine(mat.Carp(2, 3, 4));
    }
}
