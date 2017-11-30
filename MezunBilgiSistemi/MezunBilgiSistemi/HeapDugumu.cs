using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class HeapDugumu
    {
        public Ogrenci_Bilgi ogr { get; set; }
        public double deger { get; set; }
        private static Random r = new Random();
        public HeapDugumu(Ogrenci_Bilgi ogr)
        {
            this.ogr = ogr;
            this.deger = r.NextDouble() * 10d;
        }
    }
}
