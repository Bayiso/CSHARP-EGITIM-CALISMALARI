using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D6.AsiriYuklenmek
{
    class Program
    {
        static void Main(string[] args)
        {
            topla(10, 10); // aşırı yuklenme budur
        }
        static void topla(int sayi1 , int sayi2)
        {
            int toplam =0;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        static void topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = 0;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

        }
        static void topla( string metin1, string metin2)
        {
            string toplam = (metin1 + " " + metin2);
            Console.WriteLine(toplam);
        }
    }
}
