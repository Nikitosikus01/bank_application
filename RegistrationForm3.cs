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

    public partial class RegistrationForm3 : Form
    {
        Users users;
        private SqlConnection sqlConnection;

        public RegistrationForm3(Users users)
        {
            InitializeComponent();
            this.users = users;

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersDataBase"].ConnectionString); // подключаемся к бд, обращаясь к бд по имени 
            sqlConnection.Open();
            //if (sqlConnection.State == ConnectionState.Open) // если подключение открыто, показываем сообщение об этом
            //{
            //    MessageBox.Show("DB work");
            //}


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.ToString() != textBoxRepeatPassword.Text.ToString())
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else
            if (!SendDataByEmail.IsConnectedToInternet())
            {
                MessageBox.Show("Нет подключения к интернету");
                return;
            }
            else
            if (!SendDataByEmail.IsValidEmail(textBoxEmail.Text) || textBoxUserName.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Заполните все ячейки и правильно");
            }
            else
            {
                int code = (new Random()).Next(1000, 9999);
                SendDataByEmail.SendConfirmCode(textBoxEmail.Text, code);
                ConfirmEmailForm emailForm = new ConfirmEmailForm(code);
                if (emailForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                //users.Login = textBoxUserName.Text;
                //users.Password = textBoxPassword.Text;
                //users.Gmail_Email = textBoxEmail.Text;
                          
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [Users] (OneName, TwoName, ThreeName, Birthday, BirthAddress, PresentAddress, SerialNum, IdentificationNum, Login, Password, Gmail_Email) VALUES (@OneName, @TwoName, @ThreeName, @Birthday, @BirthAddress, @PresentAddress, @SerialNum, @IdentificationNum, @Login, @Password, @Gmail_Email)",
                    sqlConnection);

                users.Gmail_Email = textBoxEmail.Text;
                users.Password = textBoxPassword.Text;
                users.Login = textBoxUserName.Name;
                command.Parameters.AddWithValue("@OneName", users.OneName);
                command.Parameters.AddWithValue("@TwoName", users.TwoName);
                command.Parameters.AddWithValue("@ThreeName", users.ThreeName);
                command.Parameters.AddWithValue("@Birthday", users.Birthday);
                command.Parameters.AddWithValue("@BirthAddress", users.BirthAddress);
                command.Parameters.AddWithValue("@PresentAddress", users.PresentAddress);
                command.Parameters.AddWithValue("@SerialNum", users.SerialNum);
                command.Parameters.AddWithValue("@IdentificationNum", users.IdentificationNum);
                command.Parameters.AddWithValue("@Login", users.Login);
                command.Parameters.AddWithValue("@Password", users.Password);
                command.Parameters.AddWithValue("@Gmail_Email", users.Gmail_Email);



                command.ExecuteNonQuery();
                command.Dispose(); //сэкономили примерно байт

                sqlConnection.Close();

                this.Visible = false;
                MainMenuFormAfterRegOrAuto Reg = new MainMenuFormAfterRegOrAuto(users);
                Reg.ShowDialog();
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegistrationForm2 back = new RegistrationForm2(null);
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
