
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
            this.startTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Myanmar Text", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.welcomeLabel.Location = new System.Drawing.Point(168, 181);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(306, 62);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Добре дошъл,";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkRed;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(585, 349);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(176, 56);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Изход";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // startTest
            // 
            this.startTest.BackColor = System.Drawing.Color.OrangeRed;
            this.startTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startTest.Location = new System.Drawing.Point(403, 349);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(176, 56);
            this.startTest.TabIndex = 0;
            this.startTest.Text = "Започни теста";
            this.startTest.UseVisualStyleBackColor = false;
            this.startTest.Click += new System.EventHandler(this.startTest_Click);
            // 
            // CorrectUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startTest);
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
        private System.Windows.Forms.Button startTest;
    }
}