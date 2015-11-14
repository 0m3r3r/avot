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
    public partial class Avukat : Form
    {
        public Avukat()
        {
            InitializeComponent();
        }


        private void AvukatListLoad()
        {
            foreach (AvukatDTO item in avkService.Select().OrderByDescending(a => a.ID))
            {//Avukatların listesi yazılıyor, ID azalan şekilde listview e basım yapılacak / ilker
                ListViewItem li = new ListViewItem();
                li.Text = item.TBBNo.ToString();
                li.SubItems.Add(item.Adi);
                li.SubItems.Add(item.Soyadi);
                li.SubItems.Add(item.TC);
                li.SubItems.Add(item.Brans);
                li.Tag = item.ID;//Tag e ID atanıyor ki, diğer forma düzenleme adına kayıt gönderileceği zaman tag deki ID çekilecek ve o ID üzerinden işlem yapılacak.

                lstAvukat.Items.Add(li);
            }
        }


        AvukatService avkService = new AvukatService();
        private void Avukat_Load(object sender, EventArgs e)
        {
            AvukatListLoad();
            //int[] dizi = new int[100];

            //for (; ; )
            //{
            //    int a = 50;
            //}
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            AvukatKayitGuncelleme frm = new AvukatKayitGuncelleme();
            frm.Show();
            this.Hide();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                AvukatKayitGuncelleme frm = new AvukatKayitGuncelleme((int)lstAvukat.FocusedItem.Tag);
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                Messages.itemSeciniz();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ds = MessageBox.Show("Seçili öğeyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ds == DialogResult.Yes)
                {
                    AvukatDTO adto = new AvukatDTO()
                    {
                        ID = (int)lstAvukat.FocusedItem.Tag
                    };

                    avkService.Delete(adto);

                    lstAvukat.Items.Clear(); // üst bölümde avukat, db den siliniyor.Burada lst temizleniyor.
                    AvukatListLoad();//ilgili kayıt db den silindiği için db tekrar taranarak list son hali ile dolduruluyor.
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
