namespace Dino
{
    partial class MainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(97, 218, 251);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.Color.FromArgb(97, 218, 251);
            button1.Location = new System.Drawing.Point(589, 141);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(335, 63);
            button1.TabIndex = 0;
            button1.Text = "Train the model";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(97, 218, 251);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            button2.ForeColor = System.Drawing.Color.FromArgb(97, 218, 251);
            button2.Location = new System.Drawing.Point(589, 247);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(335, 63);
            button2.TabIndex = 1;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(97, 218, 251);
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            button3.ForeColor = System.Drawing.Color.FromArgb(97, 218, 251);
            button3.Location = new System.Drawing.Point(589, 354);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(335, 63);
            button3.TabIndex = 2;
            button3.Text = "Play";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(97, 218, 251);
            label1.Location = new System.Drawing.Point(167, 208);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(210, 133);
            label1.TabIndex = 3;
            label1.Text = "DN";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 44, 52);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "MainMenu";
            Size = new System.Drawing.Size(1000, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}
