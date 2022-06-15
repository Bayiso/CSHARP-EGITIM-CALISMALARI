using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D6.StackGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack(); // son giren ilk çıkar
            s1.Push("1");
            s1.Push("2");
            s1.Push("3");
            s1.Push("4");
            // en son giren en önce çıkıor
            object o1 = s1.Pop(); // bir komutta datayı gönderio ve kendisinden remove etti yani çıkardı sildi
            object o2 = s1.Peek(); // datayı gönderio ama kendisinden çıkarmıor ,




        }
    }
}
