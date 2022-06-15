using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D5.IFElseIfQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı gir:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı gir:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bu sayılarla hangi işlemi yapmak istiyorsun");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-çıkarma");
            Console.WriteLine("3-çarpma");
            Console.WriteLine("4-Bölme");
            int toplama = sayi1 + sayi2;
            int çıkarma = sayi1 - sayi2;
            int çarpma = sayi1 * sayi2;
            int bölme = sayi1 / sayi2;
            Console.WriteLine("seçmek istediğinz işleminiz gerçekleştirilior");
            int kullanıcınisteği = Convert.ToInt32(Console.ReadLine());
            if (kullanıcınisteği == 1) Console.WriteLine("seçmiş olduğunuz işlem: Toplama {0}", toplama);
            else if (kullanıcınisteği == 2) Console.WriteLine("seçmiş olduğunuz işlem: Çıkarma {0}", çıkarma);
            else if (kullanıcınisteği == 3) Console.WriteLine("seçmiş olduğunuz işlem: Çarpma {0}", çarpma);
            else if (kullanıcınisteği == 4) Console.WriteLine("seçmiş olduğunuz işlem: Bölme {0}", bölme);

            Console.ReadLine();

        }
    }
}
