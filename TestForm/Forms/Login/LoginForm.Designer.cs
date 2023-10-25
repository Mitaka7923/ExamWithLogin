
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.introLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInput.Location = new System.Drawing.Point(340, 241);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(293, 49);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnEnterKeyPress);
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Myanmar Text", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.introLabel.Location = new System.Drawing.Point(249, 64);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(318, 56);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = "ДОБРЕ ДОШЛИ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordLabel.Location = new System.Drawing.Point(134, 244);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(200, 42);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Парола    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(134, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameBox.Location = new System.Drawing.Point(340, 186);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(293, 49);
            this.usernameBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Honeydew;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(340, 345);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(293, 56);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вхход";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordInfo
            // 
            this.passwordInfo.AutoSize = true;
            this.passwordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordInfo.Location = new System.Drawing.Point(36, 347);
            this.passwordInfo.Name = "passwordInfo";
            this.passwordInfo.Size = new System.Drawing.Size(298, 54);
            this.passwordInfo.TabIndex = 6;
            this.passwordInfo.Text = "Паролата: трябва да съдържа поне едно \r\nчисло, една главна буква, \r\nда бъде 8 сим" +
    "вола\r\n";
            this.passwordInfo.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private void OnEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.loginButton.Select();
                this.loginButton.PerformClick();
            }
        }

        #endregion

        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordInfo;
    }
}

