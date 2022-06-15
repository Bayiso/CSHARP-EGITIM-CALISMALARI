using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace NetFramework.S6.D1.ArrayListeler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  10 elemanlı string listesini içindeki değerlerini (Z-A) şekleinde sıralayın


            ArrayList ödev1 = new ArrayList();
            ödev1.Add("merhaba");
            ödev1.Add("ben");
            ödev1.Add("barış");
            ödev1.Add("caylan");
            ödev1.Add("hayat");
            ödev1.Add("nasıl");
            ödev1.Add("gidior");
            ödev1.Add("yigido");
            ödev1.Add("sevion bu hayatı");
            ödev1.Add("her biji");
            ödev1.Sort();
            ödev1.Reverse();
            Console.WriteLine(ödev1);
            // adım 1 tüm değerleri a dan z e çevir









            #endregion


            #region 10 elemanlı ( string ) Arraylist içindeki değerleri Z-A olacak şekilde sıralayın 
            ArrayList OdevListe = new ArrayList();
            OdevListe.Add("Zeynep");
            OdevListe.Add("Özgür");
            OdevListe.Add("Yakup");
            OdevListe.Add("Ayşegül");
            OdevListe.Add("Hakan");
            OdevListe.Add("Cengiz");
            OdevListe.Add("Mustafa");
            OdevListe.Add("Lale");
            OdevListe.Add("Gökhan");
            OdevListe.Add("Selim");
            OdevListe.Add("Nilüfer");

            // Adım 1 : Tüm değerleri A-Z çevir. 
            OdevListe.Sort();
            OdevListe.Reverse();

            #endregion

            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            ArrayList A1 = new ArrayList();

            #region Tek Değer ekleme 
            A1.Add("Cengiz ATİLLA");

            Capacity = A1.Capacity;
            Count = A1.Count;

            A1.Add(100);
            #endregion

            #region Birden fazla değer ekleme işlemi. 
            ArrayList A2 = new ArrayList();
            A2.Add("Yakup");
            A2.Add("Merve");
            A2.Add("Utkan");
            A1.AddRange(A2);
            #endregion

            #region Capacity & Count İnceleme
            Capacity = A1.Capacity;
            Count = A1.Count;
            #endregion

            #region Koleksiyon içindeki değere ulaşmak 
            object O1 = A1[3];
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];

            A1[3] = "Hamza Atilla";
            #endregion

            #region ArrayList Sıralama 

            // Dizinin mevcut elemanlarını ters olarak sıralama 
            A1.Remove(100); // 100 u sil liste içindeki
            A1.Reverse(); // tam tersi olarak sıralacak
            // A-Z Sıralama 
            A1.Sort(); //Alfabetik değere göre sıraladı

            #endregion

            #region Koleksiyonlar yardımcı komutları 

            if (A1.Contains("Yakup")) 
            {
                int IndexDegeri = A1.IndexOf("Yakup"); // a1 içinde yakup değeri varsa tru döner işlem yapar siler
                A1.RemoveAt(IndexDegeri);
            }

            int İndexdegeri = A1.IndexOf("Yakup"); // indeks değerini veropr // RemoveAT ile sonra silebiliriz
            bool Kontrol1 = A1.Contains("Utkan"); // ilgili kolek siçinde değerimizin olup olmadığına bakar bulursa true gelir bulmazsa Flase geri döner bool
            bool Kontrol2 = A1.Contains(900); // ilgili  değer içinde bulunmadığı için false dior ha


            object[] D1 = A1.ToArray(); // ilgili değerlerimizin hepsini diziye çevirior

            A1.Clear(); // içinde ne varsa siler // countu tek 0 yapar
            A1.TrimToSize(); // ilgili koleksiyonun kapasitesini gene ayarla 0 yap onuda 

            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme

            A1.RemoveAt(3); // 3. indeksi sil
            A1.RemoveRange(2, 2); // ikinci indeksten sonra ki iki indeksi sil
            A1.Remove("Hamza Atilla"); // direk sil 

            #endregion
            
            





        }
    }
}
