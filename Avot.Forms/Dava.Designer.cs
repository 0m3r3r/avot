namespace Avot.Forms
{
    partial class Dava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dava));
            this.btnCikis = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.lstDava = new System.Windows.Forms.ListView();
            this.DosyaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Davali = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Davaci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Savci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mahkeme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCelsegr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(266, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(58, 50);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(202, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(58, 50);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(138, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(58, 50);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(10, 12);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(58, 50);
            this.btnYeniKayit.TabIndex = 5;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // lstDava
            // 
            this.lstDava.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DosyaNo,
            this.Davali,
            this.Davaci,
            this.Savci,
            this.Mahkeme});
            this.lstDava.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstDava.FullRowSelect = true;
            this.lstDava.GridLines = true;
            this.lstDava.Location = new System.Drawing.Point(0, 68);
            this.lstDava.Name = "lstDava";
            this.lstDava.Size = new System.Drawing.Size(614, 250);
            this.lstDava.TabIndex = 9;
            this.lstDava.UseCompatibleStateImageBehavior = false;
            this.lstDava.View = System.Windows.Forms.View.Details;
            // 
            // DosyaNo
            // 
            this.DosyaNo.Text = "Dosya No";
            this.DosyaNo.Width = 88;
            // 
            // Davali
            // 
            this.Davali.Text = "Davalı";
            this.Davali.Width = 115;
            // 
            // Davaci
            // 
            this.Davaci.Text = "Davacı";
            this.Davaci.Width = 123;
            // 
            // Savci
            // 
            this.Savci.Text = "Savcı";
            this.Savci.Width = 115;
            // 
            // Mahkeme
            // 
            this.Mahkeme.Text = "Mahkeme";
            this.Mahkeme.Width = 146;
            // 
            // btnCelsegr
            // 
            this.btnCelsegr.Location = new System.Drawing.Point(74, 12);
            this.btnCelsegr.Name = "btnCelsegr";
            this.btnCelsegr.Size = new System.Drawing.Size(58, 50);
            this.btnCelsegr.TabIndex = 10;
            this.btnCelsegr.Text = "Celse Girişi";
            this.btnCelsegr.UseVisualStyleBackColor = true;
            this.btnCelsegr.Click += new System.EventHandler(this.btnCelsegr_Click);
            // 
            // Dava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 318);
            this.Controls.Add(this.btnCelsegr);
            this.Controls.Add(this.lstDava);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dava Yönetim Ekranı";
            this.Load += new System.EventHandler(this.Dava_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.ListView lstDava;
        private System.Windows.Forms.ColumnHeader DosyaNo;
        private System.Windows.Forms.ColumnHeader Davali;
        private System.Windows.Forms.ColumnHeader Davaci;
        private System.Windows.Forms.ColumnHeader Savci;
        private System.Windows.Forms.ColumnHeader Mahkeme;
        private System.Windows.Forms.Button btnCelsegr;
    }
}