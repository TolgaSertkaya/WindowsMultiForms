using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriEkleme
{
    public partial class Form2 : Form
    {

        public Form1 frm1;

        public Form2(Form1 f)
        {
            InitializeComponent();
            frm1 = f;

        }


        //public string adSoyad;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtadSoyad.Text))
            {
                MessageBox.Show("Bilgileri Giriniz");
            }
            else
            {
                string adSoyad = txtadSoyad.Text;
                //frm1.musteriListesi.Add(adSoyad);
                frm1.lbxMusteriler.Items.Add(adSoyad);
                MessageBox.Show("Kaydetme İşlemi Başarılı");
                txtadSoyad.Text = "";
                txtadSoyad.Clear();
                txtadSoyad.Focus();  //imleci orda tutmak ıcın
                txtadSoyad.Text = string.Empty;  // yurkıelr sılıyor clearın aynısı

            }

        }
        private void btnListeyeDön_Click(object sender, EventArgs e)
        {
            this.Close();
            frm1.Show();
        }
    }
}
