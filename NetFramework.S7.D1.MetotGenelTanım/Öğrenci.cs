using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.MetotGenelTanım
{
    class Öğrenci
    {
        public void öğrenciselamla()
        {
            Console.WriteLine("merhaba öğrenci");
        }

        /*
         * [ERişim Belirleyicisi] < GEriDonuşDeğeri >MetodADı(parametreler)
         * {
         *      // metot için gereken kodlar
         * }
         *  Erişim Belirleyicisi;
         *  Public = herkes erişssin
         *  Private = sadece o sınıfın içinde kullanilabilir özel bir metot oluor sadece o sınıf için çağrılabilior
         *  Protected
         *  Internal
         *  Internal Protected     
         *  void = bir işlem yapıp sonlanacaksa geri dönüş değeri o zaman void olur
         */ 
         private void ogrencibilgileri(string ogrenciadı , string ogrencisoyadı)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1}",ogrenciadı,ogrencisoyadı);
        }

        public void ogrencibilgiler2()
        {
            ogrencibilgileri("barış ", "caylan");
            
        }

    }
}
