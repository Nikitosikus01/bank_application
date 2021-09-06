
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
    public partial class ServisesForm : Form
    {
        bool isAuthorisated = false;
        Users currentUser = null;
        public ServisesForm(bool isAuthorizated, Users currentUser)
        {
            InitializeComponent();

            this.isAuthorisated = isAuthorizated;
            this.currentUser = currentUser;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCredit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreditsForm Reg = new CreditsForm(isAuthorisated, currentUser);
            Reg.ShowDialog();
        }

        private void buttonBackTo_Click(object sender, EventArgs e)
        {
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            deposit Reg = new deposit(isAuthorisated, currentUser);
            Reg.ShowDialog();

            //if (isAuthorisated)
            //{
            //    this.Visible = false;
            //    DepositForm Reg = new DepositForm();
            //    Reg.ShowDialog();
            //}
            //else
            //{
            //    if (MessageBox.Show("Для оформления депозита нужно войти в аккаунт!\nЖелаете авторизоваться?", "Ошибка авторизации", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        this.Visible = false;
            //        AutorisationForm autorisationForm = new AutorisationForm();
            //        autorisationForm.ShowDialog();
            //    }
            //}


        }

        private void buttonInvest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InvestForm Reg = new InvestForm(isAuthorisated, currentUser);
            Reg.ShowDialog();

            //if (isAuthorisated)
            //{
            //    this.Visible = false;
            //    InvestForm Reg = new InvestForm();
            //    Reg.ShowDialog();
            //}
            //else
            //{
            //    if (MessageBox.Show("Для инвестирования нужно войти в аккаунт!\nЖелаете авторизоваться?", "Ошибка авторизации", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        this.Visible = false;
            //        AutorisationForm autorisationForm = new AutorisationForm();
            //        autorisationForm.ShowDialog();
            //    }
            //}
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main Reg = new Main();
            Reg.ShowDialog();
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
