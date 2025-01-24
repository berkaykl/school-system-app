using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace schoolSystem
{
    public partial class FrmSinif : Form
    {
        public FrmSinif()
        {
            InitializeComponent();
        }

        schoolSystemDBEntities7 db = new schoolSystemDBEntities7();


        private void cmbBoxSiniflarGuncelle()
        {
            var values = db.Siniflar.Select(x => new
            {
                x.sinif_id,
                x.sinif_adi
            }).ToList();
            cmbSiniflar.DisplayMember = "sinif_adi";
            cmbSiniflar.ValueMember = "sinif_id";
            cmbSiniflar.DataSource = values;
        }

        private void sinifListesiGuncelle()
        {
            var siniflar = db.Siniflar.ToList();
            dataGridView1.DataSource = siniflar;
        }
        private void FrmSinif_Load(object sender, EventArgs e)
        {
            cmbBoxSiniflarGuncelle();
        }

        private void btnSinifList_Click(object sender, EventArgs e)
        {
            sinifListesiGuncelle();
        }

        private void btnSinifOgrenciList_Click(object sender, EventArgs e)
        {
            var selectedValue = Convert.ToInt32(cmbSiniflar.SelectedValue);
            var selectedSinif = db.Ogrenciler.Where(x => x.sinif_id == selectedValue).ToList();
            dataGridView1.DataSource = selectedSinif;
        }

        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEklenecekSinif.Text) ||
                string.IsNullOrWhiteSpace(txtSinifKapasite.Text)) {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Siniflar siniflar = new Siniflar();
            siniflar.sinif_adi = txtEklenecekSinif.Text;
            siniflar.sinif_kapasite = int.Parse(txtSinifKapasite.Text);
            db.Siniflar.Add(siniflar);
            db.SaveChanges();
            MessageBox.Show("Sınıf Eklendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var mevcutSiniflar = db.Siniflar.ToList();
            dataGridView1.DataSource = mevcutSiniflar;

            txtEklenecekSinif.Text = "";
            txtSinifKapasite.Text = "";

            cmbBoxSiniflarGuncelle();
            sinifListesiGuncelle();
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSinifId.Text)) {
                int sinif_id = int.Parse(txtSinifId.Text);
                var updatedValue = db.Siniflar.Find(sinif_id);

                if (!string.IsNullOrEmpty(txtSinifKapasite.Text))
                {
                    updatedValue.sinif_kapasite = int.Parse(txtSinifKapasite.Text);
                    db.SaveChanges();
                    MessageBox.Show("Sınıf Güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sinifListesiGuncelle();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir kapasite sayısı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else {
                MessageBox.Show("Lütfen geçerli bir id girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = Convert.ToInt32(cmbSiniflar.SelectedValue);
            txtSinifId.Text = selectedValue.ToString();
        }

        private void frmBtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
