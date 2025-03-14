using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1.Classes
{

    public class Car
    {
        public string? Marka = null;
        public string? Model = null;
        public int Yil = 0;
        public string? Yakit = null;
        public string? Vites = null;
        public double KM = 0;
        public string? Kasa_Tipi = null;
        public int Motor_Gücü = 0;
        public int Motor_Hacmi = 0;
        public string? Cekis = null;
        public string? vites;
        public void vitestürü(string Marka, string Model, string vites)
        {
            Console.WriteLine(Marka + " " + Model + " " + vites);
        }
     
        public void Bilgigetir(string marka, string model, int Yil, string Yakit, string Vites, double KM, string kasa_Tipi, int Motor_Gücü, int Motor_Hacmi, string Cekis)
        {
         Console.WriteLine("Arabanın markasi: " + marka);
         Console.WriteLine("Arabanın modeli: " + model);
         Console.WriteLine("Arabanın yılı: " + Yil);
         Console.WriteLine("Arabanın yakıt türü: " + Yakit);
         Console.WriteLine("Arabanın vites türü: " + Vites);
         Console.WriteLine("Arabanın KM'si: " + KM);
         Console.WriteLine("Arabanın motor gücü: " + Motor_Gücü);
         Console.WriteLine("Arabanın motor hacmi: " + Motor_Hacmi);
         Console.WriteLine("Arabanın çekiş türü: " + Cekis);
        }

     
    }
  
}
