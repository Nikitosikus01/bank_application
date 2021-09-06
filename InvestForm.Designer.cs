
namespace Credits1
{
    partial class InvestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvestForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelInvest = new System.Windows.Forms.Label();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonInquiry = new System.Windows.Forms.Button();
            this.comboBoxChioceInvest = new System.Windows.Forms.ComboBox();
            this.textBoxPickedInfo = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxUnvisible = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.labelInvest);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxCross);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxArrow);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxUnvisible);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSum);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPickedInfo);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxChioceInvest);
            this.splitContainer1.Panel2.Controls.Add(this.labelTime);
            this.splitContainer1.Panel2.Controls.Add(this.labelSum);
            this.splitContainer1.Panel2.Controls.Add(this.buttonInquiry);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 4;
            // 
            // labelInvest
            // 
            this.labelInvest.AutoSize = true;
            this.labelInvest.BackColor = System.Drawing.Color.ForestGreen;
            this.labelInvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInvest.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInvest.Location = new System.Drawing.Point(295, 18);
            this.labelInvest.Name = "labelInvest";
            this.labelInvest.Size = new System.Drawing.Size(230, 44);
            this.labelInvest.TabIndex = 0;
            this.labelInvest.Text = "Инвестиции";
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(728, 18);
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
            this.pictureBoxArrow.Location = new System.Drawing.Point(662, 18);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 30;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBoxArrow_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(124, 130);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(128, 20);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Введите сумму ";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(124, 66);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(258, 20);
            this.labelSum.TabIndex = 9;
            this.labelSum.Text = "Выберите во что инвестировать";
            // 
            // buttonInquiry
            // 
            this.buttonInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInquiry.FlatAppearance.BorderSize = 2;
            this.buttonInquiry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInquiry.Location = new System.Drawing.Point(328, 246);
            this.buttonInquiry.Name = "buttonInquiry";
            this.buttonInquiry.Size = new System.Drawing.Size(166, 31);
            this.buttonInquiry.TabIndex = 2;
            this.buttonInquiry.Text = "Инвестировать!";
            this.buttonInquiry.UseVisualStyleBackColor = true;
            this.buttonInquiry.Click += new System.EventHandler(this.buttonInquiry_Click);
            // 
            // comboBoxChioceInvest
            // 
            this.comboBoxChioceInvest.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxChioceInvest.AllowDrop = true;
            this.comboBoxChioceInvest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChioceInvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChioceInvest.FormattingEnabled = true;
            this.comboBoxChioceInvest.Items.AddRange(new object[] {
            "Недвижимость "});
            this.comboBoxChioceInvest.Location = new System.Drawing.Point(128, 89);
            this.comboBoxChioceInvest.Name = "comboBoxChioceInvest";
            this.comboBoxChioceInvest.Size = new System.Drawing.Size(254, 24);
            this.comboBoxChioceInvest.TabIndex = 17;
            this.comboBoxChioceInvest.SelectedIndexChanged += new System.EventHandler(this.comboBoxChioceInvest_SelectedIndexChanged);
            // 
            // textBoxPickedInfo
            // 
            this.textBoxPickedInfo.BackColor = System.Drawing.Color.White;
            this.textBoxPickedInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPickedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPickedInfo.Location = new System.Drawing.Point(400, 89);
            this.textBoxPickedInfo.Multiline = true;
            this.textBoxPickedInfo.Name = "textBoxPickedInfo";
            this.textBoxPickedInfo.ReadOnly = true;
            this.textBoxPickedInfo.Size = new System.Drawing.Size(330, 87);
            this.textBoxPickedInfo.TabIndex = 21;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(128, 153);
            this.textBoxSum.MaxLength = 7;
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(254, 23);
            this.textBoxSum.TabIndex = 22;
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxUnvisible
            // 
            this.textBoxUnvisible.BackColor = System.Drawing.Color.White;
            this.textBoxUnvisible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUnvisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUnvisible.Location = new System.Drawing.Point(517, 219);
            this.textBoxUnvisible.Multiline = true;
            this.textBoxUnvisible.Name = "textBoxUnvisible";
            this.textBoxUnvisible.ReadOnly = true;
            this.textBoxUnvisible.Size = new System.Drawing.Size(232, 58);
            this.textBoxUnvisible.TabIndex = 23;
            this.textBoxUnvisible.Visible = false;
            // 
            // InvestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvestForm";
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
        private System.Windows.Forms.Label labelInvest;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button buttonInquiry;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.ComboBox comboBoxChioceInvest;
        private System.Windows.Forms.TextBox textBoxPickedInfo;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxUnvisible;
    }
}