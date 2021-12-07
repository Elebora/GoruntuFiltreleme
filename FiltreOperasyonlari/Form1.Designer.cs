
namespace FiltreOperasyonlari
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüİyileştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEşitlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastGermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelKenarBelirlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tersiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(270, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 339);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.görüntüİyileştirmeToolStripMenuItem,
            this.toolStripComboBox1,
            this.filtrelerToolStripMenuItem,
            this.uygulamalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(553, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem1,
            this.kameraToolStripMenuItem});
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // dosyaToolStripMenuItem1
            // 
            this.dosyaToolStripMenuItem1.Name = "dosyaToolStripMenuItem1";
            this.dosyaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dosyaToolStripMenuItem1.Text = "Dosya";
            this.dosyaToolStripMenuItem1.Click += new System.EventHandler(this.dosyaToolStripMenuItem1_Click);
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kameraToolStripMenuItem.Text = "Kamera";
            this.kameraToolStripMenuItem.Click += new System.EventHandler(this.kameraToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // görüntüİyileştirmeToolStripMenuItem
            // 
            this.görüntüİyileştirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramEşitlemeToolStripMenuItem,
            this.kontrastGermeToolStripMenuItem});
            this.görüntüİyileştirmeToolStripMenuItem.Name = "görüntüİyileştirmeToolStripMenuItem";
            this.görüntüİyileştirmeToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.görüntüİyileştirmeToolStripMenuItem.Text = "Görüntü İyileştirme";
            // 
            // histogramEşitlemeToolStripMenuItem
            // 
            this.histogramEşitlemeToolStripMenuItem.Name = "histogramEşitlemeToolStripMenuItem";
            this.histogramEşitlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramEşitlemeToolStripMenuItem.Text = "Histogram Eşitleme";
            this.histogramEşitlemeToolStripMenuItem.Click += new System.EventHandler(this.histogramEşitlemeToolStripMenuItem_Click);
            // 
            // kontrastGermeToolStripMenuItem
            // 
            this.kontrastGermeToolStripMenuItem.Name = "kontrastGermeToolStripMenuItem";
            this.kontrastGermeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kontrastGermeToolStripMenuItem.Text = "Kontrast Germe";
            this.kontrastGermeToolStripMenuItem.Click += new System.EventHandler(this.kontrastGermeToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamaToolStripMenuItem,
            this.ortancaToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // ortalamaToolStripMenuItem
            // 
            this.ortalamaToolStripMenuItem.Name = "ortalamaToolStripMenuItem";
            this.ortalamaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ortalamaToolStripMenuItem.Text = "Ortalama";
            // 
            // ortancaToolStripMenuItem
            // 
            this.ortancaToolStripMenuItem.Name = "ortancaToolStripMenuItem";
            this.ortancaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ortancaToolStripMenuItem.Text = "Ortanca";
            // 
            // uygulamalarToolStripMenuItem
            // 
            this.uygulamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelKenarBelirlemeToolStripMenuItem,
            this.tersiToolStripMenuItem});
            this.uygulamalarToolStripMenuItem.Name = "uygulamalarToolStripMenuItem";
            this.uygulamalarToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.uygulamalarToolStripMenuItem.Text = "Uygulamalar";
            // 
            // sobelKenarBelirlemeToolStripMenuItem
            // 
            this.sobelKenarBelirlemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelToolStripMenuItem,
            this.cannyToolStripMenuItem,
            this.robertToolStripMenuItem,
            this.prewitToolStripMenuItem});
            this.sobelKenarBelirlemeToolStripMenuItem.Name = "sobelKenarBelirlemeToolStripMenuItem";
            this.sobelKenarBelirlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobelKenarBelirlemeToolStripMenuItem.Text = "Kenar Belirleme";
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            // 
            // robertToolStripMenuItem
            // 
            this.robertToolStripMenuItem.Name = "robertToolStripMenuItem";
            this.robertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.robertToolStripMenuItem.Text = "Robert";
            // 
            // prewitToolStripMenuItem
            // 
            this.prewitToolStripMenuItem.Name = "prewitToolStripMenuItem";
            this.prewitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prewitToolStripMenuItem.Text = "Prewit";
            // 
            // tersiToolStripMenuItem
            // 
            this.tersiToolStripMenuItem.Name = "tersiToolStripMenuItem";
            this.tersiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tersiToolStripMenuItem.Text = "Tersi";
            this.tersiToolStripMenuItem.Click += new System.EventHandler(this.tersiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(553, 366);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüİyileştirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEşitlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastGermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortancaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelKenarBelirlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tersiToolStripMenuItem;
    }
}

