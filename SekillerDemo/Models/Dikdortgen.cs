using SekillerDemo.Models.Bases;

namespace SekillerDemo.Models
{
    public class Dikdortgen : IKoseliSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }

        public double CevreHesapla()
        {
            return 2 * (Genislik + Yukseklik);
        }
    }
}
