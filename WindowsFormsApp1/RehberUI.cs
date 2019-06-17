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
    public partial class RehberUI : Form
    {
        RehberBLL _rehberBLL;
        RehberDilBLL _rehberDilBLL;
        RehberDil _rehberDil;
        DilBLL _dilBLL;
        List<Dil> dils;
        Dil Dil;
        Rehber rehber;
        string gender = string.Empty;
        bool ısActive = false;
        public RehberUI()
        {
            InitializeComponent();
            _rehberBLL = new RehberBLL();
            _dilBLL = new DilBLL();
            _rehberDilBLL = new RehberDilBLL();
            dils = new List<Dil>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result1 = AddGuide();

            int ID = _rehberBLL.GetGuideIDByNameAndSurname(rehber.Ad + " " + rehber.Soyad);
            for (int i = 0; i < dils.Count; i++)
            {
                _rehberDil = new RehberDil();
                _rehberDil.RehberID = ID;
                _rehberDil.DilID = dils[i].DilID;
                _rehberDil.IslemTarihi = DateTime.Now;
                _rehberDilBLL.Add(_rehberDil);
            }

            if (result1)
            {
                MessageBox.Show("Rehber Başarılı Bir Şekilde Kaydedildi");
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private bool AddGuide()
        {
            rehber = new Rehber();
            rehber.Ad = txtName.Text;
            rehber.Soyad = txtSurname.Text;
            rehber.Ulke = txtCountry.Text;
            rehber.Uyruk = txtNationality.Text;
            rehber.Cinsiyet = gender;
            rehber.DogumTarihi = dtpBirthDate.Value;
            rehber.TelefonNo = txtPhone.Text;
            rehber.AktiflikDurumu = ısActive;
            bool result1 = _rehberBLL.Add(rehber);
            return result1;
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

        private void rdActive_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdActive.Checked)
            {
                ısActive = true;
            }
            else if(rdPassive.Checked)
            {
                ısActive = false;
            }
        }

        private void RehberUI_Load(object sender, EventArgs e)
        {
            ListViewItem lvi;
            List<Dil> diller = _dilBLL.GetAllLanguages();
            foreach (Dil item in diller)
            {
                lvi = new ListViewItem(item.DilAdi);
                lvi.Tag = item;
                lstAllLanguages.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dil = (Dil)lstAllLanguages.SelectedItems[0].Tag;
            dils.Add(Dil);
            lstGuideLanguages.Items.Clear();
            RefreshList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dils.Remove((Dil)lstGuideLanguages.SelectedItems[0].Tag);
            lstGuideLanguages.Items.Clear();
            RefreshList();
        }

        public void RefreshList()
        {
            ListViewItem lvi;
            foreach (Dil item in dils)
            {
                lvi = new ListViewItem(item.DilAdi);
                lvi.Tag = item;
                lstGuideLanguages.Items.Add(lvi);
            }
        }
    }
}
