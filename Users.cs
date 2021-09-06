using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credits1
{
    public class Users
    {
        //useful
        public string Login { get; set; }
        public string Password { get; set; }
        public string Gmail_Email { get; set; }
        //useless
        public string OneName { get; set; }
        public string TwoName { get; set; }
        public string ThreeName { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthAddress { get; set; }
        public string PresentAddress { get; set; }
        public string SerialNum { get; set; }
        public string IdentificationNum { get; set; }

        public Users(string login, string passw, string gmail, string oneName, string twoName,
            string threeName, DateTime birthday, string birthAdress, string presentAdress, string serialNum, string indentidNum)
        {
            this.Login = login;
            this.Password = passw;
            this.Gmail_Email = gmail;
            this.OneName = oneName;
            this.TwoName = twoName;
            this.ThreeName = threeName;
            this.BirthAddress = birthAdress;
            this.Birthday = birthday;
            this.PresentAddress = presentAdress;
            this.SerialNum = serialNum;
            this.IdentificationNum = IdentificationNum;
        }

        public Users()
        {

        }
    }
}
