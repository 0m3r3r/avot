using Avot.DAO;
using Avot.Forms.Classes;
using Avot.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avot.Forms
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciService kService = new KullaniciService();

                kService.Insert(new KullaniciDTO()
                {
                    Adi = txtAdi.Text,
                    Soyadi = txtSoyadi.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    KaydiGirenKullaniciID = User.ID(),
                    KaydiDegistirenKullaniciID = User.ID(),
                    KayitTarihi = DateTime.Now,
                    KaydiDegistirmeTarihi = DateTime.Now,
                    Aktifmi = true
                });

                Messages.kayitBasarili();
            }
            catch (Exception ex)
            {
                Messages.kayitBasarisiz(ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
