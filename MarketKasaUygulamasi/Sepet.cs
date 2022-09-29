using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketKasaUygulamasi
{
    public class Sepet

    {
        public Sepet()
        {

        }
        public Sepet(int adet, string urunAdi, decimal birimFiyat)
        {
            Adet = adet;
            UrunAdi = urunAdi;
            BirimFiyat = birimFiyat;
            Toplam = birimFiyat * adet;
        }
        public int Adet { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Toplam { get; set; }
    }
}
