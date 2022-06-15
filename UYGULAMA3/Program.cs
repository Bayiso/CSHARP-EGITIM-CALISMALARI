using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UYGULAMA3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ödev3 uygulam1
            //çarpım tablosu
            for (int i = 1; i <= 9; i++)
            {
                for (int J = 1; J <= 9; J++)
                {

                    int sonuc = i * J;
                    Console.Write("{0}*{1}={2} \t", i, J, sonuc);
                    Console.WriteLine();
                }
                Console.WriteLine("*******************");
            }
            Console.ReadLine();
            #endregion


            #region ödev3 uygulama2
            //Girilen sayı değeri kadar döngü toplamını bulan programı yazınız.
            Console.Write("Sayınız :");
            string uygulama2_girdi1 = Console.ReadLine();

            int uygulama2_sayi = int.Parse(uygulama2_girdi1);
            int uygulama2_toplam = 0; int uyg2_i = 1;
            int uygulama2_toplam2 = 0;
            while (uygulama2_sayi >= uyg2_i)
            {
                for (int uyg2_j = 1; uyg2_j <= uygulama2_sayi; uyg2_j++)
                {
                    Console.WriteLine($"{uyg2_i}   {uyg2_j}");
                    uygulama2_toplam += uyg2_i;
                    uygulama2_toplam2 += uyg2_j;
                }
                uyg2_i++;
            }
            Console.WriteLine($"Girdiğiniz sayıya göre döngünün toplamı :" +
                $" {uygulama2_toplam + uygulama2_toplam2}");


            #endregion
            #region ödev3 uygulama3
            //Girilen sayı adedi kadar fibonachi sayı dizisini ekrana yazdıran programı yazınız.
            //int x = 0; // hocam alttakiler de x değişkeni var karışırsa yorum satırına getirdim
            int y = 1, z;
            int sayi;

            Console.WriteLine("sayınızı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(x + " " + "\n" + y + " ");

            for (int i = 0; i < sayi - 2; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;

            }
        #endregion


        #region ödev3 uygulama4
        //Girilen ay isminin kaçıncı ay olduğunu bulan programı switch-case yapısını kullanarak yazınız.

        yenidenseçim:
            Console.WriteLine("Kaçıncı aydayız:");
            int hangiay = Convert.ToInt32(Console.ReadLine());
            switch (hangiay)
            {
                case 1:
                    Console.WriteLine("Ocak ayında");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayı");
                    break;
                case 3:
                    Console.WriteLine("mart ayı");
                    break;
                case 4:
                    Console.WriteLine("nisan ayı");
                    break;
                case 5:
                    Console.WriteLine("mayıs ayı");
                    break;
                case 6:
                    Console.WriteLine("haziran ayı");
                    break;
                case 7:
                    Console.WriteLine("temmuz ayı");
                    break;
                case 8:
                    Console.WriteLine("ağustos ayı");
                    break;
                case 9:
                    Console.WriteLine("eylül ayı");
                    break;
                case 10: Console.WriteLine("ekim ayı"); break;
                case 11:
                    Console.WriteLine("kasım ayı");
                    break;
                case 12:
                    Console.WriteLine("aralık ayı");
                    break;
                default:
                    Console.WriteLine("1-12 arasında değer gir ");
                    goto yenidenseçim; //goto kullanımı nereye seçersek oraya döner
            }

            #endregion

            #region ödev3 uygulama5
            //Girilen bir kelime için harflerini sıralayan programı yazınız.
            Console.WriteLine("Alfabetik sıralamak için bir kelime girin");
            string kelime = Console.ReadLine();
            int kelimeuzunluk = kelime.Length;
            char[] dizi = new char[kelimeuzunluk];
            for (int i = 0; i < kelimeuzunluk; i++)
            {
                dizi[i] = kelime[i];

            }
            Array.Sort(dizi);
            Console.WriteLine("alfabetik sıralı hali : ");
            for(j = 0; j < kelimeuzunluk; j++)
            {
                Console.Write(dizi[j]);
            }
            Console.ReadLine();
            #endregion

            #region ödev3 uygulama6
            //Ekrana dışarıdan klavye ile girilen boyutlarda baklava dilimi şeklini çizen programı yazınız.

            int satir;
            Console.Write("Baklava diliminin boyutunu giriniz = ");
            satir = int.Parse(Console.ReadLine());
            for (int i = 0; i <= satir; i++)
            {

                for (int j = 0; j <= (satir + 1) - i; j++)

                    Console.Write("  ");

                for (int k = 0; k <= 2 * i - 2; k++)

                    Console.Write("**");

                Console.WriteLine();

            }

            
            for (int m = 0; m <= satir; m++) // alt kısmı için
            {

                for (int n = 0; n <= m; n++)

                    Console.Write("  ");

                for (int z = m * 2; z <= satir * 2; z++)

                    Console.Write("**");

                Console.WriteLine();

            }
            
            Console.ReadKey();

            #endregion
            #region ödev3 uygulama7
            //paskal üçgeni
            Console.Write("Satır Sayısını Nedir: ");
            int paskalsatır = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < paskalsatır; i++)
            {
                int c = 1;
                for (int e = 0; e < paskalsatır - i; e++)
                {
                    Console.Write("   ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("    {0} ", c);
                    c = c * (i - x) / (x + 1);
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
