using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Musteri
    {
        /*
         * TcKimlik Numarası
         * İsim
         * Soyisim
         * Cinsiyet
         * 
         */

        public string TcKimlikNo;
        public string Isim;
        public string SoyIsim;
        public int Cinsiyet;//717770001:Erkek , 717770005:Kadın

        public Musteri() { }

        public Musteri(string _tcno,string _isim)
        {
            TcKimlikNo = _tcno;
            Isim = _isim;
           
        }

      public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDataBase(TcKimlikNo);//Metot içinde metot çağırdık!
            return true;
        }

        private bool MusteriKontrolDataBase(string Tckimliknumarasi)
        {
            //DateBase gidilir müşterinin tckimlik numarasına göre kayıt edilip edilmediği bilgisi sorgulanır.....
            return true;
        }

    }
}
