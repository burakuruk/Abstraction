using Ödev1.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1.Classes
{
    class Bmw : Car, IOzellik1,IYakitTuketimi
    {
       
        public void hizli(string isim)
        {
            Console.WriteLine(isim + " Cok hizli gider");
        }

        public void yüzer(string isim)
        {
            Console.WriteLine(isim + " Denizde yuzer");
        }

        public void ucar(string isim)
        {
            Console.WriteLine(isim + " Havada ucar");
        }
        public double YakitHesapla()
        {
            return 80.0;
        }
    }
}
