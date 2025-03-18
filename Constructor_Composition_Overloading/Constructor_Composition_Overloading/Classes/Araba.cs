using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading.Classes
{
    public class Araba
    {
        public Marka Marka { get; set; }
        public Kapi Kapi { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }

        public Araba(Marka marka, Kapi kapi, Pencere pencere, Kasa kasa)
        {
            Marka = marka;
            Kapi = kapi;
            Pencere = pencere;
            Kasa = kasa;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Arabanın markası {Marka.Ad}, modeli {Marka.Model}, kapı sayısı {Kapi.KapiSayisi}, pencere sayısı {Pencere.PencereSayisi}, kasası {Kasa.KasaTipi}, fiyatı {Marka.Fiyat} TL’dir.");
        }
    }
}


