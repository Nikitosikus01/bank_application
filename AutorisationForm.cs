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
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();

            textBoxLogin.Text = "Введите ваш логин!";
            textBoxLogin.ForeColor = Color.Green;

            //textBoxPassword.Text = "Введите ваш пароль!";
            //textBoxPassword.ForeColor = Color.Green;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAutorisation_Click(object sender, EventArgs e)
        {

        }

        private void buttonClouse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackTo_Click(object sender, EventArgs e)
        {
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Введите ваш логин!")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Введите ваш логин!";
                textBoxLogin.ForeColor = Color.Green;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        //private void textBoxPassword_Enter(object sender, EventArgs e)
        //{
        //    if (textBoxPassword.Text == "Введите ваш пароль!")
        //    {
        //        textBoxPassword.Text = "";
        //        textBoxPassword.ForeColor = Color.Black;
        //    }
        //}

        //private void textBoxPassword_Leave(object sender, EventArgs e)
        //{
        //    if (textBoxPassword.Text == "")
        //    {
        //        textBoxPassword.Text = "Введите ваш пароль!";
        //        textBoxPassword.ForeColor = Color.Green;
        //    }
        //}

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            RegistrationForm1 Reg = new RegistrationForm1();
            Reg.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorisationController.CheckInputFields(textBoxLogin.Text, textBoxPassword.Text);
                Users user = AuthorisationController.CheckInputDataReturnUser(textBoxLogin.Text, textBoxPassword.Text);

                this.Visible = false;
                MainMenuFormAfterRegOrAuto mainMenuForm = new MainMenuFormAfterRegOrAuto(user);
                mainMenuForm.ShowDialog();
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "login")
                {
                    MessageBox.Show("Неверный логин", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ex.ParamName == "password")
                {
                    MessageBox.Show("Неверный пароль", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
