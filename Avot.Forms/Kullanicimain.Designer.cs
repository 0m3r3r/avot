namespace Avot.Forms
{
    partial class Kullanicimain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanicimain));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.kulekelebtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.kulduzbtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonDescriptionMenuItem1 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.lstKullanici = new System.Windows.Forms.ListView();
            this.KullaniciAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sifre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(615, 103);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Kullanıcılar";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.kulekelebtn);
            this.ribbonPanel1.Text = "Kullanıcı Ekle";
            // 
            // kulekelebtn
            // 
            this.kulekelebtn.Image = global::Avot.Forms.Properties.Resources._1418257582_photo_32;
            this.kulekelebtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("kulekelebtn.SmallImage")));
            this.kulekelebtn.Click += new System.EventHandler(this.kulekelebtn_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.kulduzbtn);
            this.ribbonPanel2.Text = "Kullanıcı Düzenle";
            // 
            // kulduzbtn
            // 
            this.kulduzbtn.Image = global::Avot.Forms.Properties.Resources._1418257582_photo_32;
            this.kulduzbtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("kulduzbtn.SmallImage")));
            this.kulduzbtn.Click += new System.EventHandler(this.kulduzbtn_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Text = null;
            // 
            // ribbonDescriptionMenuItem1
            // 
            this.ribbonDescriptionMenuItem1.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.Image")));
            this.ribbonDescriptionMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.SmallImage")));
            // 
            // lstKullanici
            // 
            this.lstKullanici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KullaniciAdi,
            this.Adi,
            this.Soyadi,
            this.Sifre});
            this.lstKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKullanici.FullRowSelect = true;
            this.lstKullanici.GridLines = true;
            this.lstKullanici.Location = new System.Drawing.Point(0, 103);
            this.lstKullanici.Name = "lstKullanici";
            this.lstKullanici.Size = new System.Drawing.Size(615, 291);
            this.lstKullanici.TabIndex = 1;
            this.lstKullanici.UseCompatibleStateImageBehavior = false;
            this.lstKullanici.View = System.Windows.Forms.View.Details;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Text = "Kullanıcı Adı";
            this.KullaniciAdi.Width = 160;
            // 
            // Adi
            // 
            this.Adi.Text = "Adı";
            this.Adi.Width = 148;
            // 
            // Soyadi
            // 
            this.Soyadi.Text = "Soyadı";
            this.Soyadi.Width = 167;
            // 
            // Sifre
            // 
            this.Sifre.Text = "Şifre";
            this.Sifre.Width = 134;
            // 
            // Kullanicimain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 394);
            this.Controls.Add(this.lstKullanici);
            this.Controls.Add(this.ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanicimain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanicimain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton kulekelebtn;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton kulduzbtn;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem1;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.ListView lstKullanici;
        private System.Windows.Forms.ColumnHeader KullaniciAdi;
        private System.Windows.Forms.ColumnHeader Adi;
        private System.Windows.Forms.ColumnHeader Soyadi;
        private System.Windows.Forms.ColumnHeader Sifre;
    }
}