using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolSystem
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        schoolSystemDBEntities7 db = new schoolSystemDBEntities7();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            toplamOgrenci.Text = db.Ogrenciler.Count().ToString();

            toplamOgretmen.Text = db.Ogretmenler.Count().ToString();

            toplamSinif.Text = db.Siniflar.Count().ToString();

            var en_kalabalik_sinif = db.Ogrenciler
                .GroupBy(o => o.sinif_id) // Öğrencileri SinifId'ye göre gruplandır
                .Select(g => new
                {
                    SinifId = g.Key, // Gruplanan sınıfın ID'si
                    OgrenciSayisi = g.Count() // Gruplanan sınıfın öğrenci sayısı
                })
                .OrderByDescending(g => g.OgrenciSayisi) // Öğrenci sayısına göre azalan sırayla sırala
                .FirstOrDefault(); // En kalabalık sınıfı al
            var kalabalik_sinif = db.Siniflar.FirstOrDefault(s => s.sinif_id == en_kalabalik_sinif.SinifId);
            enKalabalikSinif.Text = $"{kalabalik_sinif.sinif_adi} - {en_kalabalik_sinif.OgrenciSayisi} Öğrenci";

            var en_az_kalabalik_sinif = db.Ogrenciler
                .GroupBy(o => o.sinif_id) // Öğrencileri SinifId'ye göre gruplandır
                .Select(g => new
                {
                     SinifId = g.Key, // Gruplanan sınıfın ID'si
                    OgrenciSayisi = g.Count() // Gruplanan sınıfın öğrenci sayısı
                })
                .OrderBy(g => g.OgrenciSayisi) // Öğrenci sayısına göre artan sırayla sırala
                .FirstOrDefault(); // En az kalabalık sınıfı al

            // Siniflar tablosu ile ilişkilendirerek sınıfın adı alınır
            var az_sinif = db.Siniflar.FirstOrDefault(s => s.sinif_id == en_az_kalabalik_sinif.SinifId);
            enAzSinif.Text = $"{az_sinif.sinif_adi} - {en_az_kalabalik_sinif.OgrenciSayisi} Öğrenci";

            int toplam_ogrenci = int.Parse(db.Ogrenciler.Count().ToString());
            int sinif_sayisi = int.Parse(db.Siniflar.Count().ToString());
            ortalamaOgrenci.Text = (toplam_ogrenci / sinif_sayisi).ToString();


            Random random = new Random();

            //AYIN ÖĞRENCİSİ
            int rastgeleOgrenciId = random.Next(1, toplam_ogrenci + 1);
            var secilenOgrenci = db.Ogrenciler.Where(x => x.ogrenci_id == rastgeleOgrenciId).Select(y=> new
            {
                ogrenciAdi = y.ogrenci_adi + " " + y.ogrenci_soyadi,
                y.sinif_id
                
            }).FirstOrDefault();
            var secilenOgrenciSinif = db.Siniflar.Where(s => s.sinif_id == secilenOgrenci.sinif_id).Select(x => x.sinif_adi).FirstOrDefault();
            ayinOgrencisi.Text = secilenOgrenci.ogrenciAdi + " - " + secilenOgrenciSinif;

            //AYIN SINIFI
            int rastgeleSinifId = random.Next(1, sinif_sayisi + 1);
            var secilenSinif = db.Siniflar.Where(x => x.sinif_id == rastgeleSinifId).Select(y => y.sinif_adi).FirstOrDefault();
            ayinSinifi.Text = secilenSinif;

            //AYIN OGRETMENİ
            int rastgeleOgretmenId = random.Next(1, int.Parse(db.Ogretmenler.Count().ToString()) + 1 );
            var secilenOgretmen = db.Ogretmenler.Where(x => x.ogretmen_id == rastgeleOgretmenId).Select(y => new
            {
                ogretmenAdi = y.ogretmen_adi + " " + y.ogretmen_soyadi,
                y.ogretmen_alan
            }).FirstOrDefault();
            ayinOgretmeni.Text = $"{secilenOgretmen.ogretmenAdi} - {secilenOgretmen.ogretmen_alan}";
        }

        private void frmBtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
