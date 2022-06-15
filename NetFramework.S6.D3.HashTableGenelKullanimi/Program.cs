using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D3.HashTableGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            #region Yeni Değer ekleme

            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");

            H1.Add("Cars", "Araba");
            //H1.Add("Cars", "Arabalar");
            // H1.Add("Cars", "Arabalar"); Key değeri benzersiz olmak zorundadır.


            #endregion

            #region Yardımcı metotlar 
            bool Kontrol1 = H1.Contains("House"); // objecten key istıor
            bool Kontrol2 = H1.Contains("Door");

            bool Kontrol3 = H1.ContainsKey("House"); //Caontains ile aynı işlemi yapar
            bool Kontrol4 = H1.ContainsValue("Araba"); // vaule üzerinde işlem yapabilioruz yani value kısmında arayabilior

            H1["House"] = "Villa"; // datayı düzenlemek istersem  böle yazarım

            H1.Remove("Cars"); // içerisinde bir key almakta , vermiş old keyi silior
            int koleksiyonIcindekiToplamDeger = H1.Count;
            H1.Clear(); // koleksiyon içerisindeki tüm datayı temizleriz.



            #endregion
        }
    }
}
