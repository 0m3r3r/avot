using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avot.DAO;
using Avot.service;
using Avot.Forms.Classes;

namespace Avot.Forms
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        KullaniciService kService = new KullaniciService();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEskiSifre.Text) || string.IsNullOrEmpty(txtYeniSifre.Text) || string.IsNullOrEmpty(txtYeniSifreTekrar.Text))
            {
                MessageBox.Show("Tüm alanları eksiksiz doldurmanız gerekmekte", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    foreach (KullaniciDTO item in kService.Select().Where(p => p.KullaniciAdi == User.KAd()))
                    {
                        if (item.Sifre == txtEskiSifre.Text)
                        {
                            kService.SifreDegistir(new KullaniciDTO()
                                {
                                    ID = User.ID(),
                                    Sifre = txtYeniSifreTekrar.Text,
                                });

                            MessageBox.Show("Şifre değiştirme işlemi başarılı.");
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Eski Şifre Bilgisi Doğru Değil !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz yeni şifre alanları birbirleri ile uyuşmuyır !");
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
