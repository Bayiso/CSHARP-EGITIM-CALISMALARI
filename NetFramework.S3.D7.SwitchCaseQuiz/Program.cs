    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D7.SwitchCaseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadLine();
        }
    }
}
