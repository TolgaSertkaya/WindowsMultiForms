using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeronelEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kisi> kisiListesi = new List<Kisi>();
        List<string> Liste = new List<string>();


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdSoyad.Text.Trim()) || string.IsNullOrEmpty(txtBirim.Text.Trim()) || string.IsNullOrEmpty(txtDogumYeri.Text.Trim()) || string.IsNullOrEmpty(txtTcNo.Text.Trim()) || (rdbKadin.Checked == false && rdbErkek.Checked == false))
            {
                MessageBox.Show("Bilgiler Eksik");
            }
            else
            {
                try
                {
                    Kisi k1 = new Kisi();
                    k1.AdSoyad = txtAdSoyad.Text;
                    k1.TcNo = txtTcNo.Text;
                    k1.DogumYeri = txtDogumYeri.Text;
                    k1.DogumTarihi = dateTimePicker1.Value;
                    k1.Birim = txtBirim.Text;
                    k1.Cinsiyet = rdbKadin.Checked;
                    //asagıdakı ıle aynı uzun halı ternary ıf
                    //k1.Cinsiyet = rdbKadin.Checked == true ? true : false;

                    kisiListesi.Add(k1);

                    MessageBox.Show("Kayıt İşlemi Başarılı!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu!");
                }


            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(kisiListesi,this);
            frm.Show();

            this.Hide();
        }
    }
}

