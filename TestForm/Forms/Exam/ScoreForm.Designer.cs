
namespace TestForm
{
    partial class ScoreForm
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
            this.title = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeDisplayLabel = new System.Windows.Forms.Label();
            this.scoreDisplayLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(47, 100);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(420, 39);
            this.title.TabIndex = 0;
            this.title.Text = "{user} предаде теста си";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(48, 246);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(111, 33);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Точки: ";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gradeLabel.Location = new System.Drawing.Point(48, 290);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(134, 33);
            this.gradeLabel.TabIndex = 2;
            this.gradeLabel.Text = "Оценка: ";
            // 
            // gradeDisplayLabel
            // 
            this.gradeDisplayLabel.AutoSize = true;
            this.gradeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradeDisplayLabel.ForeColor = System.Drawing.Color.Crimson;
            this.gradeDisplayLabel.Location = new System.Drawing.Point(196, 290);
            this.gradeDisplayLabel.Name = "gradeDisplayLabel";
            this.gradeDisplayLabel.Size = new System.Drawing.Size(0, 33);
            this.gradeDisplayLabel.TabIndex = 4;
            // 
            // scoreDisplayLabel
            // 
            this.scoreDisplayLabel.AutoSize = true;
            this.scoreDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreDisplayLabel.ForeColor = System.Drawing.Color.Crimson;
            this.scoreDisplayLabel.Location = new System.Drawing.Point(190, 246);
            this.scoreDisplayLabel.Name = "scoreDisplayLabel";
            this.scoreDisplayLabel.Size = new System.Drawing.Size(0, 33);
            this.scoreDisplayLabel.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkRed;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(202, 394);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(201, 56);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Изход";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(601, 491);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.scoreDisplayLabel);
            this.Controls.Add(this.gradeDisplayLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.title);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label gradeDisplayLabel;
        private System.Windows.Forms.Label scoreDisplayLabel;
        private System.Windows.Forms.Button closeButton;
    }
}