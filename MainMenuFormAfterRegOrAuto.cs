using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credits1
{
    public partial class MainMenuFormAfterRegOrAuto : Form
    {
        Users currentUser = null;
        public MainMenuFormAfterRegOrAuto(Users user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonServises_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ServisesForm Reg = new ServisesForm(true, currentUser);
            Reg.ShowDialog();

        }

        private void buttonNews_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewsForm Reg = new NewsForm();
            Reg.ShowDialog();

        }

        private void buttonAboutBank_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AboutBankForm Reg = new AboutBankForm();
            Reg.ShowDialog();

        }

        private void buttonClouse_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MainMenuFormAfterRegOrAuto_MouseMove(object sender, MouseEventArgs e)
        {

        }
        Point LastPoint;
        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }

        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);

        }
    }
}
