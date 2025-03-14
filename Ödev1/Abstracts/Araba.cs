using Ödev1.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1.Abstracts
{
    public abstract class Araba : IYakitTuketimi
    {
        public string Marka;
        public double SaatlikYakitTüketimi;

        public abstract double YakitHesapla();
    }
}
