using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.Tc = "Tc:6874312 ";
            musteri1.Adi = "Adı:Ali ";
            musteri1.SoyAdi = "Soyadı:Ay " + "Yaş:";
            musteri1.Yas = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Tc = "Tc:8756412 ";
            musteri2.Adi = "Adı:Murat ";
            musteri2.SoyAdi = "Soyadı:Sayra "+"Yaş:";
            musteri2.Yas =35;



            MusteriManager yönet = new MusteriManager();
            yönet.ekle(musteri1);
            yönet.sil(musteri2);
        }
    }
}
