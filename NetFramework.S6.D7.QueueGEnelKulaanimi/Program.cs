using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D7.QueueGEnelKulaanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue(); // ilk giren ilk çıkar

            q1.Enqueue("1");
            q1.Enqueue("2");
            q1.Enqueue("3"); // değer ekler
            q1.Enqueue("4");
            object o1 = q1.Peek(); // içeride bir değer silinmesi olmadı
            object o2 = q1.Dequeue(); // bana değeri attıktan sonra koleksion içerisinden siler 



        }
    }
}
