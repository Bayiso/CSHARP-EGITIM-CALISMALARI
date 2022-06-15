using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D1.DeğişkenNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // veritipi değişkenadı
            string isim;
            isim = "barış";
            Console.Write("Kulanıcı Adı :");
            Console.WriteLine(isim);
            int i = 4;
            int y = i;
            Console.WriteLine(i);
            Console.WriteLine(y);
            y = 10;
            Console.WriteLine(y);


            int sayi1 = 0;
            sayi1 = int.MinValue;
            Console.WriteLine("en düşük değer :");
            Console.WriteLine(sayi1);
            sayi1 = int.MaxValue;
            Console.WriteLine("en büyük değer : ");
            Console.WriteLine(sayi1);
            double sayi2 = double.MinValue;
            Console.WriteLine(sayi2);


            
            {
                int toplam = 30;
                Console.WriteLine(toplam);
                sayi2 = 100;

            }
            Console.WriteLine(sayi2);

            string isimsoyisim = "barış Caylan";
            string belirlibirbölüm = isimsoyisim.Substring(2, 4);
            Console.WriteLine(belirlibirbölüm);
            char kullanıcısecim = 'A'; //bu seçim aracında daha az yer kaplıyor 

            Console.WriteLine(kullanıcısecim);
            {
                //değişkenzamansal
                DateTime tarihsaat = DateTime.Now;
                Console.WriteLine(tarihsaat);

            }
            {
                // kullanıcıdan değer alalım yaw 
                Console.WriteLine("İsim u soyisim gir : ");
                string isimm = Console.ReadLine();
                Console.WriteLine("memleketini gir : ");
                string memleket = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("isminiz : " +isimm);
                Console.WriteLine("memleketiniz: " + memleket);


            }
            {
                //bilinçli tür dönüşümü
                byte sayii1 = 100; // yani True
                byte byteminval = byte.MinValue; //0
                byte bytemaxval = byte.MaxValue; //255
                // sayii1 = 256; burada hata alırız çünkü max değerini aşıoruz byte tipinin
                int sayii2 = 256;


                int sayii3 = sayii1; //buna bilinçli denir işte


                // Bilinçsiz Tür Dönüşümü

                int number1 = 100;
                byte number2 = (byte)number1; // ben burda byte değişken tipine garanti veriyorum , eğer aşıcak bir şey yapsak 0 olarak yazar




            }
            Console.ReadLine();

        }
    }
}
