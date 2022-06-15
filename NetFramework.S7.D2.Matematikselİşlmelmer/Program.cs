using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.Matematikselİşlmelmer
{
    class Program
    {
        static void Main(string[] args)
        {
            İşelemeDevamEt:
            decimal sonuc = 0;
            Matematik m = new Matematik();
            m.MenuHazır();
            decimal secilenislem = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("1. sayıyı gir : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("2. sayıyı gir");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            switch (secilenislem)
            {
                case 1:
                    sonuc = m.toplamaislemi(sayi1, sayi2);
                    m.islemiekranayazdır(sayi1, sayi2, sonuc, "+");

                    break;
                case 2:
                    sonuc = m.cıkarmaislemi(sayi1, sayi2);
                    m.islemiekranayazdır(sayi1, sayi2, sonuc, "-");

                    break;
                case 3:
                    sonuc = m.bölmeislemi(sayi1, sayi2);
                    m.islemiekranayazdır(sayi1, sayi2, sonuc, "/");

                    break;
                case 4:
                    sonuc = m.carpmaislemi(sayi1, sayi2);
                    m.islemiekranayazdır(sayi1, sayi2, sonuc, "*");

                    break;
                default:
                    goto İşelemeDevamEt;
            }
            Console.WriteLine("Başka İşlem Yapmak İstopr musun ? [E/H]");
            string eh = Console.ReadLine();
            if (eh == "E")
            {
                goto İşelemeDevamEt;
            }
        }
    }
}
