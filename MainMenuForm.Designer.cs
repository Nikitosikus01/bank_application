
namespace Credits1
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.linkLabelRegistration = new System.Windows.Forms.LinkLabel();
            this.linkLabelAutorisation = new System.Windows.Forms.LinkLabel();
            this.buttonAboutBank = new System.Windows.Forms.Button();
            this.buttonNews = new System.Windows.Forms.Button();
            this.buttonServises = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxCross);
            this.splitContainer1.Panel1.Controls.Add(this.labelMainMenu);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.linkLabelRegistration);
            this.splitContainer1.Panel2.Controls.Add(this.linkLabelAutorisation);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAboutBank);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNews);
            this.splitContainer1.Panel2.Controls.Add(this.buttonServises);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(801, 495);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(727, 20);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCross.TabIndex = 30;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.labelMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMainMenu.Location = new System.Drawing.Point(265, 20);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(275, 44);
            this.labelMainMenu.TabIndex = 0;
            this.labelMainMenu.Text = "Главное меню";
            this.labelMainMenu.Click += new System.EventHandler(this.labelMainMenu_Click);
            // 
            // linkLabelRegistration
            // 
            this.linkLabelRegistration.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelRegistration.AutoSize = true;
            this.linkLabelRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelRegistration.LinkColor = System.Drawing.Color.ForestGreen;
            this.linkLabelRegistration.Location = new System.Drawing.Point(282, 313);
            this.linkLabelRegistration.Name = "linkLabelRegistration";
            this.linkLabelRegistration.Size = new System.Drawing.Size(236, 18);
            this.linkLabelRegistration.TabIndex = 6;
            this.linkLabelRegistration.TabStop = true;
            this.linkLabelRegistration.Text = "Хотите зарегистрироваться?";
            this.linkLabelRegistration.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLabelRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistration_LinkClicked);
            // 
            // linkLabelAutorisation
            // 
            this.linkLabelAutorisation.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelAutorisation.AutoSize = true;
            this.linkLabelAutorisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelAutorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelAutorisation.LinkColor = System.Drawing.Color.ForestGreen;
            this.linkLabelAutorisation.Location = new System.Drawing.Point(296, 283);
            this.linkLabelAutorisation.Name = "linkLabelAutorisation";
            this.linkLabelAutorisation.Size = new System.Drawing.Size(202, 18);
            this.linkLabelAutorisation.TabIndex = 5;
            this.linkLabelAutorisation.TabStop = true;
            this.linkLabelAutorisation.Text = "Хотите войти в аккаунт?";
            this.linkLabelAutorisation.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLabelAutorisation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAutorisation_LinkClicked);
            // 
            // buttonAboutBank
            // 
            this.buttonAboutBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAboutBank.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonAboutBank.FlatAppearance.BorderSize = 2;
            this.buttonAboutBank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonAboutBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonAboutBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAboutBank.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonAboutBank.Location = new System.Drawing.Point(302, 174);
            this.buttonAboutBank.Name = "buttonAboutBank";
            this.buttonAboutBank.Size = new System.Drawing.Size(199, 55);
            this.buttonAboutBank.TabIndex = 2;
            this.buttonAboutBank.Text = "О банке";
            this.buttonAboutBank.UseVisualStyleBackColor = true;
            this.buttonAboutBank.Click += new System.EventHandler(this.buttonAboutBank_Click);
            // 
            // buttonNews
            // 
            this.buttonNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNews.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonNews.FlatAppearance.BorderSize = 2;
            this.buttonNews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonNews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNews.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonNews.Location = new System.Drawing.Point(302, 108);
            this.buttonNews.Name = "buttonNews";
            this.buttonNews.Size = new System.Drawing.Size(199, 55);
            this.buttonNews.TabIndex = 1;
            this.buttonNews.Text = "Новости";
            this.buttonNews.UseVisualStyleBackColor = true;
            this.buttonNews.Click += new System.EventHandler(this.buttonNews_Click);
            // 
            // buttonServises
            // 
            this.buttonServises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonServises.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonServises.FlatAppearance.BorderSize = 2;
            this.buttonServises.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonServises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonServises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServises.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonServises.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonServises.Location = new System.Drawing.Point(302, 42);
            this.buttonServises.Name = "buttonServises";
            this.buttonServises.Size = new System.Drawing.Size(199, 55);
            this.buttonServises.TabIndex = 0;
            this.buttonServises.Text = "Услуги";
            this.buttonServises.UseVisualStyleBackColor = true;
            this.buttonServises.Click += new System.EventHandler(this.buttonServises_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 495);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu Form";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Button buttonServises;
        private System.Windows.Forms.Button buttonAboutBank;
        private System.Windows.Forms.Button buttonNews;
        private System.Windows.Forms.LinkLabel linkLabelRegistration;
        private System.Windows.Forms.LinkLabel linkLabelAutorisation;
        private System.Windows.Forms.PictureBox pictureBoxCross;
    }
}

