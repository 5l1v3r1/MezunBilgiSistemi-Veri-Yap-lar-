using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class Ogrenci_Bilgi:Staj_Bilgisi
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public long Telefon { get; set; }
        public string Eposta { get; set; }
        public string Uyruk { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string OgrenciNumarasi { get; set; }
        public string YabanciDil { get; set; }
        public string İlgiAlani { get; set; }
        public LinkedList<Staj_Bilgisi> StajYerleri { get; set; }
        public LinkedList<Bolum_Bilgi> Bolum { get; set; }
        public Ogrenci_Bilgi()
        {
            StajYerleri = new LinkedList<Staj_Bilgisi>();
            Bolum = new LinkedList<Bolum_Bilgi>();
        }
    }
}
