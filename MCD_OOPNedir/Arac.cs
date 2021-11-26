using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Arac
    {
        //Propertyleri tanımladık
        public string Marka;
        public string Model;
        public int Modelyil;
        public decimal kilometre;
        public int yakitTip;
        public int vitesTip;
        public decimal alisFiyat;
        public decimal satisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;

        //Bu sınıfı kullanılabilir hale getirmek için construction(yapıcı metot) tanımlamalıyız.Default değerler tanımlamımızı sağlar

        public Arac()//Bir tane boş construction oluşturmalıyız yoksa kod çatlar.
        { }

        public Arac(string _marka,string _model)
        {
            Marka = _marka;
            Model = _marka;
        }

        public Arac(string _marka, string _model, int _modelyil)
        {
            Marka = _marka;
            Model = _model;
            Modelyil = _modelyil;
        }

        public Arac(string _marka, string _model, int _modelyil,decimal _km)
        {
            Marka = _marka;
            Model = _model;
            Modelyil = _modelyil;
            kilometre = _km;
        }

       public void BilgileriGoruntule()
        {
            Console.WriteLine($"Marka {Marka} - Model {Model} - Model Yıl {Modelyil} ");
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = satisFiyat - MaxIndirimTutar;
            if (_fiyat<fiyatHesap)
            {
                Console.WriteLine("Geçersiz Fiyat Girişi");
            }
            else
            {
                Fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi.");
            }
        }
    }
}
