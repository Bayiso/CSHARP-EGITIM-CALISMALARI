using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S2.D3.MantıksalOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * && :ve operatoru
             * || :veya operatoru
             * 
             * 
            */
            
            int sayi1 = 10;
            int sayi2 = 20;
            int sayi3 = 15;
            #region Ve && operator tanım
            bool veoperatorusonuc = sayi1 > sayi2 && sayi1 < sayi3;

            #endregion
            #region  VEYA || operatoru
            bool veyaoperatorusonuc = sayi3 < sayi3 || sayi1 > sayi2;


            #endregion

        }
    }
}
