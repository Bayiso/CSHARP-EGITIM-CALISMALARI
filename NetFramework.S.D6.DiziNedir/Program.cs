using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S.D6.DiziNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] öğrenciisimlistesi = new string[5]; // 5 elemanlı olucak
            öğrenciisimlistesi[0] = "Barışo CEYLAN ";
            öğrenciisimlistesi[1] = "heciko  demiro";
            öğrenciisimlistesi[2] = "özgüro kurgayo";
            öğrenciisimlistesi[3] = "zeynep bastik";
            öğrenciisimlistesi[4] = "berçem canım";



            //Console.WriteLine(öğrenciisimlistesi[1]); // böle yazılır işte

            #region oluşturmul old dizimizin  içerisindeki  elemanları ekrana yazdılarım
            foreach (string item in öğrenciisimlistesi)
            {
                Console.WriteLine(item);
            }
            Console.Clear();
            #endregion

            #region for ile dizinin elemanşarını gezmek
            for (int i = 0; i <öğrenciisimlistesi.Length; i++)
            {
                string gelenisimler = öğrenciisimlistesi[i];
                Console.WriteLine(gelenisimler);

            }
            Console.Clear();

            #endregion




        }
    }
}
