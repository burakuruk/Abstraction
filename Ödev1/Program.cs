using Ödev1.Abstracts;
using Ödev1.Classes;

Console.WriteLine("--BİRİNCİ ARAÇ--\n");

Ödev1.Classes.Bmw a = new Ödev1.Classes.Bmw();
a.Marka = "BMW";
a.Model = "520i Executive M Sport" ;
a.Yil = 2024;
a.Yakit = "Benzin";
a.Vites = "Otomatik";
a.KM = 6001;
a.Kasa_Tipi = "Sedan";
a.Motor_Gücü = 170;
a.Motor_Hacmi = 1592;
a.Cekis = "Arkadan itiş";
a.hizli(a.Marka);
a.yüzer(a.Marka);
a.ucar(a.Marka);

a.Bilgigetir(a.Marka,a.Model,a.Yil,a.Yakit,a.Vites,a.KM,a.Kasa_Tipi,a.Motor_Gücü,a.Motor_Hacmi,a.Cekis);

Console.WriteLine("\n--İKİNCİ ARAÇ--\n");

Mercedes m = new Mercedes();

m.Marka = "Mercedes-Benz";
m.Model = "C 200 d BlueTEC AMG";
m.Yil = 2015;
m.Yakit = "Dizel";
m.Vites = "Otomatik";
m.KM = 186.001;
m.Kasa_Tipi = "Sedan";
m.Motor_Gücü = 150;
m.Motor_Hacmi = 1800;
m.Cekis = "Arkadan itiş";
m.ucar(m.Marka);
m.yüzer(m.Marka);

m.Bilgigetir(m.Marka, m.Model, m.Yil, m.Yakit, m.Vites, m.KM, m.Kasa_Tipi, m.Motor_Gücü, m.Motor_Hacmi, m.Cekis);

Console.WriteLine("\n--ÜÇÜNCÜ ARAÇ--\n");

Car t = new Togg();

t.Marka = "TOGG";
t.Model = "T10X V2 Uzun Menzil";
t.Yil = 2024;
t.Yakit = "Elektrik";
t.Vites = "Otomatik";
t.KM = 14.901;
t.Kasa_Tipi = "SUV";
t.Motor_Gücü = 218;
t.Cekis = "4x2 (Arkadan İtişli)";

t.Bilgigetir(t.Marka, t.Model, t.Yil, t.Yakit, t.Vites, t.KM, t.Kasa_Tipi, t.Motor_Gücü, t.Motor_Hacmi, t.Cekis);

Console.WriteLine("\n--DÖRDÜNCÜ ARAÇ--\n");

Car au = new Audi();

au.Marka = "Audi";
au.Model = "A6 Sedan 40 TDI Quattro S Line";
au.Yil = 2022;
au.Yakit = "Dizel";
au.Vites = "Otomatik";
au.KM = 63.891;
au.Kasa_Tipi = "Sedan";
au.Motor_Gücü = 225;
au.Motor_Hacmi = 2000;
au.Cekis = "4WD (Sürekli)";

au.Bilgigetir(au.Marka, au.Model, au.Yil, au.Yakit, au.Vites, au.KM, au.Kasa_Tipi, au.Motor_Gücü, au.Motor_Hacmi, au.Cekis);

Console.WriteLine("\n--BEŞİNCİ ARAÇ--\n");

Car to = new Toyota();

to.Marka = "Toyota";
to.Model = " GT86";
to.Yil = 2012;
to.Yakit = "Benzin";
to.Vites = "Manuel";
to.KM = 9000;
to.Kasa_Tipi = "Coupe";
to.Motor_Gücü = 200;
to.Motor_Hacmi = 1998;
to.Cekis = "Arkadan İtiş";

to.Bilgigetir(to.Marka, to.Model, to.Yil, to.Yakit, to.Vites, to.KM, to.Kasa_Tipi, to.Motor_Gücü, to.Motor_Hacmi, to.Cekis);

Console.WriteLine("\n--ALTINCI ARAÇ--\n");

Porsche p = new Porsche();

p.Marka = "Porsche";
p.Model = " 911-GT3 RS";
p.Yil = 2024;
p.Yakit = "Benzin";
p.Vites = "Otomatik";
p.KM = 0;
p.Kasa_Tipi = "Coupe";
p.Motor_Gücü = 525;
p.Motor_Hacmi = 4000;
p.Cekis = "Arkadan İtiş";
p.ucar(p.Marka);

p.Bilgigetir(p.Marka, p.Model, p.Yil, p.Yakit, p.Vites, p.KM, p.Kasa_Tipi, p.Motor_Gücü, p.Motor_Hacmi, p.Cekis);

Console.WriteLine("\n--VİTES TÜRÜNE GÖRE ARAÇLAR--\n");

OtomatikV o = new OtomatikV();
o.Marka = "Porsche";
o.Model = "911-GT3 RS =";
o.vites = "Otomatik";
o.vitestürü(o.Marka, o.Model, o.vites);

OtomatikV ad = new OtomatikV();
ad.Marka = "Audi";
ad.Model = "A6 Sedan 40 TDI Quattro S Line =";
ad.vites = "Otomatik";
ad.vitestürü(ad.Marka, ad.Model, ad.vites);

OtomatikV bmo = new OtomatikV();
bmo.Marka = "BMW";
bmo.Model = "520i Executive M Sport =";
bmo.vites = "Otomatik";
bmo.vitestürü(bmo.Marka, bmo.Model, bmo.vites);

OtomatikV mbo = new OtomatikV();
mbo.Marka = "Mercedes-Benz";
mbo.Model = "C 200 d BlueTEC AMG =";
mbo.vites = "Otomatik";
mbo.vitestürü(mbo.Marka, mbo.Model, mbo.vites);

OtomatikV tgo = new OtomatikV();
tgo.Marka = "TOGG";
tgo.Model = "T10X V2 Uzun Menzil =";
tgo.vites = "Otomatik";
tgo.vitestürü(tgo.Marka, tgo.Model, tgo.vites);

ManuelV tyo = new ManuelV();
tyo.Marka = "Toyota";
tyo.Model = "GT86 =";
tyo.vites = "Manuel";
tyo.vitestürü(tyo.Marka, tyo.Model, tyo.vites);

Console.WriteLine("\n--ÇALIŞANLARIN TOPLAM MAAŞLARI--\n");

GenelMüdür gn = new GenelMüdür();
Müdür mü = new Müdür();
Programcı pr = new Programcı();
Stajyer st = new Stajyer();

double ToplamMaas = 0.0;
ToplamMaas += gn.MaasinizNedir();
ToplamMaas += mü.MaasinizNedir();
ToplamMaas += pr.MaasinizNedir();
ToplamMaas += st.MaasinizNedir();

Console.WriteLine("Toplam: " + ToplamMaas + " TL maaş alınıyor.");

Console.WriteLine("\n--ARABALARIN TOPLAM BENZİN TÜKETİMİ--\n");

Bmw bmw = new Bmw();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();

double ToplamBenzin = 0.0;
ToplamBenzin += bmw.YakitHesapla();
ToplamBenzin += mercedes.YakitHesapla();
ToplamBenzin += porsche.YakitHesapla();

Console.WriteLine("BMW = " + bmw.YakitHesapla() + " L");
Console.WriteLine("MERCEDES = " + mercedes.YakitHesapla() + " L");
Console.WriteLine("PORSCHE = " + porsche.YakitHesapla() + " L");

Console.WriteLine("\nToplam: " + ToplamBenzin + " L Benzin Tüketildi.");