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
    
    public partial class CreditsForm : Form
    {
        bool isAuthorisated = false;
        Users currentUser = null;
        public CreditsForm(bool isAuthorisated, Users currentUser)
        {
            InitializeComponent();

            this.isAuthorisated = isAuthorisated;
            this.currentUser = currentUser;
            textBoxIncome.Text = "в рублях";
            textBoxIncome.ForeColor = Color.Green;

            textBoxAge.Text = "в годах";
            textBoxAge.ForeColor = Color.Green;

            textBoxSum.Text = "целое значение";
            textBoxSum.ForeColor = Color.Green;

            textBoxTime.Text = "в месяцах";
            textBoxTime.ForeColor = Color.Green;

      

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void buttonClouse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackTo_Click(object sender, EventArgs e)
        {
        }

        private void textBoxIncome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIncome_Enter(object sender, EventArgs e)
        {
            if (textBoxIncome.Text == "в рублях")
            {
                textBoxIncome.Text = "";
                textBoxIncome.ForeColor = Color.Black;

            }
        }

        private void textBoxIncome_Leave(object sender, EventArgs e)
        {
            if (textBoxIncome.Text == "")
            {
                textBoxIncome.Text = "в рублях";
                textBoxIncome.ForeColor = Color.Green;
            }
        }

        private void labelSum_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAge_Enter(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "в годах")
            {
                textBoxAge.Text = "";
                textBoxAge.ForeColor = Color.Black;

            }
        }

        private void textBoxAge_Leave(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "")
            {
                textBoxAge.Text = "в годах";
                textBoxAge.ForeColor = Color.Green;
            }
        }

        private void textBoxSum_Enter(object sender, EventArgs e)
        {
            if (textBoxSum.Text == "целое значение")
            {
                textBoxSum.Text = "";
                textBoxSum.ForeColor = Color.Black;
            }
        }

        private void textBoxSum_Leave(object sender, EventArgs e)
        {
            if (textBoxSum.Text == "")
            {
                textBoxSum.Text = "целое значение";
                textBoxSum.ForeColor = Color.Green;
            }
        }

        private void textBoxTime_Enter(object sender, EventArgs e)
        {
            if (textBoxTime.Text == "в месяцах")
            {
                textBoxTime.Text = "";
                textBoxTime.ForeColor = Color.Black;
            }
        }

        private void textBoxTime_Leave(object sender, EventArgs e)
        {
            if (textBoxTime.Text == "")
            {
                textBoxTime.Text = "в месяцах";
                textBoxTime.ForeColor = Color.Green;
            }
        }


        decimal PayInMonth(decimal percent, decimal income, int time, decimal sum) // средний%, доход, срок и размер кредита 
        {
            decimal a; int b;
            a = (sum + sum * percent) / time; // посчитали сколько клиент должен платить в месяц, чтобы успеть выплатить долг вовремя + %
            b = (int)(income - 263); //прожиточный минимум
            if (b > a)
            {
                //чел может платить кредит
                return a;
            }
            else
                //textBoxPickedCredit("вам отказано в кредите из-за недостаточной платёжеспособности. (уменьшите сумму кредита или увеличте срок кредита)");
                return 2; // 
        }

        static decimal FunPercentTime(decimal percentTime, int age, int time) // считает % исходя из возраста и желаемого срока кредита 
        {
            if (time <= 12)
            {
                if (85 < age)
                {
                    return 0;
                    //Console.WriteLine ("Вам отказано в займе! причина: возраст");
                }
                else
                    percentTime = 20; //%
                return percentTime;
            }
            else 
            if (12 < time && time <= 60)
            {
                if (80 < age)
                {
                    return 0;
                }
                else
                    percentTime = 14; //%
                return percentTime;
            }
            else 
            if (60 < time && time <= 120)
            {
                if (70 < age)
                {
                    return 0;
                }
                else
                    percentTime = 11; //%
                return percentTime;
            }
            else 
            if (120 < time && time <= 240)
            {
                if (60 < age)
                {
                    return 0;
                }
                else
                    percentTime = 8; //%
                return percentTime;
            }
            if (time <= 360)
            {
                    percentTime = 7; //%
                return percentTime;
            }
            else
                return 1; // это если time > 360 мес
        }

        static decimal FunPercentSum(decimal percentSum, int sum) // считает % исходя из желаемого размера кредита
        {
            if (sum <= 10000)
            {
                percentSum = 5; //%
                return percentSum;
            }
            else 
            if (10000 < sum && sum <= 20000)
            {
                percentSum = 8; //%
                return percentSum;
            }
            else 
            if (20000 < sum && sum <= 50000)
            {
                percentSum = 11; //%
                return percentSum;
            }
            else 
            if (50000 < sum && sum <= 100000)
            {
                percentSum = 14; //%
                return percentSum;
            }
            else 
            if (100000 < sum && sum <= 200000)
            {
                percentSum = 15; //%
                return percentSum;
            }
            else
            if (sum < 100000000)
            {
                percentSum = 18; //%
                return percentSum;

            }
            else
            {
                return 1;
            }
        }


        private void buttonInquiry_Click(object sender, EventArgs e)
        {

            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}          

            if (textBoxIncome.Text == "в рублях")
            {
                MessageBox.Show("Заполните пожалуйста все поля!");
            }
            else
            if (textBoxAge.Text == "в годах")
            {
                MessageBox.Show("Заполните пожалуйста все поля!");

            }
            else
            if (textBoxSum.Text == "целое значение")
            {
                MessageBox.Show("Заполните пожалуйста все поля!");

            }
            else
            if (textBoxTime.Text == "в месяцах")
            {
                MessageBox.Show("Заполните пожалуйста все поля!");

            }
            else
            if (textBoxIncome.Text.Length == 0 || textBoxAge.Text.Length == 0 || textBoxSum.Text.Length == 0 || textBoxTime.Text.Length == 0)
            {
                MessageBox.Show("Заполните пожалуйста все поля!");
            }
            else
            {

                decimal income; // доход клиента в мес
                decimal percentTime = 0; // % по сроку кредита 
                decimal percentSum = 0; // % по сумме кредита 
                decimal percent; // сумма % ставок

                int age; int sum; int time;
                decimal a; decimal b; decimal c;
                //int type; // потом когда можно будет брать кредиты для разных нужд 

                income = Convert.ToDecimal(textBoxIncome.Text);
                age = Convert.ToInt32(textBoxAge.Text);
                sum = Convert.ToInt32(textBoxSum.Text);
                time = Convert.ToInt32(textBoxTime.Text);

                if (270 < income)
                {
                    if (18 <= age && age <= 84)
                    {
                        
                        a = FunPercentTime(percentTime, age, time);
                        b = FunPercentSum(percentSum, sum);
                        if (b == 1)
                        {
                            textBoxPickedCredit.Text = $"Банк не может дать вам столько денег!";

                        }
                        else
                        if (a == 0)
                        {
                            textBoxPickedCredit.Text = $"Мы не можем выдать вам кредит, у вас слишком большой возраст!";

                        }
                        else
                        if (a == 1)
                        {
                            textBoxPickedCredit.Text = $"Мы не можем выдать вам кредит, срок слишком большой!";

                        }
                        else
                        {
                            percent = (a + b) / 2 / 100; // нашли среднюю процентную ставку и преобразовали % для вычислений
                            c = PayInMonth(percent, income, time, sum);
                            if (c != 2)
                            {
                                textBoxPickedCredit.Text = $"Мы можем выдать вам кредит со ставкой в {percent * 100:#.##}%. {Environment.NewLine}Вам нужно платить в месяц {PayInMonth(percent, income, time, sum):#.##} руб.";
                                buttonCheckOut.Enabled = true;
                            }
                            else
                            {
                                textBoxPickedCredit.Text = $"Мы не можем выдать вам кредит, вашего дохода не достаточно!";
                            }
                        }                    
                    }
                    else
                    {
                        textBoxPickedCredit.Text = $"Мы не можем выдать вам кредит, возраст неподходящий!";

                    }
                }
                else
                {
                    textBoxPickedCredit.Text = $"Мы не можем выдать вам кредит, вашего дохода не достаточно!";

                }

            }
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ServisesForm backTOservise = new ServisesForm(isAuthorisated, currentUser);
            backTOservise.ShowDialog();
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (isAuthorisated)
            {
                SendDataByEmail.SendEmail(textBoxPickedCredit.Text, currentUser.Gmail_Email);
                MessageBox.Show("отправляю на почту...");
            }
            else
            {
                if (MessageBox.Show("Для оформления кредита надо авторизоваться!\nЖелаете авторизоваться?", "Ошибка авторизации", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Visible = false;
                    AutorisationForm autorisationForm = new AutorisationForm();
                    autorisationForm.ShowDialog();
                }
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
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

        private void textBoxIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

        }

        private void textBoxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

        }

        private void textBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

        }

        private void textBoxPickedCredit_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
