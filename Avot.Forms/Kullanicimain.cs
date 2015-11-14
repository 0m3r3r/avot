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


namespace Avot.Forms
{
    public partial class Kullanicimain : Form
    {
        public Kullanicimain()
        {
            InitializeComponent();
        }
        KullaniciService Kullaniciservis = new KullaniciService();


        private void Kullanicimain_Load(object sender, EventArgs e)
        {
            foreach (KullaniciDTO item in Kullaniciservis.Select())
            {
                ListViewItem li = new ListViewItem();

                li.Text = item.KullaniciAdi;
                li.SubItems.Add(item.Adi);
                li.SubItems.Add(item.Soyadi);
                li.SubItems.Add(item.Sifre);
                li.Tag = item.ID;

                lstKullanici.Items.Add(li);
            }
        }

        private void kulekelebtn_Click(object sender, EventArgs e)
        {
            KullaniciKayit kullanicifrm = new KullaniciKayit();
            kullanicifrm.Show();
        }

        private void kulduzbtn_Click(object sender, EventArgs e)
        {
            KullaniciYetkiDuzenle kulldufrm = new KullaniciYetkiDuzenle((int)lstKullanici.FocusedItem.Tag);
            kulldufrm.Show();
        }


    }
}
