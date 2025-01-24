namespace schoolSystem
{
    partial class FrmAnasayfa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnFrmOgrenci = new System.Windows.Forms.Button();
            this.btnFrmSinif = new System.Windows.Forms.Button();
            this.btnFrmOgretmen = new System.Windows.Forms.Button();
            this.btnFrmIstatistik = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frmBtnCikis = new System.Windows.Forms.Button();
            this.chartKapasite = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.chartSiniflar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKapasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSiniflar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrmOgrenci
            // 
            this.btnFrmOgrenci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnFrmOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmOgrenci.ForeColor = System.Drawing.Color.White;
            this.btnFrmOgrenci.Location = new System.Drawing.Point(17, 14);
            this.btnFrmOgrenci.Name = "btnFrmOgrenci";
            this.btnFrmOgrenci.Size = new System.Drawing.Size(215, 41);
            this.btnFrmOgrenci.TabIndex = 0;
            this.btnFrmOgrenci.Text = "Öğrenci Listesi";
            this.btnFrmOgrenci.UseVisualStyleBackColor = false;
            this.btnFrmOgrenci.Click += new System.EventHandler(this.btnFrmOgrenci_Click);
            // 
            // btnFrmSinif
            // 
            this.btnFrmSinif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnFrmSinif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmSinif.ForeColor = System.Drawing.Color.White;
            this.btnFrmSinif.Location = new System.Drawing.Point(17, 61);
            this.btnFrmSinif.Name = "btnFrmSinif";
            this.btnFrmSinif.Size = new System.Drawing.Size(215, 41);
            this.btnFrmSinif.TabIndex = 1;
            this.btnFrmSinif.Text = "Sınıf Listesi";
            this.btnFrmSinif.UseVisualStyleBackColor = false;
            this.btnFrmSinif.Click += new System.EventHandler(this.btnFrmSinif_Click);
            // 
            // btnFrmOgretmen
            // 
            this.btnFrmOgretmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnFrmOgretmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmOgretmen.ForeColor = System.Drawing.Color.White;
            this.btnFrmOgretmen.Location = new System.Drawing.Point(17, 108);
            this.btnFrmOgretmen.Name = "btnFrmOgretmen";
            this.btnFrmOgretmen.Size = new System.Drawing.Size(215, 41);
            this.btnFrmOgretmen.TabIndex = 2;
            this.btnFrmOgretmen.Text = "Öğretmen Listesi";
            this.btnFrmOgretmen.UseVisualStyleBackColor = false;
            this.btnFrmOgretmen.Click += new System.EventHandler(this.btnFrmOgretmen_Click);
            // 
            // btnFrmIstatistik
            // 
            this.btnFrmIstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnFrmIstatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFrmIstatistik.ForeColor = System.Drawing.Color.White;
            this.btnFrmIstatistik.Location = new System.Drawing.Point(17, 155);
            this.btnFrmIstatistik.Name = "btnFrmIstatistik";
            this.btnFrmIstatistik.Size = new System.Drawing.Size(215, 41);
            this.btnFrmIstatistik.TabIndex = 3;
            this.btnFrmIstatistik.Text = "Okul İstatistikleri";
            this.btnFrmIstatistik.UseVisualStyleBackColor = false;
            this.btnFrmIstatistik.Click += new System.EventHandler(this.btnFrmIstatistik_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 44);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Sayfa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.frmBtnCikis);
            this.panel2.Controls.Add(this.btnFrmOgrenci);
            this.panel2.Controls.Add(this.btnFrmSinif);
            this.panel2.Controls.Add(this.btnFrmIstatistik);
            this.panel2.Controls.Add(this.btnFrmOgretmen);
            this.panel2.Location = new System.Drawing.Point(-1, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 423);
            this.panel2.TabIndex = 5;
            // 
            // frmBtnCikis
            // 
            this.frmBtnCikis.BackColor = System.Drawing.Color.Maroon;
            this.frmBtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmBtnCikis.ForeColor = System.Drawing.Color.White;
            this.frmBtnCikis.Location = new System.Drawing.Point(17, 376);
            this.frmBtnCikis.Name = "frmBtnCikis";
            this.frmBtnCikis.Size = new System.Drawing.Size(59, 30);
            this.frmBtnCikis.TabIndex = 43;
            this.frmBtnCikis.Text = "Çıkış Yap";
            this.frmBtnCikis.UseVisualStyleBackColor = false;
            this.frmBtnCikis.Click += new System.EventHandler(this.frmBtnCikis_Click);
            // 
            // chartKapasite
            // 
            this.chartKapasite.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartKapasite.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Title = "Sınıflar";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chartKapasite.Legends.Add(legend1);
            this.chartKapasite.Location = new System.Drawing.Point(250, 135);
            this.chartKapasite.Name = "chartKapasite";
            this.chartKapasite.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartKapasite.Series.Add(series1);
            this.chartKapasite.Size = new System.Drawing.Size(314, 298);
            this.chartKapasite.TabIndex = 6;
            this.chartKapasite.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "Title1";
            title1.Text = "Sınıf Kapasitesi Kullanımı";
            this.chartKapasite.Titles.Add(title1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(493, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genel İstatistikler";
            // 
            // chartSiniflar
            // 
            this.chartSiniflar.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartSiniflar.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.Name = "Legend1";
            this.chartSiniflar.Legends.Add(legend2);
            this.chartSiniflar.Location = new System.Drawing.Point(549, 135);
            this.chartSiniflar.Name = "chartSiniflar";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chartSiniflar.Series.Add(series2);
            this.chartSiniflar.Size = new System.Drawing.Size(390, 298);
            this.chartSiniflar.TabIndex = 8;
            this.chartSiniflar.Text = "chart2";
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 461);
            this.Controls.Add(this.chartSiniflar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartKapasite);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartKapasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSiniflar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrmOgrenci;
        private System.Windows.Forms.Button btnFrmSinif;
        private System.Windows.Forms.Button btnFrmOgretmen;
        private System.Windows.Forms.Button btnFrmIstatistik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button frmBtnCikis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKapasite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSiniflar;
    }
}