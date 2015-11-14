namespace Avot.Forms
{
    partial class Celse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Celse));
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lstCelse = new System.Windows.Forms.ListView();
            this.CelseTar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hakim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Savci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Karar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErtelemeMazeret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErtelemeTar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(12, 12);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(58, 50);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(76, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(58, 50);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lstCelse
            // 
            this.lstCelse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CelseTar,
            this.Hakim,
            this.Savci,
            this.Karar,
            this.ErtelemeMazeret,
            this.ErtelemeTar,
            this.Aciklama});
            this.lstCelse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstCelse.FullRowSelect = true;
            this.lstCelse.GridLines = true;
            this.lstCelse.Location = new System.Drawing.Point(0, 68);
            this.lstCelse.Name = "lstCelse";
            this.lstCelse.Size = new System.Drawing.Size(836, 229);
            this.lstCelse.TabIndex = 2;
            this.lstCelse.UseCompatibleStateImageBehavior = false;
            this.lstCelse.View = System.Windows.Forms.View.Details;
            // 
            // CelseTar
            // 
            this.CelseTar.Text = "Celse Tarihi";
            this.CelseTar.Width = 74;
            // 
            // Hakim
            // 
            this.Hakim.Text = "Hakim";
            this.Hakim.Width = 100;
            // 
            // Savci
            // 
            this.Savci.Text = "Savci";
            this.Savci.Width = 101;
            // 
            // Karar
            // 
            this.Karar.Text = "Karar";
            this.Karar.Width = 128;
            // 
            // ErtelemeMazeret
            // 
            this.ErtelemeMazeret.Text = "Erteleme Mazeret";
            this.ErtelemeMazeret.Width = 118;
            // 
            // ErtelemeTar
            // 
            this.ErtelemeTar.Text = "Erteleme Tarihi";
            this.ErtelemeTar.Width = 88;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            this.Aciklama.Width = 204;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(140, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(58, 50);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(204, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(58, 50);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Celse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 297);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.lstCelse);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Celse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celse Yönetim Ekranı";
            this.Load += new System.EventHandler(this.Celse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.ListView lstCelse;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ColumnHeader CelseTar;
        private System.Windows.Forms.ColumnHeader Hakim;
        private System.Windows.Forms.ColumnHeader Savci;
        private System.Windows.Forms.ColumnHeader Karar;
        private System.Windows.Forms.ColumnHeader ErtelemeMazeret;
        private System.Windows.Forms.ColumnHeader ErtelemeTar;
        private System.Windows.Forms.ColumnHeader Aciklama;
    }
}