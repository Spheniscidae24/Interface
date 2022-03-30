using SekillerDemo.Models.Bases;

namespace SekillerDemo.Models
{
    internal class Daire : IYuvarlakSekil
    {
        public double YariCap { get; set; }

        public double AlanHesapla()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }

        public double CevreHesapla()
        {
            return Math.PI * YariCap * 2;
        }
    }
}
