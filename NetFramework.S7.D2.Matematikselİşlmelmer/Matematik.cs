using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.Matematikselİşlmelmer
{
    public class Matematik
    {
        // topla metodu
        public decimal toplamaislemi( decimal sayi1 , decimal sayi2) // geriye değer döndüreceği için decimal
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        // Çıkarma 
        public decimal cıkarmaislemi(decimal sayi1 , decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;   
        }

        // bölme
        public decimal bölmeislemi(decimal sayi1 , decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }
        // çarpma

        public decimal carpmaislemi(decimal sayi1 , decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public void MenuHazır()
        {
            Console.Clear();
            Console.WriteLine("****** Menü: *****");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3 - Bölme");
            Console.WriteLine("4- Çarpma");
            Console.Write("Lütfen Değer Seçiniz : ");
            

        }
        public void islemiekranayazdır(decimal sayi1 , decimal sayi2, decimal sonuc , string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}",sayi1,operators , sayi2,sonuc);

        }
    }
}
