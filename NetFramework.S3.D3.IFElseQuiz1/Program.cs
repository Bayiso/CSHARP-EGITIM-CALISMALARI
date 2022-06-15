using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D3.IFElseQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. notunuzu giriniz.");
            int birincinot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. notunuzu giriniz.");
            int ikincinot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. notunuzu giriniz.");
            int ucuncunot = Convert.ToInt32(Console.ReadLine());
            int işlem = (birincinot + ikincinot + ucuncunot) / 3;
            if (işlem >= 50) Console.WriteLine("GEçtiniz");
            else Console.WriteLine("kaldınız");
            Console.ReadLine();
        }
    }
}
