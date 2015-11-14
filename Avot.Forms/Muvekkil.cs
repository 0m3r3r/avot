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
    public partial class Muvekkil : Form
    {
        public Muvekkil()
        {
            InitializeComponent();
        }

        MuvekkilService mService = new MuvekkilService();

        private void MuvekkilLoad()
        {
            foreach (MuvekkilDTO item in mService.Select())
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Ad;
                li.SubItems.Add(item.Soyad);
                li.SubItems.Add(item.TC);
                li.SubItems.Add(item.Cinsiyet == true ? "Erkek" : "Bayan");//Ternary if.True ise erkek, False ise bayan basacak ekrana.
                li.Tag = item.ID;

                lstMuvekkil.Items.Add(li);
            }
        }

        private void Muvekkil_Load(object sender, EventArgs e)
        {
            MuvekkilLoad();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            MuvekkilKayitGuncelleme frm = new MuvekkilKayitGuncelleme();
            frm.Show();
            this.Hide();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MuvekkilKayitGuncelleme frm = new MuvekkilKayitGuncelleme((int)lstMuvekkil.FocusedItem.Tag);
            frm.Show();
            this.Hide();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ds = MessageBox.Show("Seçili öğeyi silmek istediğnize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ds == DialogResult.Yes)
                {
                    MuvekkilDTO mdto = new MuvekkilDTO()
                    {
                        ID = Convert.ToInt32(lstMuvekkil.FocusedItem.Tag),
                    };
                    mService.Delete(mdto);

                    lstMuvekkil.Clear();
                    MuvekkilLoad();
                }
            }
            catch (Exception)
            {
                Messages.itemSeciniz();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
