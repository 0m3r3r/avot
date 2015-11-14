namespace Avot.Forms
{
    partial class Mahkeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mahkeme));
            this.lstMahkeme = new System.Windows.Forms.ListView();
            this.MahAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MahNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MahTur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ililce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMahkeme
            // 
            this.lstMahkeme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MahAdi,
            this.MahNo,
            this.MahTur,
            this.ililce});
            this.lstMahkeme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstMahkeme.FullRowSelect = true;
            this.lstMahkeme.GridLines = true;
            this.lstMahkeme.Location = new System.Drawing.Point(0, 68);
            this.lstMahkeme.Name = "lstMahkeme";
            this.lstMahkeme.Size = new System.Drawing.Size(636, 255);
            this.lstMahkeme.TabIndex = 0;
            this.lstMahkeme.UseCompatibleStateImageBehavior = false;
            this.lstMahkeme.View = System.Windows.Forms.View.Details;
            // 
            // MahAdi
            // 
            this.MahAdi.Text = "Mahkeme Adı";
            this.MahAdi.Width = 240;
            // 
            // MahNo
            // 
            this.MahNo.Text = "Mahkeme No";
            this.MahNo.Width = 107;
            // 
            // MahTur
            // 
            this.MahTur.Text = "Mahkeme Türü";
            this.MahTur.Width = 139;
            // 
            // ililce
            // 
            this.ililce.Text = "İl İlçe";
            this.ililce.Width = 113;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(204, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(58, 50);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(140, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(58, 50);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(76, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(58, 50);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(12, 12);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(58, 50);
            this.btnYeniKayit.TabIndex = 9;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // Mahkeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 323);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.lstMahkeme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mahkeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahkeme";
            this.Load += new System.EventHandler(this.Mahkeme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMahkeme;
        private System.Windows.Forms.ColumnHeader MahAdi;
        private System.Windows.Forms.ColumnHeader MahNo;
        private System.Windows.Forms.ColumnHeader MahTur;
        private System.Windows.Forms.ColumnHeader ililce;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniKayit;
    }
}