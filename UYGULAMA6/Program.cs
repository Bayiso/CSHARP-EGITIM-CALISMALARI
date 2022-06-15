using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UYGULAMA6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 haneli cep telefonu numaranızı girin başında 0 olmadan");
            int numara = Convert.ToInt64(Console.ReadLine());
            ArrayList girilennumara = new ArrayList();
            girilennumara.Add(numara);
            Console.WriteLine(girilennumara);
            Console.ReadLine();
        }
    }
}
