﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniMetotlar
{
    internal class SepetManager
    {
        //naming covention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
            
        }
    }
}
