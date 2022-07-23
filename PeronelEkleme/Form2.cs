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
    public partial class Form2 : Form
    {
        public Form2(List<Kisi> kisiler,Form1 f)
        {
            InitializeComponent();
            kisiler2 = kisiler;
            frm = f;
        }

        public List<Kisi> kisiler2;
        public Form1 frm;

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seçiniz");
            comboBox1.SelectedIndex = 0;
            foreach (var item in kisiler2) //kisiler: Ahmet, mehmet, ayşe
            {
                //item.AdSoyad +"-"+item.TcNo boylede doldurabılırız asagıdakı gıbıde
                comboBox1.Items.Add(item.AdSoyad);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in kisiler2)
            {
                if (item.AdSoyad == comboBox1.SelectedItem.ToString())
                {
                    lblAdSoyad.Text = item.AdSoyad;
                    lblBirim.Text = item.Birim;
                    lblCinsiyet.Text = item.Cinsiyet == true ? "Kadın" : "Erkek";
                    lblDogumYeri.Text = item.DogumYeri;
                    lblDogumTarihi.Text = item.DogumTarihi.ToString();
                    lblTcNo.Text = item.TcNo;
                }
            }
        }

        private void btnKisiEkleme_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();  yeni form açmak istemiyoruz
            this.Controls.Clear();

            frm.Show();
        }
    }
}
