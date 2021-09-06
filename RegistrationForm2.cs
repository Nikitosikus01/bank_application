using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Credits1
{
    public partial class RegistrationForm2 : Form
    {
        Users users;
        public RegistrationForm2(Users users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

            if (textBoxTownBirth.Text.Length == 0 || textBoxFullAddress.Text.Length == 0 || textBoxSerialNum.Text.Length == 0 || textBoxIdentificationNum.Text.Length == 0)
            {
                MessageBox.Show("Заполните все ячейки и правильно");

            }
            else
            {
                users.BirthAddress = textBoxTownBirth.Text;
                users.PresentAddress = textBoxFullAddress.Text;
                users.SerialNum = textBoxSerialNum.Text;
                users.IdentificationNum = textBoxIdentificationNum.Text;

                //переход на 2ю форму региcтрaции
                this.Visible = false;
                RegistrationForm3 Reg = new RegistrationForm3(users);
                Reg.ShowDialog();

            }
         

        }

        private void textBoxTownBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFullAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerialNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdentificationNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegistrationForm1 back = new RegistrationForm1();
            back.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClouse_Click(object sender, EventArgs e)
        {

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
    }
}
