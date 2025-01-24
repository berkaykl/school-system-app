using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace schoolSystem
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        schoolSystemDBEntities7 db = new schoolSystemDBEntities7();

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            var classData = db.Siniflar
                    .Select(s => new
                    {
                        s.sinif_adi,
                        s.sinif_kapasite,
                        StudentCount = db.Ogrenciler.Count(o => o.sinif_id == s.sinif_id) // Her siniftaki ogrenci sayisi
                    })
                    .ToList();

            if (classData.Any())
            {
                chartKapasite.Series.Clear();
                chartKapasite.Series.Add("Sınıf Kapasiteleri");
                chartKapasite.Series["Sınıf Kapasiteleri"].ChartType = SeriesChartType.Pie;

                foreach (var data in classData)
                {
                    Console.WriteLine($"Class: {data.sinif_adi}, Student Count: {data.StudentCount}, Capacity: {data.sinif_kapasite}");

                    int percentage = 0;

                    if (data.sinif_kapasite.HasValue && data.sinif_kapasite.Value > 0)  // nullable kontrolü eklendi
                    {
                        percentage = (int)Math.Round((double)data.StudentCount / data.sinif_kapasite.Value * 100);  // .Value kullanarak nullabledan gerçek degeri aliyoruz
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Class {data.sinif_adi} has invalid capacity.");
                        percentage = 0; // eger kapasite gecerli degilse 0% olarak ayarlanir
                    }

                    chartKapasite.Series["Sınıf Kapasiteleri"].Points.AddXY(data.sinif_adi, percentage);
                }

                chartKapasite.Series["Sınıf Kapasiteleri"].LabelFormat = "#PERCENT";

                chartKapasite.Refresh();
            }
            else
            {
                MessageBox.Show("Mevcut Sınıf Verisi Yok");
            }


            var sinifOgrenciSayilari = db.Ogrenciler
                .GroupBy(o => o.sinif_id)
                .Select(g => new
                {
                    SinifId = g.Key,
                    OgrenciSayisi = g.Count()
                })
                .ToList();


            var sinifBilgileri = sinifOgrenciSayilari
                .Join(db.Siniflar,
                      o => o.SinifId,
                      s => s.sinif_id,
                      (o, s) => new
                      {
                          SinifAdi = s.sinif_adi,
                          OgrenciSayisi = o.OgrenciSayisi
                      })
                .ToList();


            chartSiniflar.Series.Clear();
            var series = chartSiniflar.Series.Add("Sınıflar");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (var sinif in sinifBilgileri)
            {
                series.Points.AddXY(sinif.SinifAdi, sinif.OgrenciSayisi);
            }

            chartSiniflar.ChartAreas[0].AxisX.Title = "Sınıflar";
            chartSiniflar.ChartAreas[0].AxisY.Title = "Öğrenci Sayısı";
            chartSiniflar.ChartAreas[0].AxisX.Interval = 1; // X eksenindeki etiket aralığı

        }

        private void btnFrmOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci frmOgrenci = new FrmOgrenci();
            frmOgrenci.Show();
            this.Hide();
        }

        private void btnFrmSinif_Click(object sender, EventArgs e)
        {
            FrmSinif frmSinif = new FrmSinif();
            frmSinif.Show();
            this.Hide();
        }

        private void btnFrmOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmen frmOgretmen = new FrmOgretmen();
            frmOgretmen.Show();
            this.Hide();
        }

        private void btnFrmIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();
            this.Hide();
        }

        private void frmBtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
