using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void OpenForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;

            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccessMain_Click(object sender, EventArgs e)
        {

            OpenForm(new frmAccess());

        }

        private void btnAdministratorUserMain_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAdministratorUser());
        }

        private void btnActivitiesMain_Click(object sender, EventArgs e)
        {
            OpenForm(new frmActivities());
        }

        private void btnPromotionsMain_Click(object sender, EventArgs e)
        {
            OpenForm(new frmPromotions());
        }

        private void Panel1Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {

        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {

        }

        private void btnGmail_Click(object sender, EventArgs e)
        {

        }
    }
}
