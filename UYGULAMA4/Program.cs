using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UYGULAMA4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ödev4 uygulama1
            // 10 elemanlı bir dizinin elemanlarını teker teker klavyeden giren daha sonra dizinin tüm elemanlarını
            //tersten yazdıran ve son olarak dizinin herhangi bir pozisyondaki elemanını gösteren programı yazınız.
            int[] dizim = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. elemanı girin",i);
                int girileneleman = Convert.ToInt32(Console.ReadLine());
                dizim[i] = girileneleman;

            }
            Console.WriteLine("Kaçıncı elemanı görmek istiyorsunuz.");
            int görmekisteneneleman = Convert.ToInt32(Console.ReadLine());
            switch (görmekisteneneleman)
            {
                case 1:
                    Console.WriteLine("1. elemanı {0} dır", dizim[0] );
                    break;
                case 2:
                    Console.WriteLine("2. elemanı {0} dır", dizim[1]);
                    break;
                case 3:
                    Console.WriteLine("3. elemanı {0} dır", dizim[2]);
                    break;
                case 4:
                    Console.WriteLine("4. elemanı {0} dır", dizim[3]);
                    break;
                case 5:
                    Console.WriteLine("5. elemanı {0} dır", dizim[4]);
                    break;
                case 6:
                    Console.WriteLine("6. elemanı {0} dır", dizim[5]);
                    break;
                case 7:
                    Console.WriteLine("7. elemanı {0} dır", dizim[6]);
                    break;
                case 8:
                    Console.WriteLine("8. elemanı {0} dır", dizim[7]);
                    break;
                case 9:
                    Console.WriteLine("9. elemanı {0} dır", dizim[8]);
                    break;
                case 10:
                    Console.WriteLine("10. elemanı {0} dır", dizim[9]);
                    break;
                default:
                    break;
            }
            Console.ReadLine();

            #endregion
            #region ödev4 uygulama2
            //Verilen iki matrisin çarpımını bulan programı yazınız.
            int[,] A = { { 1, 0, 2 }, { -1, 3, 1 } };
            int[,] B = { { 3, 1 }, { 2, 1 }, { 1, 0 } };
            int[,] C = new int[A.GetUpperBound(0) + 1, B.GetUpperBound(1) + 1];

            // A nın satır sayısı kadar
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                // B nin sütun sayısı kadar
                for (int j = 0; j <= B.GetUpperBound(1); j++)
                {
                    int toplam = 0;
                    // A nın sütun sayısı kadar
                    // (ya da B nin satır sayısı)
                    for (int k = 0; k <= A.GetUpperBound(1); k++)
                    {
                        toplam += A[i, k] * B[k, j];
                    }
                    C[i, j] = toplam;
                }
            }

            #endregion
            #region ödev4 uygulama3
            int pozitif = 0;
            int negatif = 0;
            int notr = 0;
            Random rnd = new Random();

            int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = rnd.Next(-100, 100);
            }

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
                if (sayi > 0)
                {
                    pozitif++;
                }
                else if (sayi < 0)
                {
                    negatif++;
                }
                else
                {
                    notr++;
                }
            }
            Console.WriteLine("Pozitif Sayı Adeti>>> " + pozitif);
            Console.WriteLine("Negatif Sayı Adeti>>> " + negatif);
            Console.WriteLine("İşaretsiz Sayı Adeti>>> " + notr);
            #endregion




        }
    }
}
