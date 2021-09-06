using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Credits1
{
    public partial class RegistrationForm1 : Form
    {
        public RegistrationForm1()
        {
            InitializeComponent();
        }

        private void RegitrationForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClouse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTwoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBirthdayData_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOneName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (textBoxOneName.Text.Length == 0 || textBoxTwoName.Text.Length == 0 || textBoxThreeName.Text.Length == 0)
            {
                MessageBox.Show("Заполните все ячейки и правильно");

            }
            else
            {
                DateTime date = dateTimePicker1.Value;

                Users users = new Users();

                users.OneName = textBoxOneName.Text;
                users.TwoName = textBoxTwoName.Text;
                users.ThreeName = textBoxThreeName.Text;
                users.Birthday = dateTimePicker1.Value;

                //переход на 2ю форму региcтрaции
                this.Visible = false;
                RegistrationForm2 Reg = new RegistrationForm2(users);
                Reg.ShowDialog();

            }
        }

        private void textBoxBirthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxThreeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Main back = new Main();
            back.ShowDialog();
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
