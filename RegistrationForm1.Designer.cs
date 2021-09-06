
namespace Credits1
{
    partial class RegistrationForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTwoName = new System.Windows.Forms.Label();
            this.labelTreeName = new System.Windows.Forms.Label();
            this.textBoxThreeName = new System.Windows.Forms.TextBox();
            this.buttonRegistrationText = new System.Windows.Forms.Button();
            this.textBoxTwoName = new System.Windows.Forms.TextBox();
            this.textBoxOneName = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxArrow);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxCross);
            this.splitContainer1.Panel1.Controls.Add(this.labelRegistration);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.labelName);
            this.splitContainer1.Panel2.Controls.Add(this.labelTwoName);
            this.splitContainer1.Panel2.Controls.Add(this.labelTreeName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxThreeName);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRegistrationText);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTwoName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxOneName);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreateAccount);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 5;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(672, 15);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 46;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(728, 15);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCross.TabIndex = 28;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.BackColor = System.Drawing.Color.ForestGreen;
            this.labelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistration.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRegistration.Location = new System.Drawing.Point(303, 15);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(244, 44);
            this.labelRegistration.TabIndex = 0;
            this.labelRegistration.Text = "Регистрация";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(472, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(469, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Дата рождения";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelName.Location = new System.Drawing.Point(158, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Имя";
            // 
            // labelTwoName
            // 
            this.labelTwoName.AutoSize = true;
            this.labelTwoName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTwoName.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelTwoName.Location = new System.Drawing.Point(158, 132);
            this.labelTwoName.Name = "labelTwoName";
            this.labelTwoName.Size = new System.Drawing.Size(70, 17);
            this.labelTwoName.TabIndex = 22;
            this.labelTwoName.Text = "Фамилия";
            // 
            // labelTreeName
            // 
            this.labelTreeName.AutoSize = true;
            this.labelTreeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTreeName.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelTreeName.Location = new System.Drawing.Point(158, 201);
            this.labelTreeName.Name = "labelTreeName";
            this.labelTreeName.Size = new System.Drawing.Size(71, 17);
            this.labelTreeName.TabIndex = 21;
            this.labelTreeName.Text = "Отчество";
            // 
            // textBoxThreeName
            // 
            this.textBoxThreeName.BackColor = System.Drawing.Color.White;
            this.textBoxThreeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxThreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxThreeName.Location = new System.Drawing.Point(161, 220);
            this.textBoxThreeName.Name = "textBoxThreeName";
            this.textBoxThreeName.Size = new System.Drawing.Size(215, 23);
            this.textBoxThreeName.TabIndex = 10;
            this.textBoxThreeName.TextChanged += new System.EventHandler(this.textBoxThreeName_TextChanged);
            // 
            // buttonRegistrationText
            // 
            this.buttonRegistrationText.FlatAppearance.BorderSize = 0;
            this.buttonRegistrationText.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrationText.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrationText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistrationText.Location = new System.Drawing.Point(11, 317);
            this.buttonRegistrationText.Name = "buttonRegistrationText";
            this.buttonRegistrationText.Size = new System.Drawing.Size(70, 25);
            this.buttonRegistrationText.TabIndex = 8;
            this.buttonRegistrationText.Text = "Этап 1";
            this.buttonRegistrationText.UseVisualStyleBackColor = true;
            // 
            // textBoxTwoName
            // 
            this.textBoxTwoName.BackColor = System.Drawing.Color.White;
            this.textBoxTwoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTwoName.Location = new System.Drawing.Point(161, 152);
            this.textBoxTwoName.Name = "textBoxTwoName";
            this.textBoxTwoName.Size = new System.Drawing.Size(215, 23);
            this.textBoxTwoName.TabIndex = 5;
            this.textBoxTwoName.TextChanged += new System.EventHandler(this.textBoxTwoName_TextChanged);
            // 
            // textBoxOneName
            // 
            this.textBoxOneName.BackColor = System.Drawing.Color.White;
            this.textBoxOneName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOneName.Location = new System.Drawing.Point(161, 79);
            this.textBoxOneName.Name = "textBoxOneName";
            this.textBoxOneName.Size = new System.Drawing.Size(215, 23);
            this.textBoxOneName.TabIndex = 4;
            this.textBoxOneName.TextChanged += new System.EventHandler(this.textBoxOneName_TextChanged);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.FlatAppearance.BorderSize = 2;
            this.buttonCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateAccount.Location = new System.Drawing.Point(353, 289);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(129, 33);
            this.buttonCreateAccount.TabIndex = 2;
            this.buttonCreateAccount.Text = "Далее";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // RegistrationForm1
            // 
            this.AcceptButton = this.buttonCreateAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RegitrationForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Button buttonRegistrationText;
        private System.Windows.Forms.TextBox textBoxTwoName;
        private System.Windows.Forms.TextBox textBoxOneName;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.TextBox textBoxThreeName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTwoName;
        private System.Windows.Forms.Label labelTreeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
    }
}