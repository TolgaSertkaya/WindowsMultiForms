using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> kullaniciAdlari = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            kullaniciAdlari.Add("admin");
            kullaniciAdlari.Add("ali");
            kullaniciAdlari.Add("tolga");
            kullaniciAdlari.Add("mehmet");
            kullaniciAdlari.Add("yonetici");
            kullaniciAdlari.Add("muhasebe");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //kullanıcıadlarının contaınsınde yanı ıcınde yazdıgımız ısım var mı...
            if(kullaniciAdlari.Contains(txtKullaniciAdi.Text.ToLower().ToLower().Trim()) && txtSifre.Text.Trim() == "1234")  //Tolower  Toupper ı ben kullandım fakat kullanıcıadd e kucuk harfle yazmam gerektı ısımlerı
            {
                //form 2 ye gonder
                Form2 frm2 = new Form2();
                frm2.Show();
                frm2.HosgeldinYaz(txtKullaniciAdi.Text);

                //this.Close();   form1 ana sayfamız oldugu ıcın,uygulamanın ana sayfası programı komple kapatır

                this.Hide();  //bu ıse programı saklar
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }

        private void chkParolayiGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParolayiGöster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}      //ACCEPTBUTTON u aktıf hale getırırsek enter ıle gırıs yapabılıyoruz
