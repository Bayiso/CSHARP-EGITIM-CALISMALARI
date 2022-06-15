using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // class >= Field (alanlar)
            Musteri M1 = new Musteri();
            //M1.id = 1;
            //M1.isim = "barış";
            //M1.soyisim = "caylan";

            /*
             * Field içerisine değer ataması yapılamasın ama okunabilsin
             * Field içerisine değer ataması yapılsın ama değer okunamasın
             * Field içersine değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
             * Field içerisine değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
             * Bir alanın değer alma ve değer okuma kısımlarına müdahale ettğimiz noktalara dioruz
             */
            // clas
            //Field   
            // Property
            // Get & Set
            //M1.emailadresi = "bariscaylan47@gmail.com";
            //M1.EmailAdres = "bariscaylan47@gmail.com";
            //Console.WriteLine(M1.EmailAdres);



            // 1. Field içerisine değer ataması yapılamasın ama okunabilsin



            Console.WriteLine("Müsterini ıd değeri" + M1.ID.ToString());
           // M1.ID = 10;
















        }
    }
}
