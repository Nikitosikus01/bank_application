
namespace Credits1
{
    partial class ServisesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServisesForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.labelServises = new System.Windows.Forms.Label();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.buttonInvest = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonCredit = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.labelServises);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxCross);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonInvest);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDeposit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCredit);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 449);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(683, 18);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 33;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBoxArrow_Click);
            // 
            // labelServises
            // 
            this.labelServises.AutoSize = true;
            this.labelServises.BackColor = System.Drawing.Color.ForestGreen;
            this.labelServises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelServises.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServises.ForeColor = System.Drawing.SystemColors.Control;
            this.labelServises.Location = new System.Drawing.Point(328, 18);
            this.labelServises.Name = "labelServises";
            this.labelServises.Size = new System.Drawing.Size(140, 44);
            this.labelServises.TabIndex = 0;
            this.labelServises.Text = "Услуги";
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(739, 18);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCross.TabIndex = 31;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // buttonInvest
            // 
            this.buttonInvest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInvest.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonInvest.FlatAppearance.BorderSize = 2;
            this.buttonInvest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonInvest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonInvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInvest.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonInvest.Location = new System.Drawing.Point(302, 174);
            this.buttonInvest.Name = "buttonInvest";
            this.buttonInvest.Size = new System.Drawing.Size(199, 55);
            this.buttonInvest.TabIndex = 2;
            this.buttonInvest.Text = "Инвестиции";
            this.buttonInvest.UseVisualStyleBackColor = true;
            this.buttonInvest.Click += new System.EventHandler(this.buttonInvest_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeposit.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonDeposit.FlatAppearance.BorderSize = 2;
            this.buttonDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonDeposit.Location = new System.Drawing.Point(302, 108);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(199, 55);
            this.buttonDeposit.TabIndex = 1;
            this.buttonDeposit.Text = "Депозиты";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonCredit
            // 
            this.buttonCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCredit.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonCredit.FlatAppearance.BorderSize = 2;
            this.buttonCredit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonCredit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCredit.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonCredit.Location = new System.Drawing.Point(302, 42);
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.Size = new System.Drawing.Size(199, 55);
            this.buttonCredit.TabIndex = 0;
            this.buttonCredit.Text = "Кредиты";
            this.buttonCredit.UseVisualStyleBackColor = true;
            this.buttonCredit.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // ServisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServisesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServisesForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelServises;
        private System.Windows.Forms.Button buttonInvest;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonCredit;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
    }
}