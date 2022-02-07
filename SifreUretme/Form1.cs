using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreUretme
{
    public partial class Form1 : Form
    {
        bool kucukHarfVarmi, buyukHarfVarmi, rakamVarmi, ozelkKarakterVarmi;
        int sifreSayisi, sifreUzunlugu;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)

        {
            string seciliKarakterler = "";
            txtSifre.Text = "";


            kucukHarfVarmi = checkKücükHarf.Checked;
            buyukHarfVarmi = checkBuyukHarf.Checked;
            rakamVarmi = checkRakam.Checked;
            ozelkKarakterVarmi = checkOzelKarakterler.Checked;

            sifreSayisi = (int)numSifreSayısı.Value;
            sifreUzunlugu = (int)numSifreUzunlugu.Value;

            if (!(ozelkKarakterVarmi || rakamVarmi || buyukHarfVarmi || kucukHarfVarmi))
            {
                MessageBox.Show("En az bir paremetre seçiniz");
                return;

            }
            KucukHarfEkle(ref seciliKarakterler);
            BuyukHarfEkle(ref seciliKarakterler);
            RakamEkle(ref seciliKarakterler);
            OzekKarakterEkle(ref seciliKarakterler);
            SifreUret(seciliKarakterler);

        }
        private void SifreUret(string seciliKarakterler)
        {
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sonuc = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sonuc += seciliKarakterler[rnd.Next(seciliKarakterler.Length)];
                }

                txtSifre.Text += $"{i + 1}-)" + sonuc;
                txtSifre.Text += sonuc + "\r\n";
                txtSifre.Text += "\r\n";
            }
        }
        private void OzekKarakterEkle(ref string seciliKarakterler)
        {
            if (ozelkKarakterVarmi)//33 47, 58 64, 91 96, 123 126
            {
                for (int i = 33; i <= 47; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 58; i <= 64; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 91; i <= 96; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 123; i <= 126; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }
        private void RakamEkle(ref string seciliKarakterler)
        {
            if (rakamVarmi)//48 57
            {
                for (int i = 48; i <= 57; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }
        private void BuyukHarfEkle(ref string seciliKarakterler)
        {
            if (buyukHarfVarmi)//65 A 90 Z
            {
                for (int i = 65; i <= 90; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }
        public void KucukHarfEkle(ref string seciliKarakterler)
        {
            if (kucukHarfVarmi)//97 a 122 z
            {
                for (int i = 97; i <= 122; i++)
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }
        }



    }
}
