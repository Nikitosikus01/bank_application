
using System;

namespace Credits1
{
    partial class DepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.textBoxPickedDeposit = new System.Windows.Forms.TextBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxСurrencyOrValue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.buttonInquiry = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel2.Controls.Add(this.buttonCheckOut);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPickedDeposit);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTime);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxСurrencyOrValue);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDeposit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonInquiry);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(820, 437);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 4;
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
            // textBoxPickedDeposit
            // 
            this.textBoxPickedDeposit.BackColor = System.Drawing.Color.White;
            this.textBoxPickedDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPickedDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPickedDeposit.Location = new System.Drawing.Point(200, 227);
            this.textBoxPickedDeposit.Multiline = true;
            this.textBoxPickedDeposit.Name = "textBoxPickedDeposit";
            this.textBoxPickedDeposit.ReadOnly = true;
            this.textBoxPickedDeposit.Size = new System.Drawing.Size(405, 84);
            this.textBoxPickedDeposit.TabIndex = 20;
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
            this.comboBoxTime.Location = new System.Drawing.Point(490, 73);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(163, 21);
            this.comboBoxTime.TabIndex = 19;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxTime_SelectedIndexChanged);
            // 
            // comboBoxСurrencyOrValue
            // 
            this.comboBoxСurrencyOrValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxСurrencyOrValue.FormattingEnabled = true;
            this.comboBoxСurrencyOrValue.Items.AddRange(new object[] {
            "Доллар",
            "Рубль"});
            this.comboBoxСurrencyOrValue.Location = new System.Drawing.Point(156, 72);
            this.comboBoxСurrencyOrValue.Name = "comboBoxСurrencyOrValue";
            this.comboBoxСurrencyOrValue.Size = new System.Drawing.Size(163, 21);
            this.comboBoxСurrencyOrValue.TabIndex = 18;
            this.comboBoxСurrencyOrValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxСurrencyOrValue_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(378, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Срок вклада";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Валюта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(128, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сумма вклада";
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.BackColor = System.Drawing.Color.White;
            this.textBoxDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeposit.Location = new System.Drawing.Point(271, 127);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(334, 23);
            this.textBoxDeposit.TabIndex = 14;
            // 
            // buttonInquiry
            // 
            this.buttonInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInquiry.FlatAppearance.BorderSize = 2;
            this.buttonInquiry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInquiry.Location = new System.Drawing.Point(307, 190);
            this.buttonInquiry.Name = "buttonInquiry";
            this.buttonInquiry.Size = new System.Drawing.Size(166, 31);
            this.buttonInquiry.TabIndex = 2;
            this.buttonInquiry.Text = "Сформировать";
            this.buttonInquiry.UseVisualStyleBackColor = true;
            this.buttonInquiry.Click += new System.EventHandler(this.buttonInquiry_Click_1);
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
            this.buttonCheckOut.Location = new System.Drawing.Point(649, 280);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(147, 31);
            this.buttonCheckOut.TabIndex = 21;
            this.buttonCheckOut.Text = "Оформить заказ";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 437);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositForm";
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

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Button buttonInquiry;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.ComboBox comboBoxСurrencyOrValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.TextBox textBoxPickedDeposit;
        private System.Windows.Forms.Button buttonCheckOut;
    }
}