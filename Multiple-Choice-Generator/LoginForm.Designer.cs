﻿namespace Multiple_Choice_Generator
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginUsernameTextbox = new System.Windows.Forms.TextBox();
            this.loginTitleLabel1 = new System.Windows.Forms.Label();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginUsernameSeperator = new System.Windows.Forms.Label();
            this.loginPasswordSeperator = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.loginConfigButton = new System.Windows.Forms.Button();
            this.loginSignupLabel = new System.Windows.Forms.Label();
            this.loginSignupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 415);
            this.panel2.TabIndex = 1;
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
            this.loginPasswordTextbox.Size = new System.Drawing.Size(251, 24);
            this.loginPasswordTextbox.TabIndex = 4;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}