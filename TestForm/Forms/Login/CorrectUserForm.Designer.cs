
namespace LoginPassword
{
    partial class CorrectUserForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.examStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Myanmar Text", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.welcomeLabel.Location = new System.Drawing.Point(180, 183);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(411, 62);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Добре дошъл, {user}";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkRed;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(568, 363);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(176, 56);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Изход";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // examStartButton
            // 
            this.examStartButton.BackColor = System.Drawing.Color.Gold;
            this.examStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examStartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.examStartButton.Location = new System.Drawing.Point(386, 363);
            this.examStartButton.Name = "examStartButton";
            this.examStartButton.Size = new System.Drawing.Size(176, 56);
            this.examStartButton.TabIndex = 3;
            this.examStartButton.Text = "Започни теста";
            this.examStartButton.UseVisualStyleBackColor = false;
            this.examStartButton.Click += new System.EventHandler(this.examStartButton_Click);
            // 
            // CorrectUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.examStartButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "CorrectUserForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.CorrectUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button examStartButton;
    }
}