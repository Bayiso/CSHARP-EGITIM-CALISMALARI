using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D5.Consolekomutları
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanalacagimizdeğer = string.Empty;
            Console.Write("Mesaj1"); // mesaj1 in yanında imleç kalır
            Console.WriteLine("mesaj2"); // mesaj 2 nin altına geçer imleç


            Console.Clear(); // ekranda bulununan tüm datayı siler

            // temel bir ihitaycımız olan kullanıcıdan değer alma
            Console.Write("lütfen adınızı girin  : ");

            kullanicidanalacagimizdeğer = Console.ReadLine();

            // kulanıcıdan aldiğimiz değeri ekrana yazmak için şu yontemler kullanılır 

            // 1.yöntem
            string mesaj = ("Girmiş olduğunuz isim değeri : " + kullanicidanalacagimizdeğer);
            Console.WriteLine(mesaj);

            Console.Clear();
            // 2 . yöntem

            //string mesaj = "";

            //mesaj = string.Format("kullanıcıdan aldığınız değer : {0}", kullanicidanalacagimizdeğer);

            // 3. Yöntem
            Console.Clear();


            Console.WriteLine("isminiz : "+ kullanicidanalacagimizdeğer);



            Console.Clear();

            Console.Write("1 ile 10 arasında bir değer girin : ");
            string gelendeğer = Console.ReadLine();
            int sayi1 = int.Parse(gelendeğer); // dönüştürür
            int sayi2 = Convert.ToInt32(gelendeğer); // dönüştürür
            int toplam = sayi1 + 15;
            Console.WriteLine("sayınızın 15 ile toplamı {0} dır.", toplam);



             


            Console.ReadLine();

        }
    }
}
