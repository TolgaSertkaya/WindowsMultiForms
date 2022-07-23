using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeronelEkleme
{
    public class Kisi
    {
        public string AdSoyad { get; set; } //prop tab tab
        public string Birim { get; set; } //prop tab tab
        public string TcNo { get; set; } //prop tab tab
        public string DogumYeri { get; set; } //prop tab tab
        public DateTime DogumTarihi { get; set; } //prop tab tab
        public bool Cinsiyet { get; set; }//kadınsa true erkekse false kabul edıcez
    }
}
