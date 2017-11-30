using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class HashMapChain
    {
        int size = 100;
        private string mesaj = "";
        LinkedListHashEnty[] table;
        private Bolum_Bilgi Bbilgi;

        Heap h;
        public HashMapChain()
        {
            h = new Heap(100);
            Bbilgi = new Bolum_Bilgi();

            table = new LinkedListHashEnty[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }
        public string HeapEkle(int key, Heap value, Bolum_Bilgi bvalue)
        {

            int hash = key % size;

            if (table[hash] == null)
            {
                table[hash] = new LinkedListHashEnty(key, value, bvalue);
                return "true";
            }

            else
            {
                LinkedListHashEnty entry = table[hash];
                while (entry.Next != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry.Anahtar == key)
                {
                    entry.HValue = value;
                    entry.BValue = bvalue;
                }
                else
                    entry.Next = new LinkedListHashEnty(key, value, bvalue);
                return "true";
            }

        }
        public void BolumEkle(Bolum_Bilgi b)
        {
            Staj_Bilgisi s = new Staj_Bilgisi();        
            int hash = b.BolumNo % size;
            //table[hash].HDeger = new Heap(100);
            LinkedListHashEnty ll = new LinkedListHashEnty(b.BolumNo, new Heap(100), s);
            if (table[hash] == null)
            {
                table[hash] = ll;
            }
            else
            {
                while (table[hash] != null)
                {
                    table[hash] = table[hash].Next;
                }
                table[hash] = ll;
            }
        }
        public void BolumeOgrenciEkle(Bolum_Bilgi b, Ogrenci_Bilgi o)
        {

            int hash = b.BolumNo % size;
            if (table[hash] != null)
            {
                while (table[hash] != null && table[hash].Anahtar != b.BolumNo)
                    table[hash] = table[hash].Next;
            }
            if (table[hash].Anahtar == b.BolumNo)
            {
                bool durum;
                durum = table[hash].HValue.Ogrenci(o.OgrenciNumarasi);

                if (durum == false)
                {
                    table[hash].HValue.Insert(o);
                }
            }
        }
        public string BolumdekiOgrencileriGoster(Ogrenci_Bilgi o)
        {
            string temp = "";
            int hash = o.BolumNo % size;
            if (table[hash] == null)
                return null;
            else
            {
                while (table[hash] != null && table[hash].Anahtar != o.BolumNo)
                {
                    table[hash] = table[hash].Next;
                }
                if (table[hash].Anahtar == o.BolumNo)
                {
                    temp = table[hash].HValue.HeapGörüntüle();
                }
            }
            return temp;
        }
        public string BolumGuncelle(Bolum_Bilgi b)
        {
            bool durum = false;
            bool kontrol = false;
            for (int i = 0; i < 100; i++)
            {
                if (table[i] != null)
                {
                    durum = true;
                    kontrol = Bguncelle(i, b);
                    if (kontrol == true)
                    {
                        return kontrol.ToString();
                    }
                }
                else
                {
                    durum = false;
                }
            }
            if (durum == false)
            {
                for (int i = 0; i < Listeler.Bolumler.Count; i++)
                {
                    if (Listeler.Bolumler[i].BolumAdi == b.BolumAdi)
                    {
                        Listeler.Bolumler[i] = b;
                        return "Bolum bilgileri başarıyla güncellendi.";
                    }
                }
            }
            return "Sistemde böyle bolum  bulunmamaktadır.";
        }

        public bool Bguncelle(int i, Bolum_Bilgi b)
        {
            if (table[i].BValue.BolumAdi == b.BolumAdi)
            {
                table[i].BValue = b;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Guncelle(Ogrenci_Bilgi b)
        {
            bool durum = false;
            for (int i = 0; i < 100; i++)
            {
                if (table[i] != null)
                {
                    durum = true;
                    table[i].HValue.KisiGuncelle(b);

                }
                else
                {

                    durum = false;
                }
            }


            if (durum == false)
            {
                for (int i = 0; i < Listeler.Ogrenciler.Count; i++)
                {
                    if (Listeler.Ogrenciler[i].OgrenciNumarasi == b.OgrenciNumarasi)
                    {
                        Listeler.Ogrenciler[i] = b;

                        durum = true;
                    }
                }
            }
        }

        public string OgrenciSil(Ogrenci_Bilgi o)
        {
            if (Listeler.Ogrenciler.Remove(Listeler.Ogrenciler[Listeler.Ogrenciler.Count - 1]) == true)
                return "Başarılı";
            else
                return "Başarısız";
        }
    }
}
