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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }


        schoolSystemDBEntities7 db = new schoolSystemDBEntities7();
        private void btnOgrenciList_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.Ogrenciler.ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOgrenciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtOgrenciSoyadi.Text) ||
                string.IsNullOrWhiteSpace(txtOgrenciNo.Text) ||
                string.IsNullOrWhiteSpace(txtOgrenciPosta.Text) ||
                string.IsNullOrWhiteSpace(txtOgrenciTelno.Text) ||
                string.IsNullOrWhiteSpace(txtOgrenciSinif.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ogrenciler ogrenciler = new Ogrenciler();

            int sinif_id_bul = db.Siniflar.Where(x => x.sinif_adi == txtOgrenciSinif.Text).Select(x => x.sinif_id).FirstOrDefault();

            ogrenciler.ogrenci_adi = txtOgrenciAdi.Text;
            ogrenciler.ogrenci_soyadi = txtOgrenciSoyadi.Text;
            ogrenciler.ogrenci_numara = int.Parse(txtOgrenciNo.Text);
            ogrenciler.ogrenci_posta = txtOgrenciPosta.Text;
            ogrenciler.ogrenci_telNo = txtOgrenciTelno.Text;
            ogrenciler.sinif_id = sinif_id_bul;
            db.Ogrenciler.Add(ogrenciler);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var ogrenciler_list = db.Ogrenciler.ToList();
            dataGridView1.DataSource = ogrenciler_list;
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOgrenciId.Text);
            var removeValue = db.Ogrenciler.Find(id);
            db.Ogrenciler.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOgrenciId.Text);
            var updatedValue = db.Ogrenciler.Find(id);

            if (!string.IsNullOrEmpty(txtOgrenciAdi.Text))
                updatedValue.ogrenci_adi = txtOgrenciAdi.Text;

            if (!string.IsNullOrEmpty(txtOgrenciSoyadi.Text))
                updatedValue.ogrenci_soyadi = txtOgrenciSoyadi.Text;

            if (!string.IsNullOrEmpty(txtOgrenciNo.Text))
                updatedValue.ogrenci_numara = int.Parse(txtOgrenciNo.Text);

            if (!string.IsNullOrEmpty(txtOgrenciPosta.Text))
                updatedValue.ogrenci_posta = txtOgrenciPosta.Text;

            if (!string.IsNullOrEmpty(txtOgrenciTelno.Text))
                updatedValue.ogrenci_telNo = txtOgrenciTelno.Text;

            if (!string.IsNullOrEmpty(txtOgrenciSinif.Text))
                updatedValue.sinif_id = db.Siniflar.Where(x => x.sinif_adi == txtOgrenciSinif.Text).Select(x => x.sinif_id).FirstOrDefault();

            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var ogrenciler = db.Ogrenciler.ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        private void btnOgrenciAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOgrenciId.Text)) {
                int id = int.Parse(txtOgrenciId.Text);
                var arananOgrenci = db.Ogrenciler.Where(x => x.ogrenci_id == id).ToList();
                dataGridView1.DataSource = arananOgrenci;
            } else {
                MessageBox.Show("Lütfen geçerli bir ID girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOgrenciAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOgrenciSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtOgrenciNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtOgrenciPosta.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtOgrenciTelno.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            string sinif_id = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            var sinif_id2 = int.Parse(sinif_id);

            var text = db.Siniflar.Where(x => x.sinif_id == sinif_id2).Select(y => y.sinif_adi).FirstOrDefault();
            txtOgrenciSinif.Text = text;

        }


        private void frmBtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
