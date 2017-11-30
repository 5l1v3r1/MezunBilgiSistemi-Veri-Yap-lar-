using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class Bolum_Bilgi
    {
        public int BolumNo { get; set; }
        public string BolumAdi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double NotOrtalamasi { get; set; }
        public bool BasariBelgesi { get; set; }
         public List<Ogrenci_Bilgi> ogrnumaralari { get; set; }
        public Bolum_Bilgi()
        {
            this.ogrnumaralari = new List<Ogrenci_Bilgi>();
        }
        
       
    }
}
