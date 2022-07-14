using homework_2.Abstract;
using homework_2.Concrete;

Araba araba1 = new Ferrari();
Araba araba2 = new Porsche();

araba1.renk = "siyah";
araba1.yakit_turu = "benzin";
araba1.vites_turu = "otomatik";
araba1.ad = "2022";

araba2.renk = "beyaz";
araba2.yakit_turu = "dizel";
araba2.vites_turu = "otomatik";

Console.WriteLine( araba1.ad);