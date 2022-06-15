using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D1.ForGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for dongusu genel kullanımı
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("ben bir for döngüsüyüm");
            }
            #endregion


            Console.Clear();


            #region 1 ile 10 arasında değerleri yazalım
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ". tekrar");
            }


            #endregion

            Console.Clear();

            #region 1 ile 100 arasında kş çift sayıları yazalım
            for (int i = 0; i <= 100 ; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i+"sayımız çifttir");
                }
            }
            #endregion

            Console.Clear();

            #region 1 ile 100 arasındaki çift sayıların toplamı ödevim
            int toplamsayı = 0;

            for (int i = 0; i <=100 ; i++)
            {
                if (i%2==0)
                {
                    toplamsayı += i;
                }
            }
            Console.WriteLine(toplamsayı);
            #endregion

            Console.Clear();

            #region kullanıcıdan girilen sayının faktöriyelini hesaplayalım ödev
            //Console.Write("FAktöriyelini almak istediğin sayıyı girin: ");
            //int girilensayi = Convert.ToInt32(Console.ReadLine());
            //toplamsayı = 1;
            //for (int i = 1; i<=girilensayi; i++)
            //{
            //    toplamsayı *= i;
            //}
            //Console.WriteLine(toplamsayı);
            //Console.ReadLine();
            #endregion
            Console.Clear();
            #region sonsuz döngü oluşturmak
            //int sonsuzDonguSayac = 0;
            //for (; ; )
            //{
            //    sonsuzDonguSayac++;
            //    //break anahtar kelimesi;
            //    //if (sonsuzDonguSayac == 2)
            //    //    break;
            //    // continue anahtar kelimesi
            //    if (sonsuzDonguSayac == 2)
            //        continue;

            //    Console.WriteLine(sonsuzDonguSayac);

            //    Console.WriteLine("Merhaba ben bir sonsuz döngüyüm");
            //}

            #endregion
            Console.Clear();

            #region İçİçe For Döngüsü
            for (int i = 1; i <=20; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
            Console.Clear();
            #region ÖDEV ÇARPIM TABLOSU
            for (int i = 1; i<=9; i++)
            {
                for (int J = 1; J <=9; J++)
                {

                    int sonuc = i * J;
                    Console.Write("{0}*{1}={2} \t",i,J,sonuc);
                    Console.WriteLine();
                }
                Console.WriteLine("*******************");
            }
            Console.ReadLine();
            #endregion
            // sabit döngü = for foreach
            // şartlı dönü = while do while





        }
    }
}
