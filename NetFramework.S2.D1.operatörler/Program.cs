using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S2.D1.operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * % mod alma operatörü
             * + toplama 
             * - çıkarma
             * * çarpma
             * / bölme
             * ++ bi toplama operaröü
             * -- bir çıkarma operatörü
             */


            //ÖDEV  İKİ SAYI KULLANICIDAN İSTE VE TOPLA : 
            #region toplama ödevi
            Console.WriteLine("Birinci sayıyı gir : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());//DİREK KISA YOLDAN DÖNÜŞTÜRME TAKTİĞİ

            Console.WriteLine("İkinci sayıyı gir kardeşim : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayılarınız toplamı = {0} dir.", sayi1+sayi2);
            Console.ReadLine();
            #endregion


            #region çıkarma ödevi

            Console.Write("birinci sayıyı gir.:");

            int birincisayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("ikinci sayıyı gir.:");
            int ikincisayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iki sayının çıkarma işlemi sonucu {0} dır.", birincisayi-ikincisayi);
            Console.ReadLine();

            #endregion

            #region mod alma ödevi
            Console.Write("1. sayıyıgir");
            int birincisayimiz = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı gir. ");
            int ikinicisayimiz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("birinci sayınızın ikinci sayıya bölümünden kalan: {0} dır",birincisayi%ikincisayi);
            Console.ReadLine();
            #endregion
            // ++ işlemi her dögüde mesela bir arttır
            // -- de işlemi 1 azalt
            // += sayı +=5 dediğimizde 5 artar
















        }
    }
}
