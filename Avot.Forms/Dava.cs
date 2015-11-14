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
    public partial class Dava : Form
    {
        public Dava()
        {
            InitializeComponent();
        }

        DavaService dService = new DavaService();

        private void DavaLoad()
        {
            foreach (DavaDTO item in dService.Select())
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.DosyaNo;
                li.SubItems.Add(item.Davali);
                li.SubItems.Add(item.Davaci);
                li.SubItems.Add(item.Savci1);
                li.SubItems.Add(Convert.ToString(item.MahkemeID));
                li.Tag = item.ID;

                lstDava.Items.Add(li);
            }
        }

        private void Dava_Load(object sender, EventArgs e)
        {
            DavaLoad();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            DavaKayitGuncelleme frm = new DavaKayitGuncelleme();
            frm.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DavaKayitGuncelleme frm = new DavaKayitGuncelleme((int)lstDava.FocusedItem.Tag);
            frm.Show();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            DialogResult ds = MessageBox.Show("Seçili itemi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ds == DialogResult.Yes)
            {
                try
                {
                    DavaDTO adto = new DavaDTO()
                    {
                        ID = (int)lstDava.FocusedItem.Tag
                    };

                    dService.Delete(adto);

                    lstDava.Clear();
                    DavaLoad();

                    Messages.silindi();
                }
                catch (NullReferenceException)
                {
                    Messages.itemSeciniz();
                }
                catch
                {
                    Messages.SifreDegistirmeBasarili();
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCelsegr_Click(object sender, EventArgs e)
        {
            Celse frm = new Celse((int)lstDava.FocusedItem.Tag);
            frm.Show();
        }
    }
}