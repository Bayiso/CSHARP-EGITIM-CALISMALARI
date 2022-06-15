using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D6.ParseveConvertFark
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "250";
            string text2 = null;

            int sayi1 = -1;
            int sai2 = -1;

            // Convert kullanımı
            sayi1 = Convert.ToInt32(text1);
            sai2 = Convert.ToInt32(text2); // nulu 0 yapar

            // parse kullanımı

            sayi1 = int.Parse(text1);
            sai2 = int.Parse(text2); // null da hata verir
       




        }
    }
}
