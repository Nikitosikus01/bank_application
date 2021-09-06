
namespace Credits1
{
    partial class ConfirmEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmEmailForm));
            this.labelCodeFromEmail = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodeFromEmail
            // 
            this.labelCodeFromEmail.AutoSize = true;
            this.labelCodeFromEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCodeFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCodeFromEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelCodeFromEmail.Location = new System.Drawing.Point(8, 22);
            this.labelCodeFromEmail.Name = "labelCodeFromEmail";
            this.labelCodeFromEmail.Size = new System.Drawing.Size(166, 20);
            this.labelCodeFromEmail.TabIndex = 23;
            this.labelCodeFromEmail.Text = "Код подтверждения";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.Location = new System.Drawing.Point(12, 45);
            this.textBoxCode.MaxLength = 4;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(240, 23);
            this.textBoxCode.TabIndex = 22;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.FlatAppearance.BorderSize = 2;
            this.buttonConfirm.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.buttonConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirm.Location = new System.Drawing.Point(12, 83);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(117, 33);
            this.buttonConfirm.TabIndex = 24;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(135, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfirmEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(270, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelCodeFromEmail);
            this.Controls.Add(this.textBoxCode);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmEmailForm";
            this.Load += new System.EventHandler(this.ConfirmEmailForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfirmEmailForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfirmEmailForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeFromEmail;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button1;
    }
}