using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D4.TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayı1 = byte.MaxValue;
            sayı1 = byte.MinValue;


            // Bilinçli Tür Dönüşümleri

            int sayi2 = 125;
            sayı1 = (byte)sayi2;
            Console.WriteLine(sayı1);


            // Bilinçsiz Tur Donusumleri

            double sayi3 = 10;
            sayi3 = sayi2;
            Console.WriteLine(sayi3);

            // checked  -  unchecked

            sayi2 = 512;
            sayı1 = (byte)sayi2; // framework bunu bir hata olarak belirtmez 

            unchecked
            {
                sayi2 = 512;
                sayı1 = (byte)sayi2;// umursama demek
            }

            //checked
            {
                sayi2 = 512; // değer kaybedince hata al.
                sayı1 = (byte)sayi2;


            }




            // OBJECT veri Tipi tüm .net veri tipinin anasıdır



            object temeltip = sayi2;
            temeltip = sayi3;
            temeltip = new
            {
                marka = "Opel",
                model = "Corsa",
            };


            // Boxing İşlemi
            temeltip = sayi2; // boxing işlemi
            sayi2 = (int)temeltip; // unboxing işlemi
            // bir değeri objecte atamaya biz boxig işlemi dıoruz .  



            Console.Write("");








        }
    }
}
