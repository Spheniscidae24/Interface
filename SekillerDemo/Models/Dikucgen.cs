using SekillerDemo.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo.Models
{
    internal class Dikucgen : IKoseliSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }

        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Yukseklik, 2) + Math.Pow(Genislik, 2));
            return Yukseklik + Genislik + hipotenus;
        }
    }
}
