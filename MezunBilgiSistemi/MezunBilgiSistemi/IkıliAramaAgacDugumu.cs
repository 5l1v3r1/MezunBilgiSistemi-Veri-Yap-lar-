using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
   public class İkiliAramaAgacDugumu
    {
        public Ogrenci_Bilgi veri;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
       
        
        public İkiliAramaAgacDugumu()
        { 
        }

        public İkiliAramaAgacDugumu(Ogrenci_Bilgi veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}
