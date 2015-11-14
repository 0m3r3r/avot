namespace Avot.Forms
{
    partial class Muvekkil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muvekkil));
            this.btnCikis = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.lstMuvekkil = new System.Windows.Forms.ListView();
            this.Adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TCs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(203, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(58, 50);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(139, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(58, 50);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(75, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(58, 50);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(11, 12);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(58, 50);
            this.btnYeniKayit.TabIndex = 5;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // lstMuvekkil
            // 
            this.lstMuvekkil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adi,
            this.Soyadi,
            this.TCs,
            this.Cinsiyet});
            this.lstMuvekkil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstMuvekkil.FullRowSelect = true;
            this.lstMuvekkil.GridLines = true;
            this.lstMuvekkil.Location = new System.Drawing.Point(0, 68);
            this.lstMuvekkil.Name = "lstMuvekkil";
            this.lstMuvekkil.Size = new System.Drawing.Size(370, 229);
            this.lstMuvekkil.TabIndex = 9;
            this.lstMuvekkil.UseCompatibleStateImageBehavior = false;
            this.lstMuvekkil.View = System.Windows.Forms.View.Details;
            // 
            // Adi
            // 
            this.Adi.Text = "Ad";
            this.Adi.Width = 78;
            // 
            // Soyadi
            // 
            this.Soyadi.Text = "Soyad";
            this.Soyadi.Width = 80;
            // 
            // TCs
            // 
            this.TCs.Text = "TC";
            this.TCs.Width = 133;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // Muvekkil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 297);
            this.Controls.Add(this.lstMuvekkil);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Muvekkil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müvekkil Yönetim Ekranı";
            this.Load += new System.EventHandler(this.Muvekkil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.ListView lstMuvekkil;
        private System.Windows.Forms.ColumnHeader Adi;
        private System.Windows.Forms.ColumnHeader Soyadi;
        private System.Windows.Forms.ColumnHeader TCs;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
    }
}