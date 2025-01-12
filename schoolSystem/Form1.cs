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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        schoolSystemDBEntities4 db = new schoolSystemDBEntities4();
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
            ogrenciler.ogrenci_adi = txtOgrenciAdi.Text;
            ogrenciler.ogrenci_soyadi = txtOgrenciSoyadi.Text;
            ogrenciler.ogrenci_numara = int.Parse(txtOgrenciNo.Text);
            ogrenciler.ogrenci_posta = txtOgrenciPosta.Text;
            ogrenciler.ogrenci_telNo = txtOgrenciTelno.Text;
            ogrenciler.ogrenci_sinif = txtOgrenciSinif.Text;
            db.Ogrenciler.Add(ogrenciler);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOgrenciId.Text);
            var removeValue = db.Ogrenciler.Find(id);
            db.Ogrenciler.DefaultIfEmpty(removeValue);
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
                updatedValue.ogrenci_sinif = txtOgrenciSinif.Text;

            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtOgrenciSinif.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
