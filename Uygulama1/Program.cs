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
            


            Console.Write("Birinci sayıyı gir : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı gir  : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Yapmak İstediğiniz işlemi seçin");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            string seçim = Console.ReadLine();

            switch (seçim)
            {
                case "+":
                    Console.WriteLine("İki sayının Toplamı {0} dır",(sayi1+sayi2));
                    break;
                case "-":
                    Console.WriteLine("İki sayının Çıkartması {0} dır", (sayi1 - sayi2));
                    break;
                case "*":
                    Console.WriteLine("İki sayının Çarpması {0} dır", (sayi1 * sayi2));
                    break;
                case "/":
                    Console.WriteLine("İki sayının Bölmesi {0} dır", (sayi1 / sayi2));
                    break;
                default:
                    break;
            }
            Console.ReadLine();



        }
    }
}


