
namespace Credits1
{
    partial class CreditsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.textBoxPickedCredit = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.buttonCreditText = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.buttonInquiry = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.labelCredits);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonCheckOut);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPickedCredit);
            this.splitContainer1.Panel2.Controls.Add(this.labelTime);
            this.splitContainer1.Panel2.Controls.Add(this.labelSum);
            this.splitContainer1.Panel2.Controls.Add(this.labelAge);
            this.splitContainer1.Panel2.Controls.Add(this.labelIncome);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreditText);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTime);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSum);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAge);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIncome);
            this.splitContainer1.Panel2.Controls.Add(this.buttonInquiry);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 482);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 3;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(663, 18);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 30;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBoxArrow_Click);
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(726, 18);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCross.TabIndex = 31;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.BackColor = System.Drawing.Color.ForestGreen;
            this.labelCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCredits.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCredits.Location = new System.Drawing.Point(301, 18);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(174, 44);
            this.labelCredits.TabIndex = 0;
            this.labelCredits.Text = "Кредиты";
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckOut.Enabled = false;
            this.buttonCheckOut.FlatAppearance.BorderSize = 2;
            this.buttonCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCheckOut.Location = new System.Drawing.Point(629, 337);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(147, 31);
            this.buttonCheckOut.TabIndex = 16;
            this.buttonCheckOut.Text = "Оформить заказ";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // textBoxPickedCredit
            // 
            this.textBoxPickedCredit.BackColor = System.Drawing.Color.White;
            this.textBoxPickedCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPickedCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPickedCredit.Location = new System.Drawing.Point(193, 284);
            this.textBoxPickedCredit.Multiline = true;
            this.textBoxPickedCredit.Name = "textBoxPickedCredit";
            this.textBoxPickedCredit.ReadOnly = true;
            this.textBoxPickedCredit.Size = new System.Drawing.Size(405, 84);
            this.textBoxPickedCredit.TabIndex = 14;
            this.textBoxPickedCredit.TextChanged += new System.EventHandler(this.textBoxPickedCredit_TextChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(423, 170);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(361, 17);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Введите желаемый срок кредита (не более 360 мес):";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(423, 102);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(239, 17);
            this.labelSum.TabIndex = 11;
            this.labelSum.Text = "Введите желаемую сумму кредита:";
            this.labelSum.Click += new System.EventHandler(this.labelSum_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(36, 170);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(242, 17);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Введите ваш возраст (от 18 до 84):";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIncome.Location = new System.Drawing.Point(35, 102);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(324, 17);
            this.labelIncome.TabIndex = 9;
            this.labelIncome.Text = "Введите ваш доход в месяц (не менее 270 руб):";
            // 
            // buttonCreditText
            // 
            this.buttonCreditText.FlatAppearance.BorderSize = 0;
            this.buttonCreditText.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonCreditText.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCreditText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreditText.Location = new System.Drawing.Point(87, 16);
            this.buttonCreditText.Name = "buttonCreditText";
            this.buttonCreditText.Size = new System.Drawing.Size(610, 51);
            this.buttonCreditText.TabIndex = 8;
            this.buttonCreditText.Text = "Заполните все пустые ячейки и тогда мы сможем собрать для вас самый подходящий кр" +
    "едит!";
            this.buttonCreditText.UseVisualStyleBackColor = true;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.White;
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime.Location = new System.Drawing.Point(426, 190);
            this.textBoxTime.MaxLength = 3;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(320, 23);
            this.textBoxTime.TabIndex = 7;
            this.textBoxTime.Enter += new System.EventHandler(this.textBoxTime_Enter);
            this.textBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTime_KeyPress);
            this.textBoxTime.Leave += new System.EventHandler(this.textBoxTime_Leave);
            // 
            // textBoxSum
            // 
            this.textBoxSum.BackColor = System.Drawing.Color.White;
            this.textBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(426, 122);
            this.textBoxSum.MaxLength = 9;
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(320, 23);
            this.textBoxSum.TabIndex = 6;
            this.textBoxSum.Enter += new System.EventHandler(this.textBoxSum_Enter);
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSum_KeyPress);
            this.textBoxSum.Leave += new System.EventHandler(this.textBoxSum_Leave);
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.White;
            this.textBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAge.Location = new System.Drawing.Point(39, 190);
            this.textBoxAge.MaxLength = 2;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(320, 23);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            this.textBoxAge.Enter += new System.EventHandler(this.textBoxAge_Enter);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            this.textBoxAge.Leave += new System.EventHandler(this.textBoxAge_Leave);
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.BackColor = System.Drawing.Color.White;
            this.textBoxIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIncome.Location = new System.Drawing.Point(39, 122);
            this.textBoxIncome.MaxLength = 10;
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(320, 23);
            this.textBoxIncome.TabIndex = 4;
            this.textBoxIncome.TextChanged += new System.EventHandler(this.textBoxIncome_TextChanged);
            this.textBoxIncome.Enter += new System.EventHandler(this.textBoxIncome_Enter);
            this.textBoxIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIncome_KeyPress);
            this.textBoxIncome.Leave += new System.EventHandler(this.textBoxIncome_Leave);
            // 
            // buttonInquiry
            // 
            this.buttonInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInquiry.FlatAppearance.BorderSize = 2;
            this.buttonInquiry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonInquiry.Location = new System.Drawing.Point(309, 238);
            this.buttonInquiry.Name = "buttonInquiry";
            this.buttonInquiry.Size = new System.Drawing.Size(166, 31);
            this.buttonInquiry.TabIndex = 2;
            this.buttonInquiry.Text = "Собрать";
            this.buttonInquiry.UseVisualStyleBackColor = true;
            this.buttonInquiry.Click += new System.EventHandler(this.buttonInquiry_Click);
            // 
            // CreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditsForm";
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
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.Button buttonInquiry;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Button buttonCreditText;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPickedCredit;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.Button buttonCheckOut;
    }
}