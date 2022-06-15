using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeNedir
{
    internal class Musteri
    {
        public Musteri()
        {
            this.id =IDUret();
        }
        int id;
        public int ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }
        public string isim;
        public string soyisim;
        private string emailadresi;
        //public string EmailAdres
        //{
        //    //get; // database veya farklı bir veri kaynağı ,, class çağıran programcıyadatayı gösterdiğimiz kısımdır
        //    //set; // dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı kısım

        //    set
        //    {
        //        this.emailadresi = value;
        //    }
        //    get
        //    {
        //        return this.emailadresi;
        //    }
        
        
        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(5000, 90000);
            

        }


        }
        

    }
}
