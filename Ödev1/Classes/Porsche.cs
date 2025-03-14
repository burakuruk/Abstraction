using Ödev1.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1.Classes
{
    class Porsche : Car,IOzellik1,IYakitTuketimi
    {
        public void ucar(string isim)
        {
            Console.WriteLine(isim + " Havada ucar");
        }

        public double YakitHesapla()
        {
            return 60.0;
        }
    }
}
