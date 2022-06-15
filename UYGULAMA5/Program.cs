using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UYGULAMA5
{
    class Program
    {
        static double hacimHesapla(double a)
        {
            #region ödev5 uygulama1
            //Kenarı girilen küpün hacmini hesaplayan fonksiyonu yazınız.
            double hacim;
            hacim = a * a * a;
            return hacim;
        }
        static void Main(string[] args)
        {
            double kenar, hacim;
            Console.Write("Kenarı Giriniz = ");
            kenar = double.Parse(Console.ReadLine());
            hacim = hacimHesapla(kenar);
            Console.Write("Sonuç = {0}", hacim);

            #endregion
            #region ödev5 uygulama2
            //üçgenin alanı
            int h, sonuc, tbn;

            Console.WriteLine("Yükseklik giriniz: ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Taban uzunluğu giriniz: ");
            tbn = Convert.ToInt32(Console.ReadLine());

            sonuc = (h * tbn) / 2;

            Console.WriteLine("Üçgen Alanı: " + sonuc);
            #endregion
        }
    }
}
