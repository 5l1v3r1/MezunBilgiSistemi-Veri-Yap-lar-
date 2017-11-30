using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class Staj_Bilgisi:Bolum_Bilgi
    {
        public string SirketAdi { get; set; }
        public DateTime StajTarihi { get; set; }
        public string Departman { get; set; }
    }
}
