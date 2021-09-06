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
    public partial class DepositForm : Form
    {
        bool isAuthorisated = false;
        Users currentUser = null;

        public DepositForm(bool isAuthorizated, Users currentUser)
        {

            this.isAuthorisated = isAuthorizated;
            this.currentUser = currentUser;

            InitializeComponent();


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        static double PercentTimeDeposit(int time) // считаем процент по сроку
        {

            //12 24 48 96 144 240
            double a;
            a = time * 4 / 10;
            if (time == 3)
            {
                return a;
            }
            else
            if (time == 6)
            {
                return a;
            }
            else
            if (time == 12)
            {
                return a;
            }
            else
            if (time == 24)
            {
                return a / 1.5;
            }
            else
            if (time == 36)
            {
                return a / 2;
            }
            else //(time == 60)
            {
                return a / 3;
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxСurrencyOrValue.Text = textBoxDeposit.Text; ???

        }

        private void textBoxDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label123_Click(object sender, EventArgs e)
        {

        }

        private void buttonInquiry_Click_1(object sender, EventArgs e)
        {
            double summ; int time; double percent; double profit; //decimal Profit;
            summ = Convert.ToInt32(textBoxDeposit.Text); // получаем данные о сумме вклада
            time = Convert.ToInt32(comboBoxTime.Text); // получаем данные о time вклада !!!!!!!!!!!!!!!!!!!!!!!!!!!!

            if (textBoxDeposit.Text == "")
            {
                MessageBox.Show("Заполните пожалуйста все поля!");
            }
            else
            if (comboBoxTime.Text == "")
            {
                MessageBox.Show("Заполните пожалуйста все поля!");
            }
            else
            {
                percent = PercentTimeDeposit(time); // получаем % для дорала
                if (comboBoxСurrencyOrValue.Text == "Рубль")
                {
                    percent = percent * 2; // делаем % для рубля
                    profit = percent * summ / 100;
                    textBoxPickedDeposit.Text = $"Мы предлагаем вам депозит с капитализацией {percent:#.##}%. {Environment.NewLine}Ваш ежемесячный доход соствит {profit} руб."; // ещё выбор да нет, если да, то на почту письмо

                }
                else
                {
                    profit = percent * summ / 100;
                    textBoxPickedDeposit.Text = $"Мы предлагаем вам депозит с капитализацией {percent:#.##}%. {Environment.NewLine}Ваш ежемесячный доход соствит {profit} $"; // ещё выбор да нет, если да, то на почту письмо
                }

                SendDataByEmail.SendEmail(textBoxPickedDeposit.Text, currentUser.Gmail_Email);
                MessageBox.Show("отправляю на почту...");

                //if (isAuthorisated) //проверка авторизации
                //{
                //    SendDataByEmail.SendEmail(textBoxPickedCredit.Text, currentUser.Gmail_Email);
                //    MessageBox.Show("отправляю на почту...");
                //}
                //else
                //{
                //    if (MessageBox.Show("Для оформления кредита надо авторизоваться!\nЖелаете авторизоваться?", "Ошибка авторизации", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //    {
                //        this.Visible = false;
                //        AutorisationForm autorisationForm = new AutorisationForm();
                //        autorisationForm.ShowDialog();
                //    }
                //}
            }

        }

        private void comboBoxСurrencyOrValue_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

