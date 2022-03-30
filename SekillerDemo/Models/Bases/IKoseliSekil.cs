namespace SekillerDemo.Models.Bases
{
    public interface IKoseliSekil : IHesapla
    {
        double Genislik { get; set; }
        double Yukseklik { get; set; }

        //double AlanHesapla();
        //double CevreHesapla();
    }
}
