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
    public partial class DilUI : Form
    {
        DilBLL dilBLL;
        Dil dil;
        public DilUI()
        {
            InitializeComponent();
            dilBLL = new DilBLL();
        }

        private void DilUI_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dil = new Dil();
            dil.DilAdi = txtLanguage.Text;
            bool result = dilBLL.Add(dil);
            if (result)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }
    }
}
