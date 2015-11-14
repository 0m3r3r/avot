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
using Avot.DAO;
using Avot.service;

namespace Avot.Forms
{
    public partial class Celse : Form
    {
        public Celse()
        {
            InitializeComponent();
        }

        int DavaID;
        public Celse(int GelenDavaID)
        {
            InitializeComponent();
            DavaID = GelenDavaID;
        }

        CelseService cService = new CelseService();

        private void CelseLoad()
        {
            foreach (CelseDTO item in cService.Select().Where(p => p.DavaID == DavaID))
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.CelseTarihi.ToString();
                li.SubItems.Add(item.Hakim);
                li.SubItems.Add(item.Savci);
                li.SubItems.Add(item.Karar);
                li.SubItems.Add(item.ErtelemeMazeret);
                li.SubItems.Add(item.ErtelemeTarihi.ToString());
                li.SubItems.Add(item.Aciklama);
                li.Tag = item.ID;

                lstCelse.Items.Add(li);
            }
        }

        private void Celse_Load(object sender, EventArgs e)
        {
            CelseLoad();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            CelseKayitGuncelleme frm = new CelseKayitGuncelleme(DavaID);
            frm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            CelseKayitGuncelleme frm = new CelseKayitGuncelleme(DavaID, (int)lstCelse.FocusedItem.Tag);
            frm.ShowDialog();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ds = MessageBox.Show("Seçili öğeyi silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ds == DialogResult.Yes)
                {
                    CelseDTO adto = new CelseDTO()
                    {
                        ID = (int)lstCelse.FocusedItem.Tag
                    };

                    cService.Delete(adto);

                    lstCelse.Clear();
                    CelseLoad();
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
