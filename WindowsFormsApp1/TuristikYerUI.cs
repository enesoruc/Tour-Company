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
    public partial class TuristikYerUI : Form
    {
        TuristikYerBLL _turistikYerBLL;
        TuristikYer turistikYer;
        TuristikYer guncelturistikYer;
        TuristikYer guncellenecekturistikYer;
        int flag = 0;
        public TuristikYerUI(int currentFlag)
        {
            InitializeComponent();
            _turistikYerBLL = new TuristikYerBLL();
            flag = currentFlag;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result= TuristikYerOlustur();
            if (result)
            {
                MessageBox.Show("Yer Başarılı Bir Şekilde Oluşturuldu");
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private bool TuristikYerOlustur()
        {
            turistikYer = new TuristikYer();
            turistikYer.TurAdi = txtPlace.Text;
            turistikYer.Notlar = txtNotes.Text;
            turistikYer.Ucret = int.Parse(txtPrice.Text);
            bool result = _turistikYerBLL.Add(turistikYer);
            return result;
        }

        private void TuristikYerUI_Load(object sender, EventArgs e)
        {
            if (flag==1 || flag==2)
            {
                lstAllPlaces.DisplayMember = "TurAdi";
                lstAllPlaces.ValueMember = "TuristikYerID";
                lstAllPlaces.DataSource = _turistikYerBLL.GelAllCities();
                if (flag == 2)
                {
                    btnRemove.Visible = true;
                    btnAdd.Visible = false;
                    btnUpdate.Visible = false;
                }
                else if(flag==1)
                {
                    btnRemove.Visible = false;
                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                }
            }           
        }

        private void lstAllPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID =(int)lstAllPlaces.SelectedValue;
            guncelturistikYer= _turistikYerBLL.GetCityByID(ID);
            txtPlace.Text = guncelturistikYer.TurAdi;
            txtNotes.Text = guncelturistikYer.Notlar;
            txtPrice.Text = guncelturistikYer.Ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool result= _turistikYerBLL.Remove(guncelturistikYer);
            if (result)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result=YerGuncelle();

            if (result)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Sorun var panpa");
            }
        }

        private bool YerGuncelle()
        {
            guncellenecekturistikYer = new TuristikYer();
            guncellenecekturistikYer.TuristikYerID = (int)lstAllPlaces.SelectedValue;
            guncellenecekturistikYer.TurAdi = txtPlace.Text;
            guncellenecekturistikYer.Notlar = txtNotes.Text;
            guncellenecekturistikYer.Ucret = Convert.ToDecimal(txtPrice.Text);
            bool result = _turistikYerBLL.Update(guncellenecekturistikYer);
            return result;
        }
    }
}
