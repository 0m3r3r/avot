namespace Avot.Forms
{
    partial class MahkemeKayitGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MahkemeKayitGuncelleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMahkemeAdi = new System.Windows.Forms.TextBox();
            this.txtMahkemeNo = new System.Windows.Forms.TextBox();
            this.txtMahkemeTuru = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmbil = new System.Windows.Forms.ComboBox();
            this.Cmbilce = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mahkeme Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mahkeme No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mahkeme Türü : ";
            // 
            // txtMahkemeAdi
            // 
            this.txtMahkemeAdi.Location = new System.Drawing.Point(107, 6);
            this.txtMahkemeAdi.Multiline = true;
            this.txtMahkemeAdi.Name = "txtMahkemeAdi";
            this.txtMahkemeAdi.Size = new System.Drawing.Size(211, 46);
            this.txtMahkemeAdi.TabIndex = 0;
            // 
            // txtMahkemeNo
            // 
            this.txtMahkemeNo.Location = new System.Drawing.Point(108, 58);
            this.txtMahkemeNo.Name = "txtMahkemeNo";
            this.txtMahkemeNo.Size = new System.Drawing.Size(210, 20);
            this.txtMahkemeNo.TabIndex = 1;
            // 
            // txtMahkemeTuru
            // 
            this.txtMahkemeTuru.Location = new System.Drawing.Point(108, 138);
            this.txtMahkemeTuru.Name = "txtMahkemeTuru";
            this.txtMahkemeTuru.Size = new System.Drawing.Size(210, 20);
            this.txtMahkemeTuru.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(187, 164);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(107, 164);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(74, 23);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "il : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ilçe : ";
            // 
            // Cmbil
            // 
            this.Cmbil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbil.FormattingEnabled = true;
            this.Cmbil.Location = new System.Drawing.Point(107, 84);
            this.Cmbil.Name = "Cmbil";
            this.Cmbil.Size = new System.Drawing.Size(210, 21);
            this.Cmbil.TabIndex = 8;
            this.Cmbil.SelectedIndexChanged += new System.EventHandler(this.Cmbil_SelectedIndexChanged);
            // 
            // Cmbilce
            // 
            this.Cmbilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbilce.Enabled = false;
            this.Cmbilce.FormattingEnabled = true;
            this.Cmbilce.Location = new System.Drawing.Point(107, 111);
            this.Cmbilce.Name = "Cmbilce";
            this.Cmbilce.Size = new System.Drawing.Size(210, 21);
            this.Cmbilce.TabIndex = 9;
            // 
            // MahkemeKayitGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 206);
            this.Controls.Add(this.Cmbilce);
            this.Controls.Add(this.Cmbil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMahkemeTuru);
            this.Controls.Add(this.txtMahkemeNo);
            this.Controls.Add(this.txtMahkemeAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MahkemeKayitGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahkeme Tanim Ekrani";
            this.Load += new System.EventHandler(this.MahkemeGuncellemeKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMahkemeAdi;
        private System.Windows.Forms.TextBox txtMahkemeNo;
        private System.Windows.Forms.TextBox txtMahkemeTuru;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmbil;
        private System.Windows.Forms.ComboBox Cmbilce;
    }
}