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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonServises_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ServisesForm Reg = new ServisesForm(false, null);
            Reg.ShowDialog();
        }

        private void labelMainMenu_Click(object sender, EventArgs e)
        {

        }

        
        private void linkLabelAutorisation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Visible = false;
            AutorisationForm Reg = new AutorisationForm();
            Reg.ShowDialog();
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Visible = false;
            RegistrationForm1 Reg = new RegistrationForm1(); // 
            Reg.ShowDialog();
            this.Show();/////
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

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
