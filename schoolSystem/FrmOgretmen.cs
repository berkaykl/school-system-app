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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        schoolSystemDBEntities7 db = new schoolSystemDBEntities7();

        private void OgretmenlerListUpdate()
        {
            var liste = db.Ogretmenler.ToList();
            dataGridView1.DataSource = liste;
        }

        private void btnOgretmenList_Click(object sender, EventArgs e)
        {
            OgretmenlerListUpdate();
        }

        private void btnOgretmenAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOgretmenId.Text))
            {
                int ogretmen_id = int.Parse(txtOgretmenId.Text);
                var aranan_ogretmen = db.Ogretmenler.Where(x => x.ogretmen_id == ogretmen_id).ToList();
                dataGridView1.DataSource = aranan_ogretmen;
            } else
            {
                MessageBox.Show("Lütfen geçerli bir ID girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgretmenAdi.Text) ||
                string.IsNullOrWhiteSpace(txtOgretmenSoyadi.Text) ||
                string.IsNullOrWhiteSpace(txtOgretmenPosta.Text) ||
                string.IsNullOrWhiteSpace(txtOgretmenTelno.Text) ||
                string.IsNullOrWhiteSpace(txtOgretmenAlan.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ogretmenler ogretmenler = new Ogretmenler();
            ogretmenler.ogretmen_adi = txtOgretmenAdi.Text;
            ogretmenler.ogretmen_soyadi = txtOgretmenSoyadi.Text;
            ogretmenler.ogretmen_posta = txtOgretmenPosta.Text;
            ogretmenler.ogretmen_telNo = txtOgretmenTelno.Text;
            ogretmenler.ogretmen_alan = txtOgretmenAlan.Text;
            db.Ogretmenler.Add(ogretmenler);
            db.SaveChanges();
            MessageBox.Show("Öğretmen Eklendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OgretmenlerListUpdate();
        }

        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOgretmenId.Text)) {
                int id = int.Parse(txtOgretmenId.Text);
                var updated_value = db.Ogretmenler.Find(id);


                if (!string.IsNullOrEmpty(txtOgretmenAdi.Text)){
                    updated_value.ogretmen_adi = txtOgretmenAdi.Text;
                }

                if (!string.IsNullOrEmpty(txtOgretmenSoyadi.Text)){
                    updated_value.ogretmen_soyadi = txtOgretmenSoyadi.Text;
                }
                if (!string.IsNullOrEmpty(txtOgretmenPosta.Text)) {
                    updated_value.ogretmen_posta = txtOgretmenPosta.Text;
                }

                if (!string.IsNullOrEmpty(txtOgretmenTelno.Text)) {
                    updated_value.ogretmen_telNo = txtOgretmenTelno.Text;
                }

                if (!string.IsNullOrEmpty(txtOgretmenAlan.Text)) {
                    updated_value.ogretmen_alan = txtOgretmenAlan.Text;
                }

                db.SaveChanges();
                MessageBox.Show("Öğretmen Güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OgretmenlerListUpdate();

            } else {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğretmenin ID'sini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOgretmenId.Text))
            {
                int id = int.Parse(txtOgretmenId.Text);
                var silenecek_ogretmen = db.Ogretmenler.Find(id);
                db.Ogretmenler.Remove(silenecek_ogretmen);
                db.SaveChanges();
                MessageBox.Show("Öğretmen Silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OgretmenlerListUpdate();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğretmenin ID'sini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmBtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
