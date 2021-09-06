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

    public partial class InvestForm : Form
    {
        bool isAuthorisated = false;
        Users currentUser = null;

        public InvestForm(bool isAuthorisated, Users currentUser)
        {
            this.isAuthorisated = isAuthorisated;
            this.currentUser = currentUser;

            InitializeComponent();

            textBoxPickedInfo.Text = "информация об инвестиции";
            //textBoxInfo.ForeColor = Color.Green;
            comboBoxChioceInvest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;


            if (comboBoxChioceInvest.Text == "Недвижимость")
            {
                textBoxPickedInfo.Text = "Для инвестирования в недвижимость необхожимо иметь доход выше 5000 в месяц и ежемесечный доход от вложения в 400 раз меньше суммы вложения";
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBackTo_Click(object sender, EventArgs e)
        {
        }

        private void buttonClouse_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServisesForm back = new ServisesForm(true, null);//TODO: send is user logined
            back.Show();

        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxChioceInvest_SelectedIndexChanged(object sender, EventArgs e)
        {
  

        }

        private void buttonInquiry_Click(object sender, EventArgs e)
        {
            if (comboBoxChioceInvest.Text == "")
            {
                MessageBox.Show("не все поля заполнены!");
            }
            else
            if (textBoxSum.Text == "")
            {
                MessageBox.Show("не все поля заполнены!");
            }
            else
            {
                int Sum = Convert.ToInt32(textBoxSum.Text);
                if (Sum < 5000)
                {
                    MessageBox.Show("Доход слишком мал для инвестирования");
                }
                else
                {
                    int Income = Sum / 400; //посчитали доход в месяц))
                    textBoxUnvisible.Text = $"Ваш ежемесячный доход от инвестиции соствит {Income} руб.";

                    if (isAuthorisated)
                    {
                        SendDataByEmail.SendEmail(textBoxUnvisible.Text, currentUser.Gmail_Email);
                        MessageBox.Show("отправляю на почту...");
                    }
                    else
                    {
                        if (MessageBox.Show("Для инвестирования надо авторизоваться!\nЖелаете авторизоваться?", "Ошибка авторизации", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.Visible = false;
                            AutorisationForm autorisationForm = new AutorisationForm();
                            autorisationForm.ShowDialog();
                        }
                    }
                }
            }
        }

        private void maskedTextBoxSum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

        }
    }
}
