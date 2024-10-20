namespace Snake
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
            this.mainMenu1 = new Snake.MainMenu();
            this.trainingConfigurator1 = new Snake.TrainingConfigurator();
            this.learningProcess1 = new Snake.LearningProcess();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.Location = new System.Drawing.Point(12, 2);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(750, 750);
            this.mainMenu1.TabIndex = 0;
            // 
            // trainingConfigurator1
            // 
            this.trainingConfigurator1.Location = new System.Drawing.Point(12, 2);
            this.trainingConfigurator1.Name = "trainingConfigurator1";
            this.trainingConfigurator1.Size = new System.Drawing.Size(750, 750);
            this.trainingConfigurator1.TabIndex = 1;
            this.trainingConfigurator1.Visible = false;
            // 
            // learningProcess1
            // 
            this.learningProcess1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.learningProcess1.Location = new System.Drawing.Point(81, 67);
            this.learningProcess1.Name = "learningProcess1";
            this.learningProcess1.Size = new System.Drawing.Size(600, 600);
            this.learningProcess1.TabIndex = 2;
            this.learningProcess1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.learningProcess1);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.trainingConfigurator1);
            this.Name = "Form1";
            this.Text = "Snake";
            this.ResumeLayout(false);

        }

        #endregion

        private MainMenu mainMenu1;
        private TrainingConfigurator trainingConfigurator1;
        private LearningProcess learningProcess1;
    }
}

