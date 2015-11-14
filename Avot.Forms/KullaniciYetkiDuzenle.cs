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
    public partial class KullaniciYetkiDuzenle : Form
    {
        public const string PERMISSION = "Ekle";
        public KullaniciYetkiDuzenle()
        {            
            InitializeComponent();

            if (! giris.user.YetkiErisimi(Permission.Kullanici_AdminYetki.Goruntule))
            {
                MessageBox.Show("Giris yetkisi yok");
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        int ID;
        public KullaniciYetkiDuzenle(int DuzenlenecekKullaniciID)
        {
            InitializeComponent();
            ID = DuzenlenecekKullaniciID;
        }

        KullaniciService kullService = new KullaniciService();
        KullaniciYetkiService kullyetkiservis = new KullaniciYetkiService();

        private void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
          foreach (KullaniciDTO item in kullService.Select().Where(p => p.ID == ID))
            {
                txtAdi.Text = item.Adi;
                txtSoyadi.Text = item.Soyadi;
                cmbKullaniciAdi.SelectedValue = item.KullaniciAdi;
                txtSifre.Text = item.Sifre;
            }

            cmbKullaniciAdi.DataSource = kullService.Select();
            cmbKullaniciAdi.DisplayMember = "KullaniciAdi";
            cmbKullaniciAdi.ValueMember = "ID";
            
            cmbYekisi.DataSource = Permission.Listpermission();
            cmbYekisi.DisplayMember = "Display";
            cmbYekisi.ValueMember = "Value";
            string fullname = cmbYekisi.SelectedValue.ToString();
            yetkiListBox.DataSource = Permission.PermissionDetail(fullname);
           

            //foreach (KullaniciDTO item in kullService.Select())
            //{
            //    cmbKullaniciAdi.Items.Add(item.KullaniciAdi);
            //    cmbKullaniciAdi.SelectedIndex = 0;
            //}

            //foreach (KullaniciYetkiDTO item in kullyetkiservis.Select())
            //{
            //    cmbYekisi.Items.Add(item.KullaniciYetkiAciklama);
            //    cmbYekisi.SelectedIndex = item.KullaniciYetkiID;
            //}

          
        }

        private void kulkaybtn_Click(object sender, EventArgs e)
        {

        }

        private void kulıptlbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbYekisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblyetkiler.Text = cmbYekisi.SelectedValue.ToString().Substring(30);
            
            cmbYekisi.DisplayMember = "Display";
            cmbYekisi.ValueMember = "Value";

            string fullname = cmbYekisi.SelectedValue.ToString();
            yetkiListBox.DataSource = Permission.PermissionDetail(fullname);
            
            
            
        }


    }
}
