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
    public partial class TurUI : Form
    {
        TurBLL _turBLL;
        TuristikYerBLL _turistikYerBLL;
        DilBLL _dilBLL;
        RehberBLL _rehberBLL;
        RehberDilBLL _rehberDilBLL;
        Tur guncelTur;
        Tur tur;
        int currentFlag = 0;
        public TurUI(Tur guncellenecekTur,int flag)
        {
            InitializeComponent();
            _turBLL = new TurBLL();
            _turistikYerBLL = new TuristikYerBLL();
            _dilBLL = new DilBLL();
            _rehberBLL = new RehberBLL();
            _rehberDilBLL = new RehberDilBLL();
            guncelTur = guncellenecekTur;
            currentFlag = flag;
        }

        private void TurUI_Load(object sender, EventArgs e)
        {
            ListeleriDoldur();

            if (currentFlag==0)
            {

            }
            else if (currentFlag==1)
            {
                txtTourName.Text = guncelTur.TurAdi;
                txtPrice.Text = guncelTur.Ucret.ToString();
                cmbTourLanguage.SelectedIndex = guncelTur.TurDilID-1;//todo
                cmbTourPlaces.SelectedIndex = guncelTur.TuristikYerID;
                dtpTourDate.Value = guncelTur.TurTarihi;
            }
        }       

        private void cmbTourPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID =(int)cmbTourPlaces.SelectedValue;
            TuristikYer yer=_turistikYerBLL.GetCityByID(ID);
            txtPrice.Text = yer.Ucret.ToString();
        }

        bool result = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            TurOlustur();

            if (currentFlag==0)
            {
               result = _turBLL.Add(tur);
            }
            else if(currentFlag==1)
            {
               result = _turBLL.Update(tur);
            }
            
            if (result)
            {
                MessageBox.Show("İşlem Başarılı");
            }
        }

        private void ListeleriDoldur()
        {
            cmbTourPlaces.DisplayMember = "TurAdi";
            cmbTourPlaces.ValueMember = "TuristikYerID";
            cmbTourPlaces.DataSource = _turistikYerBLL.GelAllCities();

            cmbTourLanguage.DisplayMember = "DilAdi";
            cmbTourLanguage.ValueMember = "DilID";
            cmbTourLanguage.DataSource = _dilBLL.GetAllLanguages();
        }
        private void TurOlustur()
        {
            tur = new Tur();
            tur.TurAdi = txtTourName.Text;
            tur.TuristikYerID = (int)cmbTourPlaces.SelectedValue;
            tur.Ucret = Convert.ToDecimal(txtPrice.Text);
            tur.TurTarihi = dtpTourDate.Value;
            tur.TurDilID = (int)cmbTourLanguage.SelectedValue;
            tur.RehberID = _rehberBLL.GetGuideIDByNameAndSurname(lstAllGuides.SelectedItem.ToString());
        }

        private void cmbTourLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dilID ye göre rehberleri gösterme
           lstAllGuides.DataSource= _rehberDilBLL.GetGuidesByLanguageID((int)cmbTourLanguage.SelectedValue);
        }
    }
}
