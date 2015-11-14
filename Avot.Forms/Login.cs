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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Ömer - ilker beraber login e başlandı ve bitirildi.07.12.2014

        KullaniciService kullService = new KullaniciService();

        private void Login_Load(object sender, EventArgs e)
        {
            foreach (KullaniciDTO item in kullService.Select())
            {
                cmbKadi.Items.Add(item.KullaniciAdi);
                cmbKadi.SelectedIndex = 0;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            foreach (KullaniciDTO item in kullService.Select())
            {
                if (cmbKadi.SelectedItem.ToString()  == item.KullaniciAdi && txtSifre.Text == item.Sifre)
                {
                    //Giriş kabul edildiğinde, giriş yapılan bilgiler class a yazılıyor.Program açık olduğu sürece bilgiler bu bölümde olacak.
                    User.IdGir = item.ID;
                    User.KAdGir = cmbKadi.Text;
                    User.SifreGir = txtSifre.Text;
                    User.KullaniciYetkiGir = item.KullaniciYetkiID;

                    txtSifre.BackColor = Color.Green;
                    lblGiris.Text = "Giriş Başarılı !";
                    Messages.hosgeldin(cmbKadi.Text);
                    FormMain frmmain = new FormMain();
                    frmmain.Show();
                    this.Hide();
                }
                else
                {
                    txtSifre.BackColor = Color.Red;
                    lblGiris.Text = "Şifre Yanlış !";
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
