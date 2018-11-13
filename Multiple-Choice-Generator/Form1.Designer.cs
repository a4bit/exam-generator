namespace Multiple_Choice_Generator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftmenuP = new System.Windows.Forms.Panel();
            this.helpB = new System.Windows.Forms.Button();
            this.logoL = new System.Windows.Forms.Label();
            this.titleL = new System.Windows.Forms.Label();
            this.settingsB = new System.Windows.Forms.Button();
            this.logoutB = new System.Windows.Forms.Button();
            this.testB = new System.Windows.Forms.Button();
            this.questionsB = new System.Windows.Forms.Button();
            this.createL = new System.Windows.Forms.Label();
            this.createSubMenuP = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create_questionL = new System.Windows.Forms.Label();
            this.topmenuP = new System.Windows.Forms.Panel();
            this.editL = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.editSubMenuP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.leftmenuP.SuspendLayout();
            this.createSubMenuP.SuspendLayout();
            this.topmenuP.SuspendLayout();
            this.editSubMenuP.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftmenuP
            // 
            this.leftmenuP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftmenuP.BackColor = System.Drawing.Color.DodgerBlue;
            this.leftmenuP.Controls.Add(this.helpB);
            this.leftmenuP.Controls.Add(this.logoL);
            this.leftmenuP.Controls.Add(this.titleL);
            this.leftmenuP.Controls.Add(this.settingsB);
            this.leftmenuP.Controls.Add(this.logoutB);
            this.leftmenuP.Controls.Add(this.testB);
            this.leftmenuP.Controls.Add(this.questionsB);
            this.leftmenuP.Location = new System.Drawing.Point(0, 0);
            this.leftmenuP.Margin = new System.Windows.Forms.Padding(0);
            this.leftmenuP.Name = "leftmenuP";
            this.leftmenuP.Size = new System.Drawing.Size(223, 636);
            this.leftmenuP.TabIndex = 0;
            this.leftmenuP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.leftmenuP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.leftmenuP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // helpB
            // 
            this.helpB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.helpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpB.Image = ((System.Drawing.Image)(resources.GetObject("helpB.Image")));
            this.helpB.Location = new System.Drawing.Point(12, 594);
            this.helpB.Name = "helpB";
            this.helpB.Size = new System.Drawing.Size(47, 39);
            this.helpB.TabIndex = 11;
            this.helpB.UseVisualStyleBackColor = true;
            // 
            // logoL
            // 
            this.logoL.AutoSize = true;
            this.logoL.Location = new System.Drawing.Point(76, 60);
            this.logoL.Name = "logoL";
            this.logoL.Size = new System.Drawing.Size(27, 13);
            this.logoL.TabIndex = 13;
            this.logoL.Text = "logo";
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleL.ForeColor = System.Drawing.Color.White;
            this.titleL.Location = new System.Drawing.Point(21, 150);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(178, 56);
            this.titleL.TabIndex = 12;
            this.titleL.Text = "Multiple Choice\r\nGenerator";
            this.titleL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsB
            // 
            this.settingsB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.settingsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsB.Image = ((System.Drawing.Image)(resources.GetObject("settingsB.Image")));
            this.settingsB.Location = new System.Drawing.Point(130, 594);
            this.settingsB.Name = "settingsB";
            this.settingsB.Size = new System.Drawing.Size(39, 39);
            this.settingsB.TabIndex = 10;
            this.settingsB.UseVisualStyleBackColor = true;
            // 
            // logoutB
            // 
            this.logoutB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoutB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.logoutB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutB.Image = ((System.Drawing.Image)(resources.GetObject("logoutB.Image")));
            this.logoutB.Location = new System.Drawing.Point(175, 594);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(45, 39);
            this.logoutB.TabIndex = 9;
            this.logoutB.UseVisualStyleBackColor = true;
            // 
            // testB
            // 
            this.testB.AutoSize = true;
            this.testB.BackColor = System.Drawing.Color.SteelBlue;
            this.testB.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.testB.FlatAppearance.BorderSize = 0;
            this.testB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.testB.ForeColor = System.Drawing.Color.White;
            this.testB.Image = ((System.Drawing.Image)(resources.GetObject("testB.Image")));
            this.testB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.testB.Location = new System.Drawing.Point(0, 327);
            this.testB.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.testB.Name = "testB";
            this.testB.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.testB.Size = new System.Drawing.Size(223, 45);
            this.testB.TabIndex = 8;
            this.testB.Text = "Διαγωνίσματα\r\n";
            this.testB.UseVisualStyleBackColor = false;
            // 
            // questionsB
            // 
            this.questionsB.AutoSize = true;
            this.questionsB.BackColor = System.Drawing.Color.SteelBlue;
            this.questionsB.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.questionsB.FlatAppearance.BorderSize = 0;
            this.questionsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionsB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionsB.ForeColor = System.Drawing.Color.White;
            this.questionsB.Image = ((System.Drawing.Image)(resources.GetObject("questionsB.Image")));
            this.questionsB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.questionsB.Location = new System.Drawing.Point(0, 276);
            this.questionsB.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.questionsB.Name = "questionsB";
            this.questionsB.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.questionsB.Size = new System.Drawing.Size(223, 45);
            this.questionsB.TabIndex = 7;
            this.questionsB.Text = "Ερωτήσεις";
            this.questionsB.UseVisualStyleBackColor = false;
            // 
            // createL
            // 
            this.createL.BackColor = System.Drawing.Color.DodgerBlue;
            this.createL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createL.ForeColor = System.Drawing.Color.White;
            this.createL.Location = new System.Drawing.Point(13, 7);
            this.createL.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.createL.Name = "createL";
            this.createL.Size = new System.Drawing.Size(149, 46);
            this.createL.TabIndex = 0;
            this.createL.Text = "Δημιουργία";
            this.createL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createL.Leave += new System.EventHandler(this.topmenu_Leave);
            this.createL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topmenu_MouseClick);
            this.createL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topmenu_MouseDown);
            this.createL.MouseEnter += new System.EventHandler(this.topmenu_MouseEnter);
            this.createL.MouseLeave += new System.EventHandler(this.topmenu_MouseLeave);
            // 
            // createSubMenuP
            // 
            this.createSubMenuP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createSubMenuP.Controls.Add(this.label3);
            this.createSubMenuP.Controls.Add(this.label2);
            this.createSubMenuP.Controls.Add(this.create_questionL);
            this.createSubMenuP.Location = new System.Drawing.Point(236, 53);
            this.createSubMenuP.Margin = new System.Windows.Forms.Padding(0);
            this.createSubMenuP.Name = "createSubMenuP";
            this.createSubMenuP.Size = new System.Drawing.Size(149, 0);
            this.createSubMenuP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(149, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Διαγωνίσματος";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 34);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(149, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Μαθήματος";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // create_questionL
            // 
            this.create_questionL.BackColor = System.Drawing.SystemColors.Highlight;
            this.create_questionL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.create_questionL.ForeColor = System.Drawing.Color.White;
            this.create_questionL.Location = new System.Drawing.Point(1, 0);
            this.create_questionL.Name = "create_questionL";
            this.create_questionL.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.create_questionL.Size = new System.Drawing.Size(149, 34);
            this.create_questionL.TabIndex = 0;
            this.create_questionL.Text = "Ερώτησης";
            this.create_questionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topmenuP
            // 
            this.topmenuP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topmenuP.BackColor = System.Drawing.Color.DodgerBlue;
            this.topmenuP.Controls.Add(this.editL);
            this.topmenuP.Controls.Add(this.searchTB);
            this.topmenuP.Controls.Add(this.createL);
            this.topmenuP.Location = new System.Drawing.Point(223, 0);
            this.topmenuP.Margin = new System.Windows.Forms.Padding(0);
            this.topmenuP.Name = "topmenuP";
            this.topmenuP.Size = new System.Drawing.Size(965, 53);
            this.topmenuP.TabIndex = 3;
            // 
            // editL
            // 
            this.editL.BackColor = System.Drawing.Color.DodgerBlue;
            this.editL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editL.ForeColor = System.Drawing.Color.White;
            this.editL.Location = new System.Drawing.Point(166, 7);
            this.editL.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.editL.Name = "editL";
            this.editL.Size = new System.Drawing.Size(149, 46);
            this.editL.TabIndex = 2;
            this.editL.Text = "Επεξεργασία";
            this.editL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editL.Leave += new System.EventHandler(this.topmenu_Leave);
            this.editL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topmenu_MouseClick);
            this.editL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topmenu_MouseDown);
            this.editL.MouseEnter += new System.EventHandler(this.topmenu_MouseEnter);
            this.editL.MouseLeave += new System.EventHandler(this.topmenu_MouseLeave);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchTB.BackColor = System.Drawing.Color.White;
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTB.ForeColor = System.Drawing.Color.Gray;
            this.searchTB.Location = new System.Drawing.Point(656, 15);
            this.searchTB.MaxLength = 100;
            this.searchTB.MinimumSize = new System.Drawing.Size(200, 20);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(293, 29);
            this.searchTB.TabIndex = 1;
            this.searchTB.Text = "Search...";
            this.searchTB.Enter += new System.EventHandler(this.searchTBPLaceholder_Enter);
            this.searchTB.Leave += new System.EventHandler(this.searchTBPlaceholder_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // editSubMenuP
            // 
            this.editSubMenuP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editSubMenuP.Controls.Add(this.label1);
            this.editSubMenuP.Controls.Add(this.label4);
            this.editSubMenuP.Controls.Add(this.label5);
            this.editSubMenuP.Location = new System.Drawing.Point(389, 53);
            this.editSubMenuP.Margin = new System.Windows.Forms.Padding(0);
            this.editSubMenuP.Name = "editSubMenuP";
            this.editSubMenuP.Size = new System.Drawing.Size(149, 0);
            this.editSubMenuP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Διαγωνίσματος";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 34);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(149, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Μαθήματος";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(149, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ερώτησης";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.editSubMenuP);
            this.Controls.Add(this.topmenuP);
            this.Controls.Add(this.createSubMenuP);
            this.Controls.Add(this.leftmenuP);
            this.MinimumSize = new System.Drawing.Size(900, 506);
            this.Name = "Form1";
            this.Text = "Multiple Choice Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.leftmenuP.ResumeLayout(false);
            this.leftmenuP.PerformLayout();
            this.createSubMenuP.ResumeLayout(false);
            this.topmenuP.ResumeLayout(false);
            this.topmenuP.PerformLayout();
            this.editSubMenuP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftmenuP;
        private System.Windows.Forms.Button helpB;
        private System.Windows.Forms.Label logoL;
        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.Button settingsB;
        private System.Windows.Forms.Button logoutB;
        private System.Windows.Forms.Button testB;
        private System.Windows.Forms.Button questionsB;
        private System.Windows.Forms.Label createL;
        private System.Windows.Forms.Panel createSubMenuP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label create_questionL;
        private System.Windows.Forms.Panel topmenuP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label editL;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel editSubMenuP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTB;
    }
}

