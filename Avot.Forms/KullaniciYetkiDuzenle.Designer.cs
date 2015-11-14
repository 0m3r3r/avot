namespace Avot.Forms
{
    partial class KullaniciYetkiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciYetkiDuzenle));
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kulkaybtn = new System.Windows.Forms.Button();
            this.kulıptlbtn = new System.Windows.Forms.Button();
            this.cmbYekisi = new System.Windows.Forms.ComboBox();
            this.cmbKullaniciAdi = new System.Windows.Forms.ComboBox();
            this.lblyetkiler = new System.Windows.Forms.Label();
            this.yetkiListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(117, 38);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(183, 27);
            this.txtAdi.TabIndex = 1;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(117, 77);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(183, 27);
            this.txtSoyadi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(117, 155);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(183, 27);
            this.txtSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yetki Grup";
            // 
            // kulkaybtn
            // 
            this.kulkaybtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulkaybtn.Location = new System.Drawing.Point(444, 265);
            this.kulkaybtn.Name = "kulkaybtn";
            this.kulkaybtn.Size = new System.Drawing.Size(94, 28);
            this.kulkaybtn.TabIndex = 5;
            this.kulkaybtn.Text = "Kaydet";
            this.kulkaybtn.UseVisualStyleBackColor = true;
            this.kulkaybtn.Click += new System.EventHandler(this.kulkaybtn_Click);
            // 
            // kulıptlbtn
            // 
            this.kulıptlbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulıptlbtn.Location = new System.Drawing.Point(363, 265);
            this.kulıptlbtn.Name = "kulıptlbtn";
            this.kulıptlbtn.Size = new System.Drawing.Size(75, 28);
            this.kulıptlbtn.TabIndex = 6;
            this.kulıptlbtn.Text = "Iptal";
            this.kulıptlbtn.UseVisualStyleBackColor = true;
            this.kulıptlbtn.Click += new System.EventHandler(this.kulıptlbtn_Click);
            // 
            // cmbYekisi
            // 
            this.cmbYekisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYekisi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYekisi.FormattingEnabled = true;
            this.cmbYekisi.Location = new System.Drawing.Point(117, 194);
            this.cmbYekisi.Name = "cmbYekisi";
            this.cmbYekisi.Size = new System.Drawing.Size(183, 27);
            this.cmbYekisi.TabIndex = 4;
            this.cmbYekisi.SelectedIndexChanged += new System.EventHandler(this.cmbYekisi_SelectedIndexChanged);
            // 
            // cmbKullaniciAdi
            // 
            this.cmbKullaniciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKullaniciAdi.FormattingEnabled = true;
            this.cmbKullaniciAdi.Location = new System.Drawing.Point(117, 116);
            this.cmbKullaniciAdi.Name = "cmbKullaniciAdi";
            this.cmbKullaniciAdi.Size = new System.Drawing.Size(183, 27);
            this.cmbKullaniciAdi.TabIndex = 0;
            // 
            // lblyetkiler
            // 
            this.lblyetkiler.AutoSize = true;
            this.lblyetkiler.Location = new System.Drawing.Point(355, 9);
            this.lblyetkiler.Name = "lblyetkiler";
            this.lblyetkiler.Size = new System.Drawing.Size(35, 13);
            this.lblyetkiler.TabIndex = 8;
            this.lblyetkiler.Text = "label6";
            // 
            // yetkiListBox
            // 
            this.yetkiListBox.FormattingEnabled = true;
            this.yetkiListBox.Location = new System.Drawing.Point(345, 38);
            this.yetkiListBox.Name = "yetkiListBox";
            this.yetkiListBox.Size = new System.Drawing.Size(154, 184);
            this.yetkiListBox.TabIndex = 9;
            // 
            // KullaniciYetkiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 305);
            this.Controls.Add(this.yetkiListBox);
            this.Controls.Add(this.lblyetkiler);
            this.Controls.Add(this.cmbKullaniciAdi);
            this.Controls.Add(this.cmbYekisi);
            this.Controls.Add(this.kulıptlbtn);
            this.Controls.Add(this.kulkaybtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciYetkiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Duzenle";
            this.Load += new System.EventHandler(this.KullaniciDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kulkaybtn;
        private System.Windows.Forms.Button kulıptlbtn;
        private System.Windows.Forms.ComboBox cmbYekisi;
        private System.Windows.Forms.ComboBox cmbKullaniciAdi;
        private System.Windows.Forms.Label lblyetkiler;
        private System.Windows.Forms.CheckedListBox yetkiListBox;
    }
}