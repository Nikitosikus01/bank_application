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
    public partial class ConfirmEmailForm : Form
    {
        int code;
        public ConfirmEmailForm(int code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (code == int.Parse(textBoxCode.Text))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("Код не совпадает");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmEmailForm_Load(object sender, EventArgs e)
        {

        }

        Point LastPoint;

        private void ConfirmEmailForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }

        }

        private void ConfirmEmailForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);

        }
    }
}
