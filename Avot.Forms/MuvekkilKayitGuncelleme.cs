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
    public partial class MuvekkilKayitGuncelleme : Form
    {
        public MuvekkilKayitGuncelleme()
        {
            InitializeComponent();
        }

        int ID;
        public MuvekkilKayitGuncelleme(int GuncellenecekItemID)
        {
            InitializeComponent();
            ID = GuncellenecekItemID;
        }

        MuvekkilService mService = new MuvekkilService();
        NufusDetayService nService = new NufusDetayService();
        AdresService aService = new AdresService();
        ililceService iiService = new ililceService();

        private void AdresilceFill(string ilAdi)
        {
            /* Eski Denemeler
            cmbAdresilce.Items.Clear();

            cmbAdresilce.DataSource = iiService.Select().Where(p=>p.);
            cmbAdresilce.DisplayMember = "Ilce";
            cmbAdresilce.ValueMember = "ILID";

            foreach (var item in query)
            {
                cmbAdresilce.Items.Add(item.Ilce);
            }
            */

            //sorgu istenildiği gibi linq yardımı ile çekiliyor.
            //aldığım query objesini de datasource olarak veriyorum ve query içerisinde tanımladığım özellikleri de yine aynı şekilde içerisinde kullanıyorum.Bunu kullandıktan sonra cmb.items.clear a gerek kalmıyor.kullanılır ise argument exception veriyor.
            var query = (from iis in iiService.Select() // select * from kullanici
                         where iis.Il == ilAdi          // kullanıcının cmb den setiği il adını alıyoruz
                         select new { iis.Ilce, iis.ILID }).ToList(); // seçilen il adına istinaden ilçe basıyoruz.select * from blümündeki * olarak tanımlayabiliriz burayı.sorguyu alırken ilce ve ilcekodu bölümlerini istediğimi söylüyorum.

            CmbAdresilce.DataSource = query;
            CmbAdresilce.DisplayMember = "Ilce";
            CmbAdresilce.ValueMember = "ILID";
        }

        private void KimlikilceFill(string ilAdi)
        {
            var query = (from iis in iiService.Select()
                         where iis.Il == ilAdi
                         select new { iis.Ilce, iis.ILID }).ToList();

            CmbKimlikilce.DataSource = query;
            CmbKimlikilce.DisplayMember = "Ilce";
            CmbKimlikilce.ValueMember = "ILID";
        }

        private void dataSave()
        {
            //try
            //{
            aService.Insert(new AdresDTO()
            {
                AdresBaglantiliKisiTC = mtxtTC.Text,//kişi TC sini alıp tablo içerisindeki identity PK kolonuna basıyor.
                ILID = (int)CmbAdresilce.SelectedValue,
                Tel1 = txtTel1.Text,
                Tel2 = txtTel2.Text,
                Tel3 = txtTel3.Text,
                Fax = txtFax.Text,
                EMail = txtEmail.Text,
                SubeKodu = txtSubeKodu.Text,
                BankaAdi = txtBankaAdi.Text,
                HesapNo = txtHesapNo.Text,
                IBAN = txtIBAN.Text,
                AdresAciklama = txtAdresAciklama.Text,
                KaydiGirenKullaniciID = User.ID(),
                KaydiDegistirenKullaniciID = User.ID(),
                KayitTarihi = DateTime.Now,
                KaydiDegistirmeTarihi = DateTime.Now,
                Aktifmi = true,
            });

            nService.Insert(new NufusDetayDTO()
            {
                NufusBaglantiliKisiTC = mtxtTC.Text,//kişi TC sini alıp tablo içerisindeki identity PK kolonuna basıyor.
                NufusCuzdaniSeriNo = txtNufusCuzdaniSeriNo.Text,
                NufusCuzdaniNo = txtNufusCuzdaniNo.Text,
                AnaAdi = txtAnaAdi.Text,
                BabaAdi = txtBabaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Dini = txtDini.Text,
                KanGrubu = txtKanGrubu.Text,
                ILID = Convert.ToInt32(CmbKimlikilce.SelectedValue),
                Mahalle = txtMahalle.Text,
                Koy = txtKoy.Text,
                CiltNo = txtCiltNo.Text,
                AileSiraNo = txtAileSiraNo.Text,
                SiraNo = txtSiraNo.Text,
                NufusKayitnNo = txtNufusKayitNo.Text,
                VerilisTarihi = dtpVerilisTarihi.Value,
                VerilisNedeni = txtVerilisNedeni.Text,
                VerildigiYer = txtVerildiğiYer.Text,
                KaydiGirenKullaniciID = User.ID(),
                KaydiDegistirenKullaniciID = User.ID(),
                KayitTarihi = DateTime.Now,
                KaydiDegistirmeTarihi = DateTime.Now,
                Aktifmi = true,
            });

            mService.Insert(new MuvekkilDTO()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TC = mtxtTC.Text,
                Cinsiyet = cmbCinsiyet.Text == "Erkek" ? true : false,
                KaydiGirenKullaniciID = User.ID(),
                KaydiDegistirenKullaniciID = User.ID(),
                KayitTarihi = DateTime.Now,
                KaydiDegistirmeTarihi = DateTime.Now,
                Aktifmi = true,
            });

            Messages.kayitBasarili();
            textxboxTemizle(this);
            //}
            //catch (Exception ex)
            //{
            //    Messages.kayitBasarisiz(ex.Message);
            //}
        } // KAYIT GİRİŞİ

        private void textxboxTemizle(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)
                {
                    textxboxTemizle(c);
                }
            }
        } // TEXTBOX TEMİZLEME

        private void MuvekkilKayitGuncelleme_Load(object sender, EventArgs e)
        {
            if (!(ID < 0))
            {
                foreach (MuvekkilDTO item in mService.Select().Where(p => p.ID == ID))
                {
                    txtAd.Text = item.Ad;
                    txtSoyad.Text = item.Soyad;
                    mtxtTC.Text = item.TC;
                    cmbCinsiyet.Text = item.Cinsiyet == true ? "Erkek" : "Bayan";
                }

                foreach (NufusDetayDTO item in nService.Select().Where(p => p.NufusBaglantiliKisiTC == mtxtTC.Text))
                {
                    txtNufusCuzdaniSeriNo.Text = item.NufusCuzdaniSeriNo;
                    txtNufusCuzdaniNo.Text = item.NufusCuzdaniNo;
                    txtAnaAdi.Text = item.AnaAdi;
                    txtBabaAdi.Text = item.BabaAdi;
                    txtDogumYeri.Text = item.DogumYeri;
                    dtpDogumTarihi.Value = item.DogumTarihi;
                    txtDini.Text = item.Dini;
                    txtKanGrubu.Text = item.KanGrubu;
                    CmbKimlikil.SelectedValue = item.ILID;
                    txtMahalle.Text = item.Mahalle;
                    txtKoy.Text = item.Mahalle;
                    txtCiltNo.Text = item.CiltNo;
                    txtAileSiraNo.Text = item.AileSiraNo;
                    txtSiraNo.Text = item.SiraNo;
                    txtNufusKayitNo.Text = item.NufusKayitnNo;
                    dtpVerilisTarihi.Value = item.VerilisTarihi;
                    txtVerilisNedeni.Text = item.VerilisNedeni;
                    txtVerildiğiYer.Text = item.VerildigiYer;
                }

                foreach (AdresDTO item in aService.Select().Where(p => p.AdresBaglantiliKisiTC == mtxtTC.Text))
                {
                    CmbKimlikil.SelectedValue = item.ILID;
                    txtTel1.Text = item.Tel1;
                    txtTel2.Text = item.Tel2;
                    txtTel3.Text = item.Tel3;
                    txtFax.Text = item.Fax;
                    txtEmail.Text = item.EMail;
                    txtSubeKodu.Text = item.SubeKodu;
                    txtBankaAdi.Text = item.BankaAdi;
                    txtHesapNo.Text = item.HesapNo;
                    txtIBAN.Text = item.IBAN;
                    txtAdresAciklama.Text = item.AdresAciklama;
                }
            }


            var query = (from iis in iiService.Select()
                         select new { iis.Il }).Distinct().ToList();

            foreach (var item in query)
            {
                CmbAdresil.Items.Add(item.Il);
                CmbKimlikil.Items.Add(item.Il);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dataSave();
        }

        private void btnKaydetUst_Click(object sender, EventArgs e)
        {
            dataSave();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtAd.Text) && string.IsNullOrEmpty(txtSoyad.Text) && string.IsNullOrEmpty(mtxtTC.Text)))
            {
                DialogResult ds = MessageBox.Show("Girilmiş veriler var, kaybedeceksiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (ds == DialogResult.Yes)
                {
                    textxboxTemizle(this);
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Muvekkil frm = new Muvekkil();
            frm.Show();
            this.Hide();
        }

        private void CmbKimlikil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ilAdi = CmbKimlikil.SelectedItem.ToString();
            KimlikilceFill(ilAdi);
            CmbKimlikilce.Enabled = true;
        }

        private void CmbAdresil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ilAdi = CmbAdresil.SelectedItem.ToString();
            AdresilceFill(ilAdi);
            CmbAdresilce.Enabled = true;
        }
    }
}
