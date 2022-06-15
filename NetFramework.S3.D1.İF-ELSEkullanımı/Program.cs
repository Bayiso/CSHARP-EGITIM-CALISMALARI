using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D1.İF_ELSEkullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Genel Kullanım
            if (true) 
            {
                // koşul sağlanıorsa  bu işlemleri yap
            }
            else
            {
                //sağlamıorsa bu işlemleri yap
            }
            #endregion
            #region MERHABA İF ELSE
            int sayi1 = 10;
            int sayi2 = 20;
            //if (sayi1 < sayi2)
            //{
            //    Console.WriteLine("Sayı 1 sayı 2 den küçüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 1 sayı 2 den büyüktür");
            //}
            if (sayi1 < sayi2) Console.WriteLine("sayı1 - sayı 2 değerinden küçüktür");
            else Console.WriteLine("sayı1-sayı2den değerinden büyüktür"); // daha kısaltılış yazış
            Console.ReadLine();

            #endregion


        }
    }
}
