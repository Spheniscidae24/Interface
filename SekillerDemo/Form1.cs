using SekillerDemo.Models;
using SekillerDemo.Models.Bases;

namespace SekillerDemo
{
    public partial class Form1 : Form
    {
        IKoseliSekil _sekil;
        IYuvarlakSekil _yuvarlakSekil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlSekil.Items.Add("---Seçiniz---");
            ddlSekil.Items.Add("Dikdörtgen");
            ddlSekil.Items.Add("Dik üçgen");
            ddlSekil.Items.Add("Daire");
            ddlSekil.SelectedIndex = 0;
            panel2.Size = new Size(253, 146);
            panel2.Location = new Point(61, 128);
        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            if (ValideEt())
                Hesapla();
        }

        private void Hesapla()
        {
            if (ddlSekil.SelectedIndex == 1)
            {
                _sekil = new Dikdortgen();
                _sekil.Yukseklik = double.Parse(tbYukseklik.Text.Trim());
                _sekil.Genislik = double.Parse(tbGenislik.Text.Trim());
                if (rbAlan.Checked)
                    tbSonuc.Text = _sekil.AlanHesapla().ToString();
                else
                    tbSonuc.Text = _sekil.CevreHesapla().ToString();
            }
            else if (ddlSekil.SelectedIndex == 2)
            {
                _sekil = new Dikucgen()
                {
                    Genislik = double.Parse(tbGenislik.Text.Trim()),
                    Yukseklik = double.Parse(tbYukseklik.Text.Trim())
                };
                if (rbAlan.Checked)
                {
                    tbSonuc.Text = _sekil.AlanHesapla().ToString();
                }
                else
                {
                    tbSonuc.Text = _sekil.CevreHesapla().ToString();
                }
            }
            else
            {
                _yuvarlakSekil = new Daire()
                {
                    YariCap = double.Parse(tbYariCap.Text.Trim())
                };
                if (rbAlan.Checked)
                {
                    tbSonuc.Text = _yuvarlakSekil.AlanHesapla().ToString();
                }
                else
                {
                    tbSonuc.Text = _yuvarlakSekil.AlanHesapla().ToString();
                }
            }
        }

        private bool ValideEt()
        {
            if (ddlSekil.SelectedIndex == 0)
            {
                MessageBox.Show("Þekil seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (ddlSekil.SelectedIndex == 1 || ddlSekil.SelectedIndex == 2)
            {


                if (string.IsNullOrWhiteSpace(tbGenislik.Text) || string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    MessageBox.Show("Geniþlik ve yükseklik giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }

                double genislik;
                if (!double.TryParse(tbGenislik.Text.Trim(), out genislik))
                {
                    MessageBox.Show("Geniþlik sayýsal olmalýdýr!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
                double yukseklik;
                if (!double.TryParse(tbYukseklik.Text.Trim(), out yukseklik))
                {
                    MessageBox.Show("Yükseklik sayýsal olmalýdýr!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbYariCap.Text))
                {
                    MessageBox.Show("Yarý çap giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
                double yariCap;
                if (!double.TryParse(tbYariCap.Text.Trim(), out yariCap))
                {
                    MessageBox.Show("Yarý çap sayýsal olmalýdýr!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            return true;
        }

        

        private void bCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ddlSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            if (ddlSekil.SelectedIndex == 1 || ddlSekil.SelectedIndex == 2)
            {
                panel1.Visible = true;
            }
            else if (ddlSekil.SelectedIndex == 3)
            {
                panel2.Visible = true;
            }
        }
    }
}