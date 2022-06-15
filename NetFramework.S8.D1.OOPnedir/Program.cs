using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPnedir
{
    class Program
    {
        static void Main(string[] args)
        {
            arac aracınbilgisi = new arac();
            aracınbilgisi.aracmodeli();
            aracınbilgisi.aracyakıt();
            aracınbilgisi.aracmarkası();
            aracınbilgisi.arackm(54156161);







            //Musteri M1 = new Musteri();
            Musteri M1 = new Musteri("122544013254", "Murat");
            M1.TCkimliknumara = "12254401352";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.cinsiyet = 717770001;


            Musteri M2 = M1;

            M2.isim = "Murat";
            M1.TCkimliknumara = "12254401325";

            bool musteriKontrol = M1.MusteriKontrol();


            //M2 = null;
            //M1 = null;

            //string isim = M2.isim;
        }
    }
}
