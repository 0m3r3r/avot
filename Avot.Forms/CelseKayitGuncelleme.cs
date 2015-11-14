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
    public partial class CelseKayitGuncelleme : Form
    {
        public CelseKayitGuncelleme()
        {
            InitializeComponent();
        }

        int DavID;
        int CelsID;
        public CelseKayitGuncelleme(int DavaID, int CelseID)
        {
            InitializeComponent();
            DavID = DavaID;
            CelsID = CelseID;
        }

        public CelseKayitGuncelleme(int DavaID)
        {
            InitializeComponent();
            DavID = DavaID;
        }


        CelseService cService = new CelseService();

        private void dataSave()
        {
            try
            {
                cService.Insert(new CelseDTO()
                {
                    DavaID = DavID,
                    AvukatID = (int)cmbAvukat.SelectedValue,
                    CelseTarihi = dtpCelseTarihi.Value,
                    Hakim = txtHakim.Text,
                    Savci = txtSavci.Text,
                    Karar = txtKarar.Text,
                    ErtelemeMazeret = txtErtelemeMazeret.Text,
                    ErtelemeTarihi = dtpErtelemeTarihi.Value,
                    Aciklama = txtAciklama.Text,
                    KaydiGirenKullaniciID = User.ID(),
                    KaydiDegistirenKullaniciID = User.ID(),
                    KayitTarihi = DateTime.Now,
                    KaydiDegistirmeTarihi = DateTime.Now,
                    Aktifmi = true
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
                cService.Update(new CelseDTO()
                {
                    ID = CelsID,
                    DavaID = DavID,
                    AvukatID = (int)cmbAvukat.SelectedValue,
                    CelseTarihi = dtpCelseTarihi.Value,
                    Hakim = txtHakim.Text,
                    Savci = txtSavci.Text,
                    Karar = txtKarar.Text,
                    ErtelemeMazeret = txtErtelemeMazeret.Text,
                    ErtelemeTarihi = dtpErtelemeTarihi.Value,
                    Aciklama = txtAciklama.Text,
                    KaydiGirenKullaniciID = User.ID(),
                    KaydiDegistirenKullaniciID = User.ID(),
                    KayitTarihi = DateTime.Now,
                    KaydiDegistirmeTarihi = DateTime.Now,
                    Aktifmi = true
                });

                Messages.GuncellemeBasarili();
            }
            catch (Exception ex)
            {
                Messages.GuncellemeBasarisiz(ex.Message);
            }
        }

        private void CelseKayitGuncelleme_Load(object sender, EventArgs e)
        {
            if (!(CelsID <= 0))
            {
                foreach (CelseDTO item in cService.Select().Where(p => p.ID == CelsID))
                {
                    dtpCelseTarihi.Value = item.CelseTarihi;
                    cmbAvukat.SelectedValue = item.AvukatID;
                    txtHakim.Text = item.Hakim;
                    txtSavci.Text = item.Savci;
                    txtKarar.Text = item.Karar;
                    dtpErtelemeTarihi.Value = item.ErtelemeTarihi;
                    txtErtelemeMazeret.Text = item.ErtelemeMazeret;
                    txtAciklama.Text = item.Aciklama;
                }
            }

            AvukatService aService = new AvukatService();
            cmbAvukat.DataSource = aService.Select();
            cmbAvukat.DisplayMember = "Adi";
            cmbAvukat.ValueMember = "ID";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (CelsID <= 0)
            {
                dataSave();
            }
            else
            {
                dataUpdate();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
