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
    public partial class BuroBilgileri : Form
    {
        public BuroBilgileri()
        {
            InitializeComponent();
        }

        int gelenID(int id)
        {
            return id;
        }

        BuroBilgileriService bbService = new BuroBilgileriService();
        ililceService iiService = new ililceService();

        private void ilceFill(string ilAdi)
        {
            var query = (from iis in iiService.Select()
                         where iis.Il == ilAdi
                         select new { iis.Ilce, iis.ILID }).ToList();

            cmbilce.DataSource = query;
            cmbilce.DisplayMember = "Ilce";
            cmbilce.ValueMember = "ILID";
        }
        private void BuroBilgileri_Load(object sender, EventArgs e)
        {
            if (!(bbService.Select() == null))
            {
                foreach (BuroBilgileriDTO item in bbService.Select())
                {
                    gelenID(item.ID);
                    Cmbil.SelectedValue = item.ILID;
                    cmbSorumluSabitAvukat.SelectedValue = item.SorumluSabitAvukatID;
                    txtBuroTanim.Text = item.BuroTanim;
                    txtAdres.Text = item.Adres;
                    txtAdres.Text = item.Adres;
                    txtTelefon.Text = item.Telefon;
                    txtFax.Text = item.Fax;
                    txtBaroBilgileri.Text = item.BaroBilgileri;
                    txticraDairesi.Text = item.IcraDairesi;
                }
            }

            var query = (from iis in iiService.Select()
                         select new { iis.Il }).Distinct().ToList();

            foreach (var item in query)
            {
                Cmbil.Items.Add(item.Il);
            }


            txtAdres.Enabled = txtBaroBilgileri.Enabled = txtBuroTanim.Enabled = txtFax.Enabled = txticraDairesi.Enabled = txtTelefon.Enabled = cmbilce.Enabled = cmbSorumluSabitAvukat.Enabled = Cmbil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            //foreach (Control ctl in this.Controls)

            //    if (ctl is TextBox)
            //    {
            //        if (!(ctl.Text == String.Empty))
            //        {
            //            bbService.Update(new BuroBilgileriDTO()
            //            {
            //                BuroTanim = txtBuroTanim.Text,
            //                Adres = txtAdres.Text,
            //                ILID = Convert.ToInt32(cmbililce.SelectedValue),
            //                Telefon = txtTelefon.Text,
            //                Fax = txtFax.Text,
            //                BaroBilgileri = txtBaroBilgileri.Text,
            //                IcraDairesi = txticraDairesi.Text,
            //                SorumluSabitAvukatID = Convert.ToInt32(cmbSorumluSabitAvukat.SelectedValue)
            //            });
            //        }
            //    }


            //bbService.Insert(new BuroBilgileriDTO()
            //{
            //    ILID = Convert.ToInt32(cmbililce.SelectedValue),
            //    SorumluSabitAvukatID = Convert.ToInt32(cmbSorumluSabitAvukat.SelectedValue),
            //    BuroTanim = txtBuroTanim.Text,
            //    Adres = txtAdres.Text,
            //    Telefon = txtAdres.Text,
            //    Fax = txtFax.Text,
            //    BaroBilgileri = txtBaroBilgileri.Text,
            //    IcraDairesi = txticraDairesi.Text
            //});

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (btnDuzenle.Text == "Düzenle")
            {
                txtAdres.Enabled = txtBaroBilgileri.Enabled = txtBuroTanim.Enabled = txtFax.Enabled = txticraDairesi.Enabled = txtTelefon.Enabled = Cmbil.Enabled = cmbSorumluSabitAvukat.Enabled = true;
                btnDuzenle.Text = "D. Kapat";
            }
            else
            {
                txtAdres.Enabled = txtBaroBilgileri.Enabled = txtBuroTanim.Enabled = txtFax.Enabled = txticraDairesi.Enabled = txtTelefon.Enabled = Cmbil.Enabled = cmbSorumluSabitAvukat.Enabled = false;
                btnDuzenle.Text = "Düzenle";
            }
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ilAdi = Cmbil.SelectedItem.ToString();
            ilceFill(ilAdi);
            cmbilce.Enabled = true;
        }
    }
}
