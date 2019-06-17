using DevOpsTour.BLL;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BiletSatisUI : Form
    {
        TurBLL _turBLL;
        DilBLL _dilBLL;
        OdemeBLL _odemeBLL;
        FaturaBLL _faturaBLL;
        BiletDetay _biletDetay;
        BiletDetayBLL _biletDetayBLL;
        Guid currentTouristID;
        Tur tur;
        public BiletSatisUI(Guid turistID)
        {
            InitializeComponent();
            currentTouristID = turistID;
            _turBLL = new TurBLL();
            _dilBLL = new DilBLL();
            _odemeBLL = new OdemeBLL();
            _faturaBLL = new FaturaBLL();
            _biletDetay = new BiletDetay();
            _biletDetayBLL = new BiletDetayBLL();
        }

        private void BiletSatisUI_Load(object sender, EventArgs e)
        {
            cmbTourLanguage.DisplayMember = "DilAdi";
            cmbTourLanguage.ValueMember = "DilID";
            cmbTourLanguage.DataSource = _dilBLL.GetAllLanguages();

            cmbPayType.DisplayMember = "OdemeTipi";
            cmbPayType.ValueMember = "OdemeID";
            cmbPayType.DataSource = _odemeBLL.Pays();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TurSorgula();         
        }

        private void TurSorgula()
        {
            int Dil = (int)cmbTourLanguage.SelectedValue;
            cmbTurlar.DisplayMember = "TurAdi";
            cmbTurlar.ValueMember = "TurID";
            cmbTurlar.DataSource = _turBLL.GetToursByLanguage(Dil);
        }

        private void cmbTurlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            tur = _turBLL.GetTourByID((int)cmbTurlar.SelectedValue);
            txtTutar.Text = tur.Ucret.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FaturaOlustur();          
        }

        private void FaturaOlustur()
        {
            Fatura fatura = new Fatura();
            fatura.OdemeID = (int)cmbPayType.SelectedValue;
            fatura.Tutar = tur.Ucret;
            fatura.FaturaTarihi = DateTime.Now;

            bool result = _faturaBLL.Add(fatura);
            if (result)
            {
                MessageBox.Show("Fatura Başarılı bir şekilde oluşturuldu");
            }
            BiletDetayOlustur();
        }

        private void BiletDetayOlustur()
        {
            _biletDetay.TuristID = currentTouristID;
            _biletDetay.TurID = (int)cmbTurlar.SelectedValue;
            _biletDetay.FaturaID = _faturaBLL.GetLastID();
            _biletDetay.DetayTarih = DateTime.Now;
            _biletDetayBLL.Add(_biletDetay);
        }
    }
}
