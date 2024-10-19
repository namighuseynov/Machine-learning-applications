namespace TicTacToe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cell9 = new System.Windows.Forms.Button();
            this.cell8 = new System.Windows.Forms.Button();
            this.cell7 = new System.Windows.Forms.Button();
            this.cell5 = new System.Windows.Forms.Button();
            this.cell4 = new System.Windows.Forms.Button();
            this.cell3 = new System.Windows.Forms.Button();
            this.cell1 = new System.Windows.Forms.Button();
            this.cell2 = new System.Windows.Forms.Button();
            this.cell6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.08537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.91463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.cell9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cell1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cell2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cell6, 2, 1);
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cell9
            // 
            this.cell9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell9.FlatAppearance.BorderSize = 0;
            this.cell9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell9.Location = new System.Drawing.Point(337, 344);
            this.cell9.Name = "cell9";
            this.cell9.Size = new System.Drawing.Size(157, 152);
            this.cell9.TabIndex = 8;
            this.cell9.Tag = "8";
            this.cell9.UseVisualStyleBackColor = true;
            this.cell9.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell8
            // 
            this.cell8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell8.FlatAppearance.BorderSize = 0;
            this.cell8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell8.Location = new System.Drawing.Point(167, 344);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(163, 152);
            this.cell8.TabIndex = 7;
            this.cell8.Tag = "7";
            this.cell8.UseVisualStyleBackColor = true;
            this.cell8.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell7
            // 
            this.cell7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell7.FlatAppearance.BorderSize = 0;
            this.cell7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell7.Location = new System.Drawing.Point(4, 344);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(156, 152);
            this.cell7.TabIndex = 6;
            this.cell7.Tag = "6";
            this.cell7.UseVisualStyleBackColor = true;
            this.cell7.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell5
            // 
            this.cell5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell5.FlatAppearance.BorderSize = 0;
            this.cell5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell5.Location = new System.Drawing.Point(167, 174);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(163, 163);
            this.cell5.TabIndex = 4;
            this.cell5.Tag = "4";
            this.cell5.UseVisualStyleBackColor = true;
            this.cell5.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell4
            // 
            this.cell4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell4.FlatAppearance.BorderSize = 0;
            this.cell4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell4.Location = new System.Drawing.Point(4, 174);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(156, 163);
            this.cell4.TabIndex = 3;
            this.cell4.Tag = "3";
            this.cell4.UseVisualStyleBackColor = true;
            this.cell4.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell3
            // 
            this.cell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell3.FlatAppearance.BorderSize = 0;
            this.cell3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell3.Location = new System.Drawing.Point(337, 4);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(157, 163);
            this.cell3.TabIndex = 2;
            this.cell3.Tag = "2";
            this.cell3.UseVisualStyleBackColor = true;
            this.cell3.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell1
            // 
            this.cell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell1.FlatAppearance.BorderSize = 0;
            this.cell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell1.Location = new System.Drawing.Point(4, 4);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(156, 163);
            this.cell1.TabIndex = 0;
            this.cell1.Tag = "0";
            this.cell1.UseVisualStyleBackColor = true;
            this.cell1.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell2
            // 
            this.cell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell2.FlatAppearance.BorderSize = 0;
            this.cell2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell2.Location = new System.Drawing.Point(167, 4);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(163, 163);
            this.cell2.TabIndex = 1;
            this.cell2.Tag = "1";
            this.cell2.UseVisualStyleBackColor = true;
            this.cell2.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // cell6
            // 
            this.cell6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell6.FlatAppearance.BorderSize = 0;
            this.cell6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell6.Location = new System.Drawing.Point(337, 174);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(157, 163);
            this.cell6.TabIndex = 5;
            this.cell6.Tag = "5";
            this.cell6.UseVisualStyleBackColor = true;
            this.cell6.Click += new System.EventHandler(this.SelectedCellHandler);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(260, 569);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 49);
            this.button9.TabIndex = 1;
            this.button9.Text = "Start";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.StartGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Episode: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cell1;
        private System.Windows.Forms.Button cell9;
        private System.Windows.Forms.Button cell8;
        private System.Windows.Forms.Button cell7;
        private System.Windows.Forms.Button cell6;
        private System.Windows.Forms.Button cell5;
        private System.Windows.Forms.Button cell4;
        private System.Windows.Forms.Button cell3;
        private System.Windows.Forms.Button cell2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
    }
}

