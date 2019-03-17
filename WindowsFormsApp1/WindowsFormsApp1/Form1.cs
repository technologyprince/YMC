using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KAYDET_Click(object sender, EventArgs e)
        {
            #region Kayıt alma
            Kayıt YeniKayit = new Kayıt();
            YeniKayit.AdSoyad = TBAdSoyad.Text;
            YeniKayit.TelefonNumarası = MTBTelefon.Text;
            YeniKayit.Email = TBEmail.Text;
            YeniKayit.Proje = TBEmail.Text;
            #endregion
            #region Kayıt Alındı metni
            label5.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label5.Text = "Ad Soyad: " + YeniKayit.AdSoyad + " " + "Telefon Numarası: " + YeniKayit.TelefonNumarası;
            label7.Text= "Email adresi: "+ YeniKayit.Email + " " +"Proje: "+ YeniKayit.Proje;
            label8.ForeColor = Color.DarkGreen;
            label8.Text = "Kaydınız başarıyla oluşturulmuştur.";
            #endregion

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BUyeler_Click(object sender, EventArgs e)
        {

            ÜyeListesi.ActiveForm.;
        }
    }
}
