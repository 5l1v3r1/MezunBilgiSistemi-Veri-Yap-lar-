using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MezunBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci_Bilgi z = new Ogrenci_Bilgi();
        
        İkiliAramaAgaci dugum = new İkiliAramaAgaci();
        LinkedList list = new LinkedList();

        private void Form1_Load(object sender, EventArgs e)
        {

            
            Bolum_Bilgi b = new Bolum_Bilgi();
            b.BolumAdi = "Yazılım";
            b.BolumNo = 0;
            Listeler.Bolumler.Add(b);

            Ogrenci_Bilgi o = new Ogrenci_Bilgi();
            o.Bolum.AddFirst(b);
            o.Ad = "Selim";
            o.OgrenciNumarasi = "1236";
            o.Adres = "Konya";
            o.BolumNo = 0;
            o.BolumAdi = "Yazılım";
            o.DogumTarihi = Convert.ToDateTime("30.09.1997");
            o.Uyruk = "Türk";
            o.İlgiAlani = "Bisiklet Sürmek";
            o.Eposta = "slmalkn.97@gmail.com";
            o.BasariBelgesi = true;
            o.YabanciDil = "İngilizce";
            o.Telefon = 035825387;
            list.InsertLast(o);
            Listeler.Bolumler[0].ogrnumaralari.Add(o);
            Listeler.mezun_ogrenciler.Ekle(o);
            Listeler.Ogrenciler.Add(o);
            dugum.Ekle(o);
            
            

            Bolum_Bilgi c = new Bolum_Bilgi();
            Ogrenci_Bilgi a = new Ogrenci_Bilgi();
            c.BolumAdi = "Mekatronik";
            c.BolumNo = 1;
            Listeler.Bolumler.Add(c);
            a.Ad = "Enes";
            a.OgrenciNumarasi = "1235";
            a.Adres = "Balıkesir";
            a.BolumNo = 1;
            a.BolumAdi = "Mekatronik";
            a.Uyruk = "Türk";
            a.DogumTarihi = Convert.ToDateTime("13.02.1997");
            a.İlgiAlani = "Uyumak";
            a.Eposta = "enessert4658@gmail.com";
            a.NotOrtalamasi = 70;
            a.BasariBelgesi = false;
            a.YabanciDil = "İngilizce";
            a.Telefon = 05334534676;
            a.Bolum.AddFirst(c);
            Listeler.mezun_ogrenciler.Ekle(a);
            Listeler.Ogrenciler.Add(a);
            Listeler.Bolumler[1].ogrnumaralari.Add(a);
            dugum.Ekle(a);
            list.InsertLast(a);
            

            Bolum_Bilgi r = new Bolum_Bilgi();
            r.NotOrtalamasi = 91;
            r.BolumAdi = "Enerji Sistemleri";
            r.BolumNo = 2;
            Listeler.Bolumler.Add(r);
            Ogrenci_Bilgi q = new Ogrenci_Bilgi();
            q.Ad = "Ümit";
            q.OgrenciNumarasi = "1234";
            q.Adres = "Karaman";
            r.BolumNo = 2;
            q.Uyruk = "İngiliz";
            q.BolumAdi = "Enerji Sistemleri";
            q.DogumTarihi = Convert.ToDateTime("30.06.1997");
            q.İlgiAlani = "Evet de";
            q.Eposta = "artıdokuzmu@gmail.com";
            q.BasariBelgesi = false;
            q.YabanciDil = "Bütün diller";
            q.Telefon = 05334525;
            list.InsertLast(q);
            q.Bolum.AddFirst(r);
            Listeler.mezun_ogrenciler.Ekle(q);
            Listeler.Ogrenciler.Add(q);
            Listeler.Bolumler[2].ogrnumaralari.Add(q);
            
            dugum.Ekle(q);
            
           
            
          
        }

        private void tabEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Bolum_Bilgi k = new Bolum_Bilgi();
            
            k.BolumAdi =comboBolum.Text;
            
            z.Ad = txtAd.Text;
            z.Adres = txtAdres.Text;
            z.Telefon = long.Parse(txtTelefon.Text);
            z.Eposta = txtEposta.Text;
            z.Uyruk = txtUyruk.Text;
            if(comboBolum.Text=="Yazılım")
                k.BolumNo = 0;
            else if(comboBolum.Text == "Mekatronik")
                k.BolumNo = 1;
            else if (comboBolum.Text == "Enerji Sistemleri")
                k.BolumNo = 2;
            else if (comboBolum.Text == "Makine")
                k.BolumNo = 3;
            z.DogumTarihi = dateTimePicker1.Value;
            z.OgrenciNumarasi = txtOgrenciNo.Text;
            z.İlgiAlani = txtIlgi.Text;
            z.YabanciDil = txtDil.Text;
            z.Bolum.AddFirst(k);
            list.InsertLast(z);
            Listeler.mezun_ogrenciler.Ekle(z);
            Listeler.Ogrenciler.Add(z);
            dugum.Ekle(z);
            Listeler.Bolumler[comboBolum.SelectedIndex].ogrnumaralari.Add(z);
            MessageBox.Show("Yeni kişi başarılı bir şekilde eklendi");


            bool durum;
            int i1 = 0, i2 = 0;
            if (comboBolum.Text == "")
            {
                MessageBox.Show("lütfen bir bolum seçiniz");
            }
            else if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("lütfen bir öğrenci numarası giriniz");
            }
            else
            {
                durum = false;
                for (int i = 0; i < Listeler.Bolumler.Count; i++)
                {
                    if (comboBolum.Text == Listeler.Bolumler[i].BolumAdi)
                    {
                        for (int j = 0; j < Listeler.Bolumler[i].ogrnumaralari.Count; j++)
                        {
                            if (txtOgrenciNo.Text == Listeler.Bolumler[i].ogrnumaralari[j].OgrenciNumarasi)
                            {
                                durum = true;
                                i1 = i;
                                i2 = j;
                                break;
                            }
                        }
                    }
                }
                if (durum == true)
                {
                    Listeler.hmc.BolumeOgrenciEkle(Listeler.Bolumler[i1].ogrnumaralari[i2], Listeler.Ogrenciler[Listeler.Ogrenciler.Count - 1]);
                    MessageBox.Show("İlana başvuru başarılı");
                    MessageBox.Show(Listeler.hmc.BolumdekiOgrencileriGoster( Listeler.Bolumler[i1].ogrnumaralari[i2]));
                }
            }
                
        }

        private void btnIngilizce_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Listeler.mezun_ogrenciler.IngilizceBilenleriListele());
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Listeler.mezun_ogrenciler.Notu90UstuOlanlariListele());
        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            Listeler.mezun_ogrenciler.PostOrder();
            MessageBox.Show("PostOrder'a Göre Sıralama\n" + Listeler.mezun_ogrenciler.DugumleriYazdir());
            Listeler.mezun_ogrenciler.InOrder();
            MessageBox.Show("InOrder'a Göre Sıralama\n" + Listeler.mezun_ogrenciler.DugumleriYazdir());
            Listeler.mezun_ogrenciler.PreOrder();
            MessageBox.Show("PreOrder'a Göre Sıralama\n" + Listeler.mezun_ogrenciler.DugumleriYazdir());
            
        }

        private void btnOgrenciSayi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Listeler.mezun_ogrenciler.DugumSayisi().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Listeler.mezun_ogrenciler.NumarayaGoreListele(Convert.ToString(txtArama.Text)));
        }       

        private void tabAgac_Click(object sender, EventArgs e)
        {

        }

        private void btnBolumBilgi_Click(object sender, EventArgs e)
        {
            Bolum_Bilgi bb = new Bolum_Bilgi();
            bb.BolumAdi = comboBolum.Text;
            if (comboBolum.SelectedIndex == 0)
                bb.BolumNo = 0;
            else if (comboBolum.SelectedIndex == 1)
                bb.BolumNo = 1;
            else if (comboBolum.SelectedIndex == 2)
                bb.BolumNo = 2;
            else if (comboBolum.SelectedIndex == 3)
                bb.BolumNo = 3;
            bb.BaslangicTarihi = dateTimePicker2.Value;
            bb.BitisTarihi = dateTimePicker3.Value;
            bb.NotOrtalamasi = double.Parse(txtNot.Text);
            if (radioTrue.Checked)
                bb.BasariBelgesi = true;
            else if (radioFalse.Checked)
                bb.BasariBelgesi = false;
            
            z.Bolum.AddFirst(bb);
            txtNot.Clear();
        }

        private void btnStajBilgi_Click(object sender, EventArgs e)
        {
            Staj_Bilgisi sb = new Staj_Bilgisi();
            sb.SirketAdi = txtSirket.Text; ;
            sb.StajTarihi =dateTimePicker4.Value;
            sb.Departman = txtDepartman.Text;
            z.StajYerleri.AddFirst(sb);
            txtSirket.Clear();
            txtDepartman.Clear();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            z.Ad = txtAd.Text;
            z.Adres = txtAdres.Text;
            z.Telefon = long.Parse(txtTelefon.Text);
            z.Eposta = txtEposta.Text;
            z.Uyruk = txtUyruk.Text;
            z.DogumTarihi = dateTimePicker1.Value;
            z.OgrenciNumarasi = txtOgrenciNo.Text;
            z.İlgiAlani = txtIlgi.Text;
            z.YabanciDil = txtDil.Text;

            Listeler.hmc.Guncelle(z);
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Listeler.hmc.OgrenciSil(Listeler.Ogrenciler[Listeler.Ogrenciler.Count - 1]));
            txtAd.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtUyruk.Clear();
            txtOgrenciNo.Clear();
            txtDil.Clear();
            txtIlgi.Clear();
           
        }
        Sirket sirket = new Sirket();
        private void btnSirketEkle_Click(object sender, EventArgs e)
        {
            sirket.IsyeriAdi = txtSirketAdi .Text;
            sirket.IsyeriAdresi = txtSirketAdres.Text;
            sirket.IsyeriTelNo = long.Parse(txtSirketTel.Text);
            sirket.IsyeriFaks = txtSirketFaks.Text;
            sirket.IsyeriEposta = txtEposta.Text;

            Listeler.Sirketler.Add(sirket);
            MessageBox.Show("Şirket ekleme işlemi başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show(Listeler.mezun_ogrenciler.BolumeGoreListele(Convert.ToString(txtListele.Text)));
            
           
           
        }
    }
}
