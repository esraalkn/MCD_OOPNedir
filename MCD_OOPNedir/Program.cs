﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arac bmw = new Arac("bmw","jeep");
            //Arac mercedes = new Arac();
            #region Araç Sınıfı İnceleme
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.alisFiyat = 28000;
            A1.satisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            //A1.Fiyat = Kapsülleme konusu
            A1.FiyatAta(31000);
            A1.Fiyat = 35000;
            Console.WriteLine(A1.Fiyat);
            A1.BilgileriGoruntule();
            #endregion

            Console.ReadLine();
        }
    }
}