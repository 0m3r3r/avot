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
    public partial class WebSayfasiKayit : Form
    {
        public WebSayfasiKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            WebService wService = new WebService();

            wService.Insert(new WebDTO()
            {
                URL = txtURL.Text,
                Aciklama = TXTAciklama.Text
            });

            Messages.kayitBasarili();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
