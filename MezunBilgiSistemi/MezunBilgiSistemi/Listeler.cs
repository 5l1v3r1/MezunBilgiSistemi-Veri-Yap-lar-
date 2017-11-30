using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public static class Listeler
    {
        public static Heap heap = new Heap(10);
        public static HashMapChain hmc = new HashMapChain();
        public static List<Sirket> Sirketler = new List<Sirket>();
        public static İkiliAramaAgaci mezun_ogrenciler = new İkiliAramaAgaci();
        public static List<Ogrenci_Bilgi> Ogrenciler = new List<Ogrenci_Bilgi>();
        public static List<Bolum_Bilgi> Bolumler = new List<Bolum_Bilgi>();
    }
}
