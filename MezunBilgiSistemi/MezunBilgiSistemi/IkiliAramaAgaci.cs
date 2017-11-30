using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
   public class İkiliAramaAgaci
    {
       private İkiliAramaAgacDugumu kok;
        private int ogrNo = 000;
        private int i = 0;
        private string dugumler;
        public İkiliAramaAgaci()
        {
        }
        public İkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            int d = 0;
            string mesaj = "";
            foreach (var k in dugum.veri.StajYerleri)
            {
                if (d == i)
                {
                    mesaj = k.SirketAdi;
                }
                d++;
            }

            dugumler += dugum.veri.Ad + " " + mesaj;
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        private void BuyuktenKucugeInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            BuyuktenKucugeInt(dugum.sag);
            Ziyaret(dugum);
            BuyuktenKucugeInt(dugum.sol);
        }
        public void BuyuktenKucuge()
        {
            dugumler = "";
            BuyuktenKucugeInt(kok);
        }

        public void Ekle(Ogrenci_Bilgi deger)
        {
           
            İkiliAramaAgacDugumu tempParent = null;
           
            İkiliAramaAgacDugumu tempSearch = kok;
           

            int sayi = 0;
            while (tempSearch != null)
            {
                tempParent = tempSearch;
                
                sayi = string.Compare(tempSearch.veri.OgrenciNumarasi, deger.OgrenciNumarasi);

                if (sayi == 0)
                    return;
                else if (sayi > 0)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            } 
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger);
            
            if (kok == null)
                kok = eklenecek;
            else if (sayi > 0)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;

            
        }

        public İkiliAramaAgacDugumu MinDeger()
        {
            İkiliAramaAgacDugumu tempSol = kok;
            while (tempSol.sol != null)
                tempSol = tempSol.sol;
            return tempSol;
        }
        string temp = "";
        
        public string NumarayaGoreListele(string No)
        {
            temp = "";
            NumarayaGoreListeleInt(this.kok, No);
            return temp;
        }
        public string BolumeGoreListele(string BolumAd)
        {
            temp = "";
            BolumeGoreListeleInt(this.kok, BolumAd);
            return temp;
        }
        private void IsimYaz(İkiliAramaAgacDugumu dugum)
        {
         
           
                temp += dugum.veri.Ad + Environment.NewLine +
                        dugum.veri.OgrenciNumarasi + Environment.NewLine +
                        dugum.veri.YabanciDil + Environment.NewLine +
                        dugum.veri.Adres + Environment.NewLine +
                        dugum.veri.DogumTarihi.ToShortDateString() + Environment.NewLine +
                        dugum.veri.Eposta + Environment.NewLine +
                        dugum.veri.Telefon.ToString() + Environment.NewLine +
                        dugum.veri.Uyruk + Environment.NewLine +
                        dugum.veri.İlgiAlani + Environment.NewLine;
            
        
        }
        private string NumarayaGoreListeleInt(İkiliAramaAgacDugumu dugum, string No)
        {
             int sayi = 0;
            sayi = string.Compare(dugum.veri.OgrenciNumarasi, No);
            bool deger = false;
            if (dugum == null)
                return "";
            if (sayi == 0)
            {
                IsimYaz(dugum);
                deger = true;
                return temp;
            }
            if (sayi > 0)
            {
                NumarayaGoreListeleInt(dugum.sol, No);
            }
            else if (sayi < 0)
            {
                NumarayaGoreListeleInt(dugum.sag, No);
            }
            return temp;
        }
        private string BolumeGoreListeleInt(İkiliAramaAgacDugumu dugum, string BolumAd)
        {
            int sayi = 0;
            sayi = string.Compare(dugum.veri.BolumAdi,BolumAd);
            bool deger = false;
            if (dugum == null)
                return "";
            if (sayi == 0)
            {
                IsimYaz(dugum);
                deger = true;
                return temp;
            }
            if (sayi > 0)
            {
                BolumeGoreListeleInt(dugum.sol, BolumAd);
            }
            else if (sayi < 0)
            {
                BolumeGoreListeleInt(dugum.sag, BolumAd);
            }
            return temp;
        }
        public string Notu90UstuOlanlariListele()
        {
            temp = "";
            Notu90UstuOlanlariListeleInt(this.kok);
            return temp;
        }
        private void Not90UstuIsimYaz(İkiliAramaAgacDugumu dugum)
        {
            temp += dugum.veri.Ad + Environment.NewLine;
        }
        private void Notu90UstuOlanlariListeleInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            if (dugum.veri.Bolum != null)
            {
                if (dugum.veri.Bolum.First != null)
                {
                    foreach (Bolum_Bilgi bb in dugum.veri.Bolum)
                    {
                        if (bb.NotOrtalamasi >= 90)
                            Not90UstuIsimYaz(dugum);
                    }
                }
            }
            Notu90UstuOlanlariListeleInt(dugum.sol);
            Notu90UstuOlanlariListeleInt(dugum.sag);
        }
        public string IngilizceBilenleriListele()
        {
            temp = "";
            IngilizceBilenleriListeleInt(this.kok);
            return temp;
        }
        private void IngilizceBilenlerinIsminiYaz(İkiliAramaAgacDugumu dugum)
        {
            temp += dugum.veri.Ad + Environment.NewLine;
        }
        private void IngilizceBilenleriListeleInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            if (dugum != null)
            {
                if (string.Compare(dugum.veri.YabanciDil, "İngilizce") == 0)
                    IngilizceBilenlerinIsminiYaz(dugum);
            }
            IngilizceBilenleriListeleInt(dugum.sol);
            IngilizceBilenleriListeleInt(dugum.sag);
        }
    }
}
