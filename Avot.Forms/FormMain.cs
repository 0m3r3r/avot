using Avot.Forms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avot.service;
using Avot.DAO;

namespace Avot.Forms
{
    public partial class FormMain : Form 
    {
        public FormMain()
        {
            InitializeComponent();
            giris.user.LoadPermission();
        }

        private void ribboncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ribbondavabtn_Click(object sender, EventArgs e)
        {
            Dava frmdava = new Dava();
            frmdava.ShowDialog();
        }

        private void davabtn_Click(object sender, EventArgs e)
        {
            Dava frmdava = new Dava();
            frmdava.ShowDialog();
        }

        private void mahkemebtn_Click(object sender, EventArgs e)
        {
            MahkemeKayitGuncelleme frm = new MahkemeKayitGuncelleme();
            frm.ShowDialog();
        }

        private void davaguncelbtn_Click(object sender, EventArgs e)
        {
            DavaKayitGuncelleme frm = new DavaKayitGuncelleme();
            frm.ShowDialog();
        }

        private void Celse_Click(object sender, EventArgs e)
        {
            Celse frm = new Celse();
            frm.ShowDialog();
        }

        private void celsekayitbtn_Click(object sender, EventArgs e)
        {
            CelseKayitGuncelleme frm = new CelseKayitGuncelleme();
            frm.ShowDialog();
        }

        private void avukatbtn_Click(object sender, EventArgs e)
        {
            Avukat frm = new Avukat();
            frm.ShowDialog();
        }

        private void avukatguncellbtn_Click(object sender, EventArgs e)
        {
            AvukatKayitGuncelleme frm = new AvukatKayitGuncelleme();
            frm.ShowDialog();
        }

        private void Mahkemetnmbtn_Click(object sender, EventArgs e)
        {
            Mahkeme frm = new Mahkeme();
            frm.ShowDialog();
        }

        private void muvekkilbtn_Click(object sender, EventArgs e)
        {
            Muvekkil frm = new Muvekkil();
            frm.ShowDialog();
        }

        private void muvekkilgnclbtn_Click(object sender, EventArgs e)
        {
            MuvekkilKayitGuncelleme frm = new MuvekkilKayitGuncelleme();
            frm.ShowDialog();
        }

        private void hakbtn_Click(object sender, EventArgs e)
        {
            Hakkinda frm = new Hakkinda();
            frm.Show();
        }

        private void mhkraporlistbtn_Click(object sender, EventArgs e)
        {
            MahkemeRapor frm = new MahkemeRapor();
            frm.Show();
        }

        private void davaraporlistbtn_Click(object sender, EventArgs e)
        {
            DavaRapor frm = new DavaRapor();
            frm.Show();
        }

        private void celseraporlistbtn_Click(object sender, EventArgs e)
        {
            CelseRapor frm = new CelseRapor();
            frm.Show();
        }

        private void btnAvukatRapor_Click(object sender, EventArgs e)
        {
            AvukatRapor frm = new AvukatRapor();
            frm.Show();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            SifreDegistir frm = new SifreDegistir();
            frm.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            SifreDegistir frm = new SifreDegistir();
            frm.ShowDialog();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            BuroBilgileri frm = new BuroBilgileri();
            frm.ShowDialog();
        }

        private void btnSayfaTanimla_Click(object sender, EventArgs e)
        {
            WebSayfasiKayit frm = new WebSayfasiKayit();
            frm.ShowDialog();
        }

        private void uyapbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uyap.gov.tr/");
        }

        private void avportalbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://avukat.uyap.gov.tr/avukatportal/index.jsp");
        }

        private void kullanici_Click(object sender, EventArgs e)
        {

        }

        private void kullanicikayitguncelleme_Click(object sender, EventArgs e)
        {
            KullaniciYetkiDuzenle frm = new KullaniciYetkiDuzenle();
            frm.ShowDialog();
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            Kullanicimain frm = new Kullanicimain();
            frm.ShowDialog();
        }

        private void davva_Click(object sender, EventArgs e)
        {
            Dava frm = new Dava();
            frm.ShowDialog();
        }

        private void davvakytgnc_Click(object sender, EventArgs e)
        {
            DavaKayitGuncelleme frm = new DavaKayitGuncelleme();
            frm.ShowDialog();
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            DavaRapor frm = new DavaRapor();
            frm.ShowDialog();
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            MuvekkilRapor frm = new MuvekkilRapor();
            frm.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

    }
}
