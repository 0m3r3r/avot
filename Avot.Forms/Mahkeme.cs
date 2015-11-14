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
    public partial class Mahkeme : Form
    {
        public Mahkeme()
        {
            InitializeComponent();
        }

        MahkemeService mService = new MahkemeService();

        private void MahkemeLoad()
        {
            foreach (MAhkemeDTO item in mService.Select())
            {
                ListViewItem li = new ListViewItem();

                li.Text = item.MahkemeAdi;
                li.SubItems.Add(item.MahkemeNO);
                li.SubItems.Add(item.MahkemeTuru);
                li.SubItems.Add(item.ILID.ToString());
                li.Tag = item.ID;

                lstMahkeme.Items.Add(li);
            }
        }

        private void Mahkeme_Load(object sender, EventArgs e)
        {
            MahkemeLoad();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            MahkemeKayitGuncelleme frm = new MahkemeKayitGuncelleme();
            frm.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            MahkemeKayitGuncelleme frm = new MahkemeKayitGuncelleme((int)lstMahkeme.FocusedItem.Tag);
            frm.Show();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ds = MessageBox.Show("Seçili öğeyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ds == DialogResult.Yes)
                {
                    MAhkemeDTO mdto = new MAhkemeDTO()
                    {
                        ID = Convert.ToInt32(lstMahkeme.FocusedItem.Tag),
                    };
                    mService.Delete(mdto);

                    lstMahkeme.Clear();
                    MahkemeLoad();
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
