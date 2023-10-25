
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(189, 85);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(376, 42);
            this.title.TabIndex = 0;
            this.title.Text = "Ти предаде теста си";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(47, 228);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(120, 37);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Точки: ";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gradeLabel.Location = new System.Drawing.Point(47, 287);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(142, 37);
            this.gradeLabel.TabIndex = 2;
            this.gradeLabel.Text = "Оценка: ";
            // 
            // gradeDisplayLabel
            // 
            this.gradeDisplayLabel.AutoSize = true;
            this.gradeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradeDisplayLabel.ForeColor = System.Drawing.Color.Crimson;
            this.gradeDisplayLabel.Location = new System.Drawing.Point(195, 287);
            this.gradeDisplayLabel.Name = "gradeDisplayLabel";
            this.gradeDisplayLabel.Size = new System.Drawing.Size(0, 37);
            this.gradeDisplayLabel.TabIndex = 4;
            // 
            // scoreDisplayLabel
            // 
            this.scoreDisplayLabel.AutoSize = true;
            this.scoreDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreDisplayLabel.ForeColor = System.Drawing.Color.Crimson;
            this.scoreDisplayLabel.Location = new System.Drawing.Point(189, 228);
            this.scoreDisplayLabel.Name = "scoreDisplayLabel";
            this.scoreDisplayLabel.Size = new System.Drawing.Size(0, 37);
            this.scoreDisplayLabel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(268, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "Изход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(738, 491);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}