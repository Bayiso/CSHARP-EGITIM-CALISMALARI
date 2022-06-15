using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S2.D2.Karşılaştırmaoperatörleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * < = küçüktür
             * > = büyüktür
             * <= küçük eşittir
             * >= büyük eşittir
             * ==şittir
             * != eşit değildir
             * is = tür dönüşümlerinde kullanığımız operatörler
             * as ''
            */
            int sayi1 = 15;
            int sayi2 = 10;
            bool kucuk = sayi1 < sayi2;
            Console.WriteLine(kucuk);
            Console.ReadLine();
            //is - as operatörleri
            #region is-as tanım

            object birincikutu = "bayiso";
            //int birincikutusaisi = (int)birincikutu; // değeri int çevirioz object içindeki

            bool kontrolveritipi = birincikutu is int; // object kutusu içindeki değer int mi değil mi ? 
            object o2 = "bayisobea";
            string isim = o2 as string; // o2 değerinin stringe çevir as ile çveir is ile kontrol edip as ile çevirioruz




            Console.WriteLine("");


            #endregion

        }
    }
}
