
namespace Credits1
{
    partial class RegistrationForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm2));
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdentificationNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSerialNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.textBoxFullAddress = new System.Windows.Forms.TextBox();
            this.textBoxTownBirth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistrationText = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(457, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Идентификационный номер паспорта ";
            // 
            // textBoxIdentificationNum
            // 
            this.textBoxIdentificationNum.BackColor = System.Drawing.Color.White;
            this.textBoxIdentificationNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdentificationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdentificationNum.Location = new System.Drawing.Point(460, 175);
            this.textBoxIdentificationNum.Name = "textBoxIdentificationNum";
            this.textBoxIdentificationNum.Size = new System.Drawing.Size(269, 23);
            this.textBoxIdentificationNum.TabIndex = 32;
            this.textBoxIdentificationNum.TextChanged += new System.EventHandler(this.textBoxIdentificationNum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(457, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Серийный номер паспорта ";
            // 
            // textBoxSerialNum
            // 
            this.textBoxSerialNum.BackColor = System.Drawing.Color.White;
            this.textBoxSerialNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSerialNum.Location = new System.Drawing.Point(460, 93);
            this.textBoxSerialNum.Name = "textBoxSerialNum";
            this.textBoxSerialNum.Size = new System.Drawing.Size(269, 23);
            this.textBoxSerialNum.TabIndex = 30;
            this.textBoxSerialNum.TextChanged += new System.EventHandler(this.textBoxSerialNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(131, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Адрес проживания (полностью)";
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxCross);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxArrow);
            this.splitContainer1.Panel1.Controls.Add(this.labelRegistration);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFullAddress);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTownBirth);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIdentificationNum);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSerialNum);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRegistrationText);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreateAccount);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(725, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(727, 15);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCross.TabIndex = 47;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(660, 15);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 45;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBoxArrow_Click);
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.BackColor = System.Drawing.Color.ForestGreen;
            this.labelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistration.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRegistration.Location = new System.Drawing.Point(296, 15);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(244, 44);
            this.labelRegistration.TabIndex = 0;
            this.labelRegistration.Text = "Регистрация";
            // 
            // textBoxFullAddress
            // 
            this.textBoxFullAddress.BackColor = System.Drawing.Color.White;
            this.textBoxFullAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFullAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullAddress.Location = new System.Drawing.Point(134, 175);
            this.textBoxFullAddress.Name = "textBoxFullAddress";
            this.textBoxFullAddress.Size = new System.Drawing.Size(269, 23);
            this.textBoxFullAddress.TabIndex = 44;
            this.textBoxFullAddress.TextChanged += new System.EventHandler(this.textBoxFullAddress_TextChanged);
            // 
            // textBoxTownBirth
            // 
            this.textBoxTownBirth.BackColor = System.Drawing.Color.White;
            this.textBoxTownBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTownBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTownBirth.Location = new System.Drawing.Point(134, 93);
            this.textBoxTownBirth.Name = "textBoxTownBirth";
            this.textBoxTownBirth.Size = new System.Drawing.Size(269, 23);
            this.textBoxTownBirth.TabIndex = 43;
            this.textBoxTownBirth.TextChanged += new System.EventHandler(this.textBoxTownBirth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(131, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Место рождения (Город)";
            // 
            // buttonRegistrationText
            // 
            this.buttonRegistrationText.FlatAppearance.BorderSize = 0;
            this.buttonRegistrationText.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrationText.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrationText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistrationText.Location = new System.Drawing.Point(11, 318);
            this.buttonRegistrationText.Name = "buttonRegistrationText";
            this.buttonRegistrationText.Size = new System.Drawing.Size(71, 24);
            this.buttonRegistrationText.TabIndex = 8;
            this.buttonRegistrationText.Text = "Этап 2";
            this.buttonRegistrationText.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.FlatAppearance.BorderSize = 2;
            this.buttonCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateAccount.Location = new System.Drawing.Point(361, 287);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(129, 33);
            this.buttonCreateAccount.TabIndex = 2;
            this.buttonCreateAccount.Text = "Далее";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // RegistrationForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm2";
            this.Load += new System.EventHandler(this.RegistrationForm2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdentificationNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSerialNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Button buttonRegistrationText;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFullAddress;
        private System.Windows.Forms.TextBox textBoxTownBirth;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}