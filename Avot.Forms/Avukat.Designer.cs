namespace Avot.Forms
{
    partial class Avukat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avukat));
            this.btnCikis = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.lstAvukat = new System.Windows.Forms.ListView();
            this.TBBNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(201, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(58, 50);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(137, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(58, 50);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(73, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(58, 50);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(9, 12);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(58, 50);
            this.btnYeniKayit.TabIndex = 5;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // lstAvukat
            // 
            this.lstAvukat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TBBNo,
            this.Ad,
            this.Soyad,
            this.Brans,
            this.TC});
            this.lstAvukat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstAvukat.FullRowSelect = true;
            this.lstAvukat.GridLines = true;
            this.lstAvukat.Location = new System.Drawing.Point(0, 68);
            this.lstAvukat.Name = "lstAvukat";
            this.lstAvukat.Size = new System.Drawing.Size(636, 255);
            this.lstAvukat.TabIndex = 9;
            this.lstAvukat.UseCompatibleStateImageBehavior = false;
            this.lstAvukat.View = System.Windows.Forms.View.Details;
            // 
            // TBBNo
            // 
            this.TBBNo.Text = "TBB No";
            this.TBBNo.Width = 123;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 92;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 102;
            // 
            // Brans
            // 
            this.Brans.Text = "Branş";
            this.Brans.Width = 128;
            // 
            // TC
            // 
            this.TC.Text = "TC";
            this.TC.Width = 163;
            // 
            // Avukat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 323);
            this.Controls.Add(this.lstAvukat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avukat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avukat Yönetim Ekranı";
            this.Load += new System.EventHandler(this.Avukat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.ListView lstAvukat;
        private System.Windows.Forms.ColumnHeader TBBNo;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Brans;
        private System.Windows.Forms.ColumnHeader TC;
    }
}