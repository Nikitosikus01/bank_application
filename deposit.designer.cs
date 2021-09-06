
namespace Credits1
{
    partial class deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deposit));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.textBoxPickedDeposit = new System.Windows.Forms.TextBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxСurrencyOrValue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSchet = new System.Windows.Forms.Label();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.buttonInquiry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxCross);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxArrow);
            this.splitContainer1.Panel1.Controls.Add(this.labelDeposit);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCheckOut);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPickedDeposit);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTime);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxСurrencyOrValue);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.labelSchet);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDeposit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonInquiry);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 5;
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(746, 18);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCross.TabIndex = 31;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(680, 18);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 30;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBoxArrow_Click);
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.BackColor = System.Drawing.Color.ForestGreen;
            this.labelDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeposit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDeposit.Location = new System.Drawing.Point(326, 18);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(196, 44);
            this.labelDeposit.TabIndex = 0;
            this.labelDeposit.Text = "Депозиты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(626, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "месяцев";
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckOut.Enabled = false;
            this.buttonCheckOut.FlatAppearance.BorderSize = 2;
            this.buttonCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckOut.Location = new System.Drawing.Point(621, 293);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(166, 31);
            this.buttonCheckOut.TabIndex = 22;
            this.buttonCheckOut.Text = "Отправить запрос";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // textBoxPickedDeposit
            // 
            this.textBoxPickedDeposit.BackColor = System.Drawing.Color.White;
            this.textBoxPickedDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPickedDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPickedDeposit.Location = new System.Drawing.Point(203, 240);
            this.textBoxPickedDeposit.Multiline = true;
            this.textBoxPickedDeposit.Name = "textBoxPickedDeposit";
            this.textBoxPickedDeposit.ReadOnly = true;
            this.textBoxPickedDeposit.Size = new System.Drawing.Size(405, 84);
            this.textBoxPickedDeposit.TabIndex = 21;
            this.textBoxPickedDeposit.TextChanged += new System.EventHandler(this.textBoxPickedDeposit_TextChanged);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "3 ",
            "6",
            "12",
            "24",
            "36",
            "60"});
            this.comboBoxTime.Location = new System.Drawing.Point(503, 60);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(117, 21);
            this.comboBoxTime.TabIndex = 13;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxTime_SelectedIndexChanged);
            // 
            // comboBoxСurrencyOrValue
            // 
            this.comboBoxСurrencyOrValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxСurrencyOrValue.FormattingEnabled = true;
            this.comboBoxСurrencyOrValue.Items.AddRange(new object[] {
            "Доллар",
            "Рубль"});
            this.comboBoxСurrencyOrValue.Location = new System.Drawing.Point(229, 60);
            this.comboBoxСurrencyOrValue.Name = "comboBoxСurrencyOrValue";
            this.comboBoxСurrencyOrValue.Size = new System.Drawing.Size(141, 21);
            this.comboBoxСurrencyOrValue.TabIndex = 12;
            this.comboBoxСurrencyOrValue.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(391, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Срок вклада";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(154, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Валюта";
            // 
            // labelSchet
            // 
            this.labelSchet.AutoSize = true;
            this.labelSchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSchet.Location = new System.Drawing.Point(154, 109);
            this.labelSchet.Name = "labelSchet";
            this.labelSchet.Size = new System.Drawing.Size(118, 20);
            this.labelSchet.TabIndex = 9;
            this.labelSchet.Text = "Сумма вклада";
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.BackColor = System.Drawing.Color.White;
            this.textBoxDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDeposit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeposit.Location = new System.Drawing.Point(278, 109);
            this.textBoxDeposit.MaxLength = 5;
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(406, 23);
            this.textBoxDeposit.TabIndex = 4;
            this.textBoxDeposit.UseWaitCursor = true;
            this.textBoxDeposit.TextChanged += new System.EventHandler(this.textBoxDeposit_TextChanged);
            this.textBoxDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeposit_KeyPress);
            // 
            // buttonInquiry
            // 
            this.buttonInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInquiry.FlatAppearance.BorderSize = 2;
            this.buttonInquiry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInquiry.Location = new System.Drawing.Point(322, 203);
            this.buttonInquiry.Name = "buttonInquiry";
            this.buttonInquiry.Size = new System.Drawing.Size(166, 31);
            this.buttonInquiry.TabIndex = 2;
            this.buttonInquiry.Text = "Собрать";
            this.buttonInquiry.UseVisualStyleBackColor = true;
            this.buttonInquiry.Click += new System.EventHandler(this.buttonInquiry_Click);
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deposit";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label labelSchet;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Button buttonInquiry;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.ComboBox comboBoxСurrencyOrValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPickedDeposit;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Label label3;
    }
}