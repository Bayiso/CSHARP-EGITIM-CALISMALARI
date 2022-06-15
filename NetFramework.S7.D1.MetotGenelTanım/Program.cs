using System; // bir kütüphane dosyasını uygulamızın iöerisine eklemektir
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.MetotGenelTanım
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba brayoo");
            //Merhabade();
            Öğrenci o1 = new Öğrenci();

            o1.ogrencibilgiler2();
           // o1.öğrenciselamla();
        }
        static void Merhabade()
        {
            Console.WriteLine("merhaba");
        }

    }
}
