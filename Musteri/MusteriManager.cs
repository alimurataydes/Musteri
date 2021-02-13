using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri
{
    class MusteriManager
    {
        public void ekle(Musteri No1)
        {
            Console.WriteLine(No1.Tc + No1.Adi + No1.SoyAdi +No1.Yas+ " kişisi eklendi!");
        }

        public void sil(Musteri No2)
        {
            Console.WriteLine(No2.Tc + No2.Adi + No2.SoyAdi+ No2.Yas + " kişisi silindi!");
        }
    }
}
