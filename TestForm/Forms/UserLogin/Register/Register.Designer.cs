
namespace TestForm.Forms.UserLogin.Register
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.introLabel = new System.Windows.Forms.Label();
            this.seePasswordButton = new System.Windows.Forms.Button();
            this.passwordInfo = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Myanmar Text", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.introLabel.Location = new System.Drawing.Point(262, 67);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(277, 62);
            this.introLabel.TabIndex = 2;
            this.introLabel.Text = "Регистрация";
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
            this.seePasswordButton.Location = new System.Drawing.Point(633, 234);
            this.seePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.seePasswordButton.Name = "seePasswordButton";
            this.seePasswordButton.Size = new System.Drawing.Size(61, 44);
            this.seePasswordButton.TabIndex = 9;
            this.seePasswordButton.UseVisualStyleBackColor = false;
            // 
            // passwordInfo
            // 
            this.passwordInfo.AutoSize = true;
            this.passwordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordInfo.Location = new System.Drawing.Point(50, 329);
            this.passwordInfo.Name = "passwordInfo";
            this.passwordInfo.Size = new System.Drawing.Size(298, 54);
            this.passwordInfo.TabIndex = 13;
            this.passwordInfo.Text = "Паролата: трябва да съдържа поне едно \r\n                   число, една главна бук" +
    "ва\r\n                   повече от 8 символа.";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerButton.Location = new System.Drawing.Point(401, 329);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(293, 56);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usernameLabel.Location = new System.Drawing.Point(12, 179);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(383, 42);
            this.usernameLabel.TabIndex = 12;
            this.usernameLabel.Text = "Потребителско име: ";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameInput.Location = new System.Drawing.Point(401, 177);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(293, 44);
            this.usernameInput.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordLabel.Location = new System.Drawing.Point(225, 231);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(170, 42);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Парола: ";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInput.Location = new System.Drawing.Point(401, 234);
            this.passwordInput.MaxLength = 20;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(239, 44);
            this.passwordInput.TabIndex = 8;
            this.passwordInput.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seePasswordButton);
            this.Controls.Add(this.passwordInfo);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.introLabel);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button seePasswordButton;
        internal System.Windows.Forms.Label passwordInfo;
        internal System.Windows.Forms.Button registerButton;
        internal System.Windows.Forms.Label usernameLabel;
        internal System.Windows.Forms.TextBox usernameInput;
        internal System.Windows.Forms.Label passwordLabel;
        internal System.Windows.Forms.TextBox passwordInput;
    }
}