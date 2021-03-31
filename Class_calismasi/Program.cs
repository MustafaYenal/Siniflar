using System;

namespace Class_calismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Çalışma Masası";
            urun1.UrunFiyatı = 174.99;
            urun1.StokMiktarı = 13;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Koltuk Takımı";
            urun2.UrunFiyatı = 1499.99;
            urun2.StokMiktarı = 5;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Ev Telefonu";
            urun3.UrunFiyatı = 499.99;
            urun3.StokMiktarı = 8;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            //listeleme yöntemini foreach,for,while döngüleriyle yapılacak!!!
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " - " 
                    + urun.UrunFiyatı + " TL - " 
                    + urun.StokMiktarı + " adet kalmıştır ");
            }
            Console.WriteLine("foreach dongüsü bitti\n\n");
            for(int i=0;i<urunler.Length;i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " - " 
                    + urunler[i].UrunFiyatı + " TL - "
                    + urunler[i].StokMiktarı + " adet kalmıştır ");
            }
            Console.WriteLine("for döngüsü bitti\n\n");

            int j = 0;
            while (j<urunler.Length)
            {
               Console.WriteLine(urunler[j].UrunAdi + " - "
                   + urunler[j].UrunFiyatı + " TL - "
                   + urunler[j].StokMiktarı + " adet kalmıştır ");  

                j++;
            }
        }
    }
}
