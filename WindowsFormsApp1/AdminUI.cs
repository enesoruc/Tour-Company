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
    public partial class AdminUI : Form
    {
        TurBLL _turBLL;
        Tur guncelTur;
        public AdminUI()
        {
            InitializeComponent();
            _turBLL = new TurBLL();
        }

        private void newPlace_Click(object sender, EventArgs e)
        {
            TuristikYerUI turistikYerUI = new TuristikYerUI(0);
            turistikYerUI.ShowDialog();
        }

        private void updatePlace_Click(object sender, EventArgs e)
        {
            TuristikYerUI turistikYerUI = new TuristikYerUI(1);
            turistikYerUI.ShowDialog();
        }

        private void removePlace_Click(object sender, EventArgs e)
        {
            TuristikYerUI turistikYerUI = new TuristikYerUI(2);
            turistikYerUI.ShowDialog();
        }

        private void newTour_Click(object sender, EventArgs e)
        {
            TurUI turUI = new TurUI(null,0);
            turUI.ShowDialog();
        }

        private void newLanguage_Click(object sender, EventArgs e)
        {
            DilUI dilUI = new DilUI();
            dilUI.ShowDialog();
        }

        private void addGuide_Click(object sender, EventArgs e)
        {
            RehberUI rehberUI = new RehberUI();
            rehberUI.ShowDialog();
        }

        private void updateTour_Click(object sender, EventArgs e)
        {
            guncelTur = (Tur)lstTours.SelectedItems[0].Tag;
            TurUI turUI = new TurUI(guncelTur, 1);
            this.Hide();
            turUI.ShowDialog();
        }

        private void removeGuide_Click(object sender, EventArgs e)
        {

        }

        private void updateGuide_Click(object sender, EventArgs e)
        {

        }

        private void AddPayType_Click(object sender, EventArgs e)
        {
            PayType payType = new PayType();
            payType.ShowDialog();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            if (lstTours.Columns[0].Width != 140 || lstTours.Columns[1].Width != 140)
            {
                lstTours.Columns[0].Width = 140;
                lstTours.Columns[1].Width = 140;
            }

            ListViewItem lvi;
            foreach (Tur item in _turBLL.GetAllTours())
            {
                lvi = new ListViewItem(item.TurAdi);
                lvi.SubItems.Add(item.TurTarihi.ToString());
                lvi.SubItems.Add(item.Ucret.ToString());
                lvi.Tag = item;
                lstTours.Items.Add(lvi);
            }
        }

        private void lstTours_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
