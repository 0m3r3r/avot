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
    public partial class MahkemeKayitGuncelleme : Form
    {
        int ID;

        public MahkemeKayitGuncelleme()
        {
            InitializeComponent();
        }

        public MahkemeKayitGuncelleme(int GuncellenecekItemID)
        {
            InitializeComponent();
            ID = GuncellenecekItemID;
        }


        private void ilceFill(string ilAdi)
        {
            var query = (from iis in iiService.Select()
                         where iis.Il == ilAdi
                         select new { iis.Ilce, iis.ILID }).ToList();

            Cmbilce.DataSource = query;
            Cmbilce.DisplayMember = "Ilce";
            Cmbilce.ValueMember = "ILID";
        }

        MahkemeService mService = new MahkemeService();
        ililceService iiService = new ililceService();

        private void dataSave()
        {
            try
            {
                mService.Insert(new MAhkemeDTO()
                {
                    MahkemeAdi = txtMahkemeAdi.Text,
                    MahkemeNO = txtMahkemeNo.Text,
                    ILID = (int)Cmbilce.SelectedValue,
                    MahkemeTuru = txtMahkemeTuru.Text,
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
                mService.Update(new MAhkemeDTO()
                {
                    ID = ID,
                    MahkemeAdi = txtMahkemeAdi.Text,
                    MahkemeNO = txtMahkemeNo.Text,
                    MahkemeTuru = txtMahkemeTuru.Text,
                    //ILID = (int)Cmbilce.SelectedValue,
                    KaydiDegistirenKullaniciID = User.ID(),
                    KaydiDegistirmeTarihi = DateTime.Now

                });

                Messages.GuncellemeBasarili();
            }
            catch (Exception ex)
            {
                Messages.GuncellemeBasarisiz(ex.Message);
            }
        }

        private void MahkemeGuncellemeKayit_Load(object sender, EventArgs e)
        {
            //Service çağırma bölümü
            MahkemeService mService = new MahkemeService();
            ililceService iiService = new ililceService();

            //Db den il isimlerini alıp basmam gerek fakat her ilçenin başında il yazılı.Bunun için linq yardımı ile il isimlerine distinct uyguluyorum ve is isimlerini mükerrer olmadan birer adet yazıyorum.cmb ye basıyorum.
            var query = (from iis in iiService.Select()
                         select new { iis.Il }).Distinct().ToList();
            foreach (var item in query)
            {
                Cmbil.Items.Add(item.Il);
            }

            //var distinctCategories = product
            //            .Select(m => new { m.CategoryId, m.CategoryName })
            //            .Distinct()
            //            .ToList();
            //DropDownList1.DataSource = distinctCategories;
            //DropDownList1.DataTextField = "CategoryName";
            //DropDownList1.DataValueField = "CategoryId";

            // var results = listData.Where((item, index) => listFilter[index] == 1);

            //Gelen bir mahkeme id si var ise kolonların otomatik olarak doldurulması işlemini gerçekleştiriyorum.

            if (ID > 0)
            {
                foreach (MAhkemeDTO item in mService.Select().Where(p => p.ID == ID))
                {
                    txtMahkemeAdi.Text = item.MahkemeAdi;
                    txtMahkemeNo.Text = item.MahkemeNO;
                    txtMahkemeTuru.Text = item.MahkemeTuru;
                    //ililce basilmiyor suan
                    /*
                     select IlKodu,IlceKodu from ililce
                     where ILID=969              
                     */
                }
            }
        }

        private void cmbReload(int ilID)
        {
            var query = (from iis in iiService.Select()
                         select new { iis.Il }).Distinct().ToList();

            foreach (var item in query)
            {
                Cmbil.Items.Add(item.Il);
            }



            //Cmbilce.DataSource = query;
            //Cmbilce.DisplayMember = "Ilce";
            //Cmbilce.ValueMember = "ILID";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ID <= 0)
            {
                dataSave();
            }
            else
            {
                dataUpdate();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Mahkeme frm = new Mahkeme();
            frm.Show();
            this.Hide();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ilAdi = Cmbil.SelectedItem.ToString();
            ilceFill(ilAdi);
            Cmbilce.Enabled = true;
        }
    }
}