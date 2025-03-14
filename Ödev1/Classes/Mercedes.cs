using Ödev1.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1.Classes
{
    class Mercedes : Car,IOzellik1,IYakitTuketimi
    {
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
            return 70.0;
        }
    }
}
