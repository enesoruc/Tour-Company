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
    public partial class TuristKayitUI : Form
    {
        TuristBLL _turistBLL;
        Turist turist;
        string gender = string.Empty;
        public TuristKayitUI()
        {
            InitializeComponent();
            _turistBLL = new TuristBLL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool result=TuristKaydet();
            
            if (result)
            {
                MessageBox.Show("Kayıt işlemi Başarılı");
                BiletSatisUI biletSatisUI = new BiletSatisUI(turist.TuristID);
                this.Hide();
                biletSatisUI.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }            
        }      

        private void rdWoman_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdMan.Checked)
            {
                gender = "Man";
            }
            else if (rdWoman.Checked)
            {
                gender = "Woman";
            }
        }

        private bool TuristKaydet()
        {
            turist = new Turist();
            turist.TuristID = Guid.NewGuid();
            turist.Ad = txtName.Text;
            turist.Soyad = txtSurname.Text;
            turist.Ulke = txtCountry.Text;
            turist.Uyruk = txtNationality.Text;
            turist.Cinsiyet = gender;
            turist.DogumTarihi = dtpBirthDate.Value;
            turist.TelefonNo = txtPhone.Text;
            turist.TurkiyeyeGelisTarihi = dtpArrivalDate.Value;
            bool result = _turistBLL.Add(turist);
            return result;
        }
    }
}
