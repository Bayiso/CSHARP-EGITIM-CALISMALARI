using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D2.ForeachGenelKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            #region genel kullanımı
            //string[] isimler = new[] { "benavo lan", "fer quz", "kamil", "ozguro47" };
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            Console.Clear();

            #region uygulama 1; int veri tipinde bir dizi oluşturalım kullanıcımız dizinin kaç elemanlı olucağı bilgisini bize versin ve dizi içindeki alanlara değer ataması yapsın daha sonra dizi içindeki elemanlarının toplamını  ve ortalamasnı ekrana yazdıran bir uygulama

            //Console.WriteLine("Dizininz kaç elemanlı olsun  ");
            //int kullanıcıdan = Convert.ToInt32(Console.ReadLine());
            //int[] dizimiz = new int[kullanıcıdan];
            //for(int sayac =0;sayac<dizimiz.Length;sayac++)
            //{
            //    Console.WriteLine("{0}. elemanın değeri kaç olsun",sayac);
            //    dizimiz[sayac] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("tebrikler dizinin içerisindeki tüm alanları odldurdunuz.");

            //int toplamımı = 0;


            //foreach (int item in dizimiz)
            //{
            //    toplamımı += item;
            //}
            //Console.WriteLine("girdiğiniz değerlin toplamı {0} dır ve ortlaması {1} dir.", toplamımı, (toplamımı / dizimiz.Length));
            //Console.ReadLine();

            #endregion


            #region uygulama 2 ;20 elemanlı bir int dizi oluşturalım değerlerimizi random sınıfının next fonk ile 1-10 arasındaki değerler ile dolduralım. sonra ekrana yazdırıp içinde kaç tane 4 olduüuna bakalım.




            

            int[] dizim = new int[20];
            for (int i = 0; i < dizim.Length; i++)
            {
                Random rastgele = new Random();
                int sayı = rastgele.Next(1, 10);
                Console.WriteLine(dizim[i] = sayı );
            }
            Console.WriteLine(dizim);
            int kacdort = 0;
            foreach (int item in dizim)
            {
                if (item==4)
                {
                    kacdort++;

                }
            }
            Console.WriteLine(kacdort);
            Console.ReadLine();
















            #endregion

        }
    }
}
