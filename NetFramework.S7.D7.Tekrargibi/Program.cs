using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D7.Tekrargibi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine(true);
            decimal toplam = topla(12m, 54m);
            EkrandaGöster(toplam);

            EkrandaGöster(topla(10, 15)); 



        }
        static void EkrandaGöster(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static int topla(int sayi1, int sayi2)
        {
 
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = 0;
            toplam = sayi1 + sayi2;
            return toplam;

        }
        static string topla(string metin1, string metin2)
        {
             return metin1 + " " + metin2;
        }
    }
}
