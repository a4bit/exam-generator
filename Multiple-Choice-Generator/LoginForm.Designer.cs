namespace Multiple_Choice_Generator
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loginSignupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginSignupLabel = new System.Windows.Forms.Label();
            this.loginConfigButton = new System.Windows.Forms.Button();
            this.loginPasswordSeperator = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.loginUsernameSeperator = new System.Windows.Forms.Label();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginTitleLabel1 = new System.Windows.Forms.Label();
            this.loginUsernameTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.loginSignupLinkLabel);
            this.panel1.Controls.Add(this.loginSignupLabel);
            this.panel1.Controls.Add(this.loginConfigButton);
            this.panel1.Controls.Add(this.loginPasswordSeperator);
            this.panel1.Controls.Add(this.loginPasswordLabel);
            this.panel1.Controls.Add(this.loginPasswordTextbox);
            this.panel1.Controls.Add(this.loginUsernameSeperator);
            this.panel1.Controls.Add(this.loginUsernameLabel);
            this.panel1.Controls.Add(this.loginTitleLabel1);
            this.panel1.Controls.Add(this.loginUsernameTextbox);
            this.panel1.Location = new System.Drawing.Point(340, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 418);
            this.panel1.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(8, 367);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(404, 23);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginSignupLinkLabel
            // 
            this.loginSignupLinkLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.loginSignupLinkLabel.AutoSize = true;
            this.loginSignupLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.loginSignupLinkLabel.LinkColor = System.Drawing.Color.Cyan;
            this.loginSignupLinkLabel.Location = new System.Drawing.Point(277, 331);
            this.loginSignupLinkLabel.Name = "loginSignupLinkLabel";
            this.loginSignupLinkLabel.Size = new System.Drawing.Size(60, 15);
            this.loginSignupLinkLabel.TabIndex = 9;
            this.loginSignupLinkLabel.TabStop = true;
            this.loginSignupLinkLabel.Text = "εγγραφή.";
            this.loginSignupLinkLabel.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.loginSignupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginSignupLinkLabel_LinkClicked);
            // 
            // loginSignupLabel
            // 
            this.loginSignupLabel.AutoSize = true;
            this.loginSignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginSignupLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginSignupLabel.Location = new System.Drawing.Point(78, 331);
            this.loginSignupLabel.Name = "loginSignupLabel";
            this.loginSignupLabel.Size = new System.Drawing.Size(203, 15);
            this.loginSignupLabel.TabIndex = 8;
            this.loginSignupLabel.Text = "Αν δεν έχετε λογαριασμό κάντε τώρα";
            // 
            // loginConfigButton
            // 
            this.loginConfigButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginConfigButton.FlatAppearance.BorderSize = 0;
            this.loginConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginConfigButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginConfigButton.ForeColor = System.Drawing.Color.White;
            this.loginConfigButton.Location = new System.Drawing.Point(81, 266);
            this.loginConfigButton.Name = "loginConfigButton";
            this.loginConfigButton.Size = new System.Drawing.Size(251, 47);
            this.loginConfigButton.TabIndex = 7;
            this.loginConfigButton.Text = "Σύνδεση";
            this.loginConfigButton.UseVisualStyleBackColor = false;
            this.loginConfigButton.Click += new System.EventHandler(this.loginConfigButton_Click);
            // 
            // loginPasswordSeperator
            // 
            this.loginPasswordSeperator.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginPasswordSeperator.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginPasswordSeperator.Location = new System.Drawing.Point(81, 242);
            this.loginPasswordSeperator.Name = "loginPasswordSeperator";
            this.loginPasswordSeperator.Size = new System.Drawing.Size(251, 1);
            this.loginPasswordSeperator.TabIndex = 6;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginPasswordLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginPasswordLabel.Location = new System.Drawing.Point(78, 196);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(61, 16);
            this.loginPasswordLabel.TabIndex = 5;
            this.loginPasswordLabel.Text = "Κωδικός";
            // 
            // loginPasswordTextbox
            // 
            this.loginPasswordTextbox.BackColor = System.Drawing.Color.White;
            this.loginPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPasswordTextbox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginPasswordTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.loginPasswordTextbox.Location = new System.Drawing.Point(81, 215);
            this.loginPasswordTextbox.Name = "loginPasswordTextbox";
            this.loginPasswordTextbox.PasswordChar = '*';
            this.loginPasswordTextbox.Size = new System.Drawing.Size(251, 24);
            this.loginPasswordTextbox.TabIndex = 4;
            // 
            // loginUsernameSeperator
            // 
            this.loginUsernameSeperator.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginUsernameSeperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginUsernameSeperator.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginUsernameSeperator.Location = new System.Drawing.Point(81, 183);
            this.loginUsernameSeperator.Name = "loginUsernameSeperator";
            this.loginUsernameSeperator.Size = new System.Drawing.Size(251, 1);
            this.loginUsernameSeperator.TabIndex = 3;
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginUsernameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginUsernameLabel.Location = new System.Drawing.Point(78, 137);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(103, 16);
            this.loginUsernameLabel.TabIndex = 2;
            this.loginUsernameLabel.Text = "Όνομα χρήστη";
            // 
            // loginTitleLabel1
            // 
            this.loginTitleLabel1.AutoSize = true;
            this.loginTitleLabel1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitleLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginTitleLabel1.Location = new System.Drawing.Point(135, 74);
            this.loginTitleLabel1.Name = "loginTitleLabel1";
            this.loginTitleLabel1.Size = new System.Drawing.Size(111, 25);
            this.loginTitleLabel1.TabIndex = 1;
            this.loginTitleLabel1.Text = "Σύνδεση";
            // 
            // loginUsernameTextbox
            // 
            this.loginUsernameTextbox.BackColor = System.Drawing.Color.White;
            this.loginUsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUsernameTextbox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginUsernameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.loginUsernameTextbox.Location = new System.Drawing.Point(81, 156);
            this.loginUsernameTextbox.Name = "loginUsernameTextbox";
            this.loginUsernameTextbox.Size = new System.Drawing.Size(251, 24);
            this.loginUsernameTextbox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.titleL);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 415);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Multiple_Choice_Generator.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleL
            // 
            this.titleL.BackColor = System.Drawing.Color.Transparent;
            this.titleL.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleL.ForeColor = System.Drawing.Color.White;
            this.titleL.Location = new System.Drawing.Point(34, 215);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(275, 109);
            this.titleL.TabIndex = 13;
            this.titleL.Text = "Multiple Choice\r\nGenerator";
            this.titleL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.Text = "Multiple Choise Exam Generator - Σύνδεση";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Label loginTitleLabel1;
        private System.Windows.Forms.TextBox loginUsernameTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loginUsernameSeperator;
        private System.Windows.Forms.Label loginSignupLabel;
        private System.Windows.Forms.Button loginConfigButton;
        private System.Windows.Forms.Label loginPasswordSeperator;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginPasswordTextbox;
        private System.Windows.Forms.LinkLabel loginSignupLinkLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleL;
    }
}