﻿
using System;
using System.Windows.Forms;

namespace LoginPassword
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

        internal void loginButton_Click(object sender, EventArgs e)
        {
            clickMethods.LoginButton_Click(sender, e);
        }

        internal void eyePassword_Click(object sender, EventArgs e)
        {

        }

        internal void keyPress_Enter(object sender, KeyPressEventArgs e)
        {
            clickMethods.passwordInput_Click(sender, e);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        internal void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.introLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordInfo = new System.Windows.Forms.Label();
            this.seePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInput.Location = new System.Drawing.Point(340, 245);
            this.passwordInput.MaxLength = 20;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(239, 44);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_Enter);
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Myanmar Text", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.introLabel.Location = new System.Drawing.Point(249, 77);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(294, 62);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = "Добре дошли";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordLabel.Location = new System.Drawing.Point(164, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(170, 42);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Парола: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(88, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Потребител: ";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameBox.Location = new System.Drawing.Point(340, 190);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(293, 44);
            this.usernameBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(340, 325);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(293, 56);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordInfo
            // 
            this.passwordInfo.AutoSize = true;
            this.passwordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordInfo.Location = new System.Drawing.Point(12, 327);
            this.passwordInfo.Name = "passwordInfo";
            this.passwordInfo.Size = new System.Drawing.Size(298, 54);
            this.passwordInfo.TabIndex = 6;
            this.passwordInfo.Text = "Паролата: трябва да съдържа поне едно \r\n                   число, една главна бук" +
    "ва\r\n                   повече от 8 символа.";
            this.passwordInfo.Visible = false;
            // 
            // seePasswordButton
            // 
            this.seePasswordButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seePasswordButton.CausesValidation = false;
            this.seePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePasswordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.seePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.seePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePasswordButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seePasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("seePasswordButton.Image")));
            this.seePasswordButton.Location = new System.Drawing.Point(572, 245);
            this.seePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.seePasswordButton.Name = "seePasswordButton";
            this.seePasswordButton.Size = new System.Drawing.Size(61, 44);
            this.seePasswordButton.TabIndex = 2;
            this.seePasswordButton.UseVisualStyleBackColor = false;
            this.seePasswordButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seePasswordButton_MouseDown);
            this.seePasswordButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seePasswordButton_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seePasswordButton);
            this.Controls.Add(this.passwordInfo);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.passwordInput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox passwordInput;
        internal System.Windows.Forms.Label introLabel;
        internal System.Windows.Forms.Label passwordLabel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox usernameBox;
        internal System.Windows.Forms.Button loginButton;
        internal System.Windows.Forms.Label passwordInfo;
        private Button seePasswordButton;
    }
}

