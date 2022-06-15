using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramewrok.S4.D3.WhileGenelKullan
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While Döngüsü Genel Kullanımı 
            //while (true) // Şartımız true olduğu süre boyunca döngümüz çalışmasına devam eder. 
            //{
            //    /*
            //     * 1 - While ( False ) 
            //     * 2 - Break; 
            //     */
            //}

            #endregion

            #region Örnek Kullanım 1 : Ekrana 1 - 10 a kadar sayıların değerlerini yazdıralım. 

            // For döngüsü ile bu işlemin cevabı 
            //for(int i = 1; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            #endregion
            Console.Clear();
            #region Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazalım 
            /*
             * 3
             * 2
             * 1
             * 0
             */

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //string kullanicidanGelenDeger = Console.ReadLine();
            //Console.WriteLine("---------------------------------------------");
            //int ornekKullanimSayac = int.Parse(kullanicidanGelenDeger);

            //while (ornekKullanimSayac != -1)
            //{
            //    Console.WriteLine(ornekKullanimSayac);
            //    ornekKullanimSayac = ornekKullanimSayac - 1;
            //    //ornekKullanimSayac--;
            //}

            //Console.WriteLine("Örnek 1 işlemi tamamlandı");

            #endregion
            Console.Clear();

            #region Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0 dan kucuk bir değer girişi yapılırsa toplama işlemini bitirelim. ve ekrana toplam sonucu yazalım. 

            //Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz. ");
            //Console.WriteLine("Not : -1  değeri işlemlerinizi dururur.");

            //int ornekKullanimToplam = 0;
            //while (true)
            //{
            //    string Ornek2KullaniciGelenDeger = Console.ReadLine();
            //    int Ornek2KulGelenDegerInt = int.Parse(Ornek2KullaniciGelenDeger);
            //    if (Ornek2KulGelenDegerInt < 0)
            //        break;
            //    else
            //        ornekKullanimToplam = ornekKullanimToplam + Ornek2KulGelenDegerInt;
            //}

            //Console.WriteLine("Toplam Değer : {0}", ornekKullanimToplam);

            #endregion
            Console.Clear();
            #region Ödev : Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım. 

            int sistemUretSayi = 0;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1,10);
            
            int aq = 1;

            while (true)
            {
                Console.WriteLine("1-10 arasında sayı tahmınınızı yapın.");
                int kullanicisayi = Convert.ToInt32(Console.ReadLine()); sistemUretSayi = rnd.Next(1, 10);

                if (kullanicisayi==sistemUretSayi)
                {
                    aq += 1;
                    Console.WriteLine("Tebrikler sayıyı buldubnuz");
                    Console.WriteLine("{0}. seferinde buldunuz",aq);
                    break;
                }
                
                else
                {
                 
                    Console.WriteLine("Tekrar deneyiniz");
                    aq += 1;

                }
                
                    

            }
            Console.ReadLine();
            
            #endregion



        }
    }
}
