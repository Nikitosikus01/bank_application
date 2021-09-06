using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credits1
{
    class AuthorisationController
    {
        public static void CheckInputFields(string login, string password)
        {
            if (login == "Введите ваш логин!" || password == "Введите ваш пароль!")
            {
                throw new ArgumentException("Не все поля заполнены!");
            }
            if (login.Length == 0 || password.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (password == "Введите пароль" || login == "Введите логин")
            {
                throw new ArgumentException("Не все поля заполнены!");
            }
        }

        public static Users CheckInputDataReturnUser(string login, string password)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersDataBase"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Users WHERE Login = N'{login}'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                if (sqlDataReader.Read())
                {
                    if (Convert.ToString(sqlDataReader[2]) == password)
                    {
                        string passw = sqlDataReader.GetString(2);
                        string gmail_email = sqlDataReader.GetString(3);
                        string oneName = sqlDataReader.GetString(4);
                        string twoName = sqlDataReader.GetString(5);
                        string threeName = sqlDataReader.GetString(6);
                        DateTime birthday = sqlDataReader.GetDateTime(7);
                        string birthAdress = sqlDataReader.GetString(8);
                        string presentAddress = sqlDataReader.GetString(9);
                        string serialNum = sqlDataReader.GetString(10);
                        string indentifNum = sqlDataReader.GetString(11);

                        return new Users(login, passw, gmail_email, oneName, twoName, threeName, birthday, birthAdress,
                            presentAddress, serialNum, indentifNum);
                    }
                    else
                    {
                        throw new ArgumentException("Неверный пароль", "password");
                    }
                }
                else
                {
                    throw new ArgumentException("Неверный логин", "login");
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (!(sqlConnection is null))
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
