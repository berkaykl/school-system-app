namespace schoolSystem
{
    partial class FrmSinif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmBtnGeri = new System.Windows.Forms.Button();
            this.btnSinifOgrenciList = new System.Windows.Forms.Button();
            this.btnSinifGuncelle = new System.Windows.Forms.Button();
            this.btnSinifEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSinifId = new System.Windows.Forms.TextBox();
            this.btnSinifList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEklenecekSinif = new System.Windows.Forms.TextBox();
            this.cmbSiniflar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSinifKapasite = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmBtnGeri
            // 
            this.frmBtnGeri.BackColor = System.Drawing.Color.Maroon;
            this.frmBtnGeri.ForeColor = System.Drawing.Color.White;
            this.frmBtnGeri.Location = new System.Drawing.Point(12, 422);
            this.frmBtnGeri.Name = "frmBtnGeri";
            this.frmBtnGeri.Size = new System.Drawing.Size(59, 30);
            this.frmBtnGeri.TabIndex = 42;
            this.frmBtnGeri.Text = "Geri Dön";
            this.frmBtnGeri.UseVisualStyleBackColor = false;
            this.frmBtnGeri.Click += new System.EventHandler(this.frmBtnGeri_Click);
            // 
            // btnSinifOgrenciList
            // 
            this.btnSinifOgrenciList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnSinifOgrenciList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinifOgrenciList.Location = new System.Drawing.Point(12, 194);
            this.btnSinifOgrenciList.Name = "btnSinifOgrenciList";
            this.btnSinifOgrenciList.Size = new System.Drawing.Size(250, 30);
            this.btnSinifOgrenciList.TabIndex = 40;
            this.btnSinifOgrenciList.Text = "Seçili Sınıftaki Öğrencileri Listele";
            this.btnSinifOgrenciList.UseVisualStyleBackColor = false;
            this.btnSinifOgrenciList.Click += new System.EventHandler(this.btnSinifOgrenciList_Click);
            // 
            // btnSinifGuncelle
            // 
            this.btnSinifGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnSinifGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinifGuncelle.Location = new System.Drawing.Point(12, 266);
            this.btnSinifGuncelle.Name = "btnSinifGuncelle";
            this.btnSinifGuncelle.Size = new System.Drawing.Size(250, 30);
            this.btnSinifGuncelle.TabIndex = 38;
            this.btnSinifGuncelle.Text = "Sınıf Güncelle";
            this.btnSinifGuncelle.UseVisualStyleBackColor = false;
            this.btnSinifGuncelle.Click += new System.EventHandler(this.btnSinifGuncelle_Click);
            // 
            // btnSinifEkle
            // 
            this.btnSinifEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnSinifEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinifEkle.Location = new System.Drawing.Point(12, 230);
            this.btnSinifEkle.Name = "btnSinifEkle";
            this.btnSinifEkle.Size = new System.Drawing.Size(250, 30);
            this.btnSinifEkle.TabIndex = 37;
            this.btnSinifEkle.Text = "Sınıf Ekle";
            this.btnSinifEkle.UseVisualStyleBackColor = false;
            this.btnSinifEkle.Click += new System.EventHandler(this.btnSinifEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mevcut Sınıflar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sınıf ID:";
            // 
            // txtSinifId
            // 
            this.txtSinifId.Enabled = false;
            this.txtSinifId.Location = new System.Drawing.Point(114, 11);
            this.txtSinifId.Name = "txtSinifId";
            this.txtSinifId.ReadOnly = true;
            this.txtSinifId.Size = new System.Drawing.Size(148, 20);
            this.txtSinifId.TabIndex = 23;
            // 
            // btnSinifList
            // 
            this.btnSinifList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnSinifList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinifList.Location = new System.Drawing.Point(12, 158);
            this.btnSinifList.Name = "btnSinifList";
            this.btnSinifList.Size = new System.Drawing.Size(250, 30);
            this.btnSinifList.TabIndex = 22;
            this.btnSinifList.Text = "Sınıfları Listele";
            this.btnSinifList.UseVisualStyleBackColor = false;
            this.btnSinifList.Click += new System.EventHandler(this.btnSinifList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Eklenecek Sınıf:";
            // 
            // txtEklenecekSinif
            // 
            this.txtEklenecekSinif.Location = new System.Drawing.Point(114, 93);
            this.txtEklenecekSinif.Name = "txtEklenecekSinif";
            this.txtEklenecekSinif.Size = new System.Drawing.Size(148, 20);
            this.txtEklenecekSinif.TabIndex = 43;
            // 
            // cmbSiniflar
            // 
            this.cmbSiniflar.FormattingEnabled = true;
            this.cmbSiniflar.Location = new System.Drawing.Point(114, 38);
            this.cmbSiniflar.Name = "cmbSiniflar";
            this.cmbSiniflar.Size = new System.Drawing.Size(148, 21);
            this.cmbSiniflar.TabIndex = 45;
            this.cmbSiniflar.SelectedIndexChanged += new System.EventHandler(this.cmbSiniflar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Sınıf Kapasitesi:";
            // 
            // txtSinifKapasite
            // 
            this.txtSinifKapasite.Location = new System.Drawing.Point(114, 119);
            this.txtSinifKapasite.Name = "txtSinifKapasite";
            this.txtSinifKapasite.Size = new System.Drawing.Size(148, 20);
            this.txtSinifKapasite.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 441);
            this.dataGridView1.TabIndex = 48;
            // 
            // FrmSinif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSinifKapasite);
            this.Controls.Add(this.cmbSiniflar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEklenecekSinif);
            this.Controls.Add(this.frmBtnGeri);
            this.Controls.Add(this.btnSinifOgrenciList);
            this.Controls.Add(this.btnSinifGuncelle);
            this.Controls.Add(this.btnSinifEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSinifId);
            this.Controls.Add(this.btnSinifList);
            this.Name = "FrmSinif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSinif";
            this.Load += new System.EventHandler(this.FrmSinif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmBtnGeri;
        private System.Windows.Forms.Button btnSinifOgrenciList;
        private System.Windows.Forms.Button btnSinifGuncelle;
        private System.Windows.Forms.Button btnSinifEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinifId;
        private System.Windows.Forms.Button btnSinifList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEklenecekSinif;
        private System.Windows.Forms.ComboBox cmbSiniflar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSinifKapasite;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}