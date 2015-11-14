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
    public partial class DavaKayitGuncelleme : Form
    {
        public DavaKayitGuncelleme()
        {
            InitializeComponent();
        }

        private void dataSave()
        {
            try
            {
                dService.Insert(new DavaDTO()
                {
                    AvukatID = (int)cmbTarafinAvukati.SelectedValue,
                    MahkemeID = (int)cmbMahkeme.SelectedValue,
                    DosyaNo = txtDosyaNo.Text,
                    DavaTipi = txtDavaTipi.Text,
                    DavaDurumu = txtDavaDurumu.Text,
                    DavaKonusu = txtDavaKonusu.Text,
                    DavaAcildigiTarih = dtpDavaAcildigiTarih.Value,
                    Savci1 = txtSavci1.Text,
                    Savci2 = txtSavci2.Text,
                    DavaBedeli = Convert.ToDecimal(txtDavaBedeli.Text),
                    KarsiTarafAvukatAd = txtKarsiAvukatAd.Text,
                    KarsiTarafAvukatSoyad = txtKarsiAvukatSoyad.Text,
                    KarsiTarafAvukatAdres = txtKarsiAvukatAdres.Text,
                    KarsiTarafAvukatTelefon = txtKarsiAvukatTelefon.Text,
                    Davaci = txtDavaci.Text,
                    Davali = txtDavali.Text,
                    KaydiGirenKullaniciID = User.ID(),
                    KaydiDegistirenKullaniciID = User.ID(),
                    KayitTarihi = DateTime.Now,
                    KaydiDegistirmeTarihi = DateTime.Now,
                    Aktifmi = true,
                });

                Messages.kayitBasarili();
            }
            catch (Exception ex)
            {
                Messages.kayitBasarisiz(ex.Message);
            }
        }
        private void dataUpdate()
        {
            try
            {
                dService.Update(new DavaDTO()
                {
                    ID = ID,
                    DosyaNo = txtDosyaNo.Text,
                    DavaTipi = txtDavaTipi.Text,
                    DavaDurumu = txtDavaDurumu.Text,
                    DavaKonusu = txtDavaKonusu.Text,
                    DavaAcildigiTarih = dtpDavaAcildigiTarih.Value,
                    Savci1 = txtSavci1.Text,
                    Savci2 = txtSavci2.Text,
                    DavaBedeli = Convert.ToDecimal(txtDavaBedeli.Text),
                    AvukatID = (int)cmbTarafinAvukati.SelectedValue,
                    Davaci = txtDavaci.Text,
                    Davali = txtDavali.Text,
                    MahkemeID = (int)cmbMahkeme.SelectedValue,
                    KarsiTarafAvukatAd = txtKarsiAvukatAd.Text,
                    KarsiTarafAvukatSoyad = txtKarsiAvukatSoyad.Text,
                    KarsiTarafAvukatAdres = txtKarsiAvukatAdres.Text,
                    KarsiTarafAvukatTelefon = txtKarsiAvukatTelefon.Text,
                    KaydiDegistirenKullaniciID = User.ID(),
                    KaydiDegistirmeTarihi = DateTime.Now,
                });
                Messages.GuncellemeBasarili();
            }
            catch (Exception ex)
            {
                Messages.GuncellemeBasarisiz(ex.Message);
            }
        }

        int ID;
        public DavaKayitGuncelleme(int GuncellenecekItemID)
        {
            InitializeComponent();
            ID = GuncellenecekItemID;
        }

        DavaService dService = new DavaService();
        MahkemeService mService = new MahkemeService();
        AvukatService aService = new AvukatService();
        private void DavaKayitGuncelleme_Load(object sender, EventArgs e)
        {
            cmbMahkeme.DataSource = mService.Select();
            cmbMahkeme.DisplayMember = "MahkemeAdi";
            cmbMahkeme.ValueMember = "ID";

            cmbTarafinAvukati.DataSource = aService.Select();
            cmbTarafinAvukati.DisplayMember = "Adi";
            cmbTarafinAvukati.ValueMember = "ID";

            if (!(ID <= 0))
            {
                foreach (DavaDTO item in dService.Select().Where(p => p.ID == ID))
                {
                    txtDosyaNo.Text = item.DosyaNo;
                    txtDavaTipi.Text = item.DavaTipi;
                    txtDavaDurumu.Text = item.DavaDurumu;
                    txtDavaKonusu.Text = item.DavaKonusu;
                    dtpDavaAcildigiTarih.Value = item.DavaAcildigiTarih;
                    txtSavci1.Text = item.Savci1;
                    txtSavci2.Text = item.Savci2;
                    txtDavaBedeli.Text = item.DavaBedeli.ToString();
                    cmbTarafinAvukati.SelectedValue = item.AvukatID;
                    txtDavaci.Text = item.Davaci;
                    txtDavali.Text = item.Davali;
                    cmbMahkeme.SelectedValue = item.MahkemeID;
                    txtKarsiAvukatAd.Text = item.KarsiTarafAvukatAd;
                    txtKarsiAvukatSoyad.Text = item.KarsiTarafAvukatSoyad;
                    txtKarsiAvukatAdres.Text = item.KarsiTarafAvukatAdres;
                    txtKarsiAvukatTelefon.Text = item.KarsiTarafAvukatTelefon;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ID <= 0)
            {//gelen id 0 veya küçükse datakaydet
                dataSave();
            }
            else
            {//0 dan büyük ise update yap
                dataUpdate();
            }
        }

        private void btnKaydetUst_Click(object sender, EventArgs e)
        {
            if (ID <= 0)
            {//gelen id 0 veya küçükse datakaydet
                dataSave();
            }
            else
            {//0 dan büyük ise update yap
                dataUpdate();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Dava frm = new Dava();
            frm.Show();
            this.Hide();
        }

        private void btnCelse_Click(object sender, EventArgs e)
        {
            Celse frm = new Celse(ID);
            frm.Show();
        }
    }
}
