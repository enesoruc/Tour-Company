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
    public partial class PayType : Form
    {
        OdemeBLL _odemeBLL;
        public PayType()
        {
            InitializeComponent();
            _odemeBLL = new OdemeBLL();
        }

        private void PayType_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.OdemeTipi = txtPayType.Text;
            bool result = _odemeBLL.Add(odeme);
            if (result)
            {
                MessageBox.Show("İşlem Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }
    }
}
