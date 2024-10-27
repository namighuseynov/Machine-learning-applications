namespace Dino
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
            mainMenu1 = new MainMenu();
            SuspendLayout();
            // 
            // mainMenu1
            // 
            mainMenu1.BackColor = System.Drawing.Color.FromArgb(40, 44, 52);
            mainMenu1.Location = new System.Drawing.Point(-2, 0);
            mainMenu1.Margin = new System.Windows.Forms.Padding(0);
            mainMenu1.Name = "mainMenu1";
            mainMenu1.Size = new System.Drawing.Size(1069, 606);
            mainMenu1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 44, 52);
            ClientSize = new System.Drawing.Size(1062, 603);
            Controls.Add(mainMenu1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Dino";
            ResumeLayout(false);
        }

        #endregion

        private MainMenu mainMenu1;
    }
}

