namespace TicTacToe
{
    partial class GameMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cell1 = new System.Windows.Forms.Button();
            this.cell2 = new System.Windows.Forms.Button();
            this.cell3 = new System.Windows.Forms.Button();
            this.cell4 = new System.Windows.Forms.Button();
            this.cell5 = new System.Windows.Forms.Button();
            this.cell6 = new System.Windows.Forms.Button();
            this.cell7 = new System.Windows.Forms.Button();
            this.cell8 = new System.Windows.Forms.Button();
            this.cell9 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.70588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.29412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.cell9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cell2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cell1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(142, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5549F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.4451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cell1
            // 
            this.cell1.BackColor = System.Drawing.Color.Transparent;
            this.cell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell1.FlatAppearance.BorderSize = 0;
            this.cell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell1.Location = new System.Drawing.Point(4, 4);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(158, 157);
            this.cell1.TabIndex = 0;
            this.cell1.Tag = "0";
            this.cell1.UseVisualStyleBackColor = false;
            this.cell1.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell2
            // 
            this.cell2.BackColor = System.Drawing.Color.Transparent;
            this.cell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell2.FlatAppearance.BorderSize = 0;
            this.cell2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell2.Location = new System.Drawing.Point(169, 4);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(160, 155);
            this.cell2.TabIndex = 1;
            this.cell2.Tag = "1";
            this.cell2.UseVisualStyleBackColor = false;
            this.cell2.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell3
            // 
            this.cell3.BackColor = System.Drawing.Color.Transparent;
            this.cell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell3.FlatAppearance.BorderSize = 0;
            this.cell3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell3.Location = new System.Drawing.Point(336, 4);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(160, 157);
            this.cell3.TabIndex = 2;
            this.cell3.Tag = "2";
            this.cell3.UseVisualStyleBackColor = false;
            this.cell3.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell4
            // 
            this.cell4.BackColor = System.Drawing.Color.Transparent;
            this.cell4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell4.FlatAppearance.BorderSize = 0;
            this.cell4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell4.Location = new System.Drawing.Point(4, 168);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(158, 160);
            this.cell4.TabIndex = 3;
            this.cell4.Tag = "3";
            this.cell4.UseVisualStyleBackColor = false;
            this.cell4.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell5
            // 
            this.cell5.BackColor = System.Drawing.Color.Transparent;
            this.cell5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell5.FlatAppearance.BorderSize = 0;
            this.cell5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell5.Location = new System.Drawing.Point(169, 168);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(160, 160);
            this.cell5.TabIndex = 4;
            this.cell5.Tag = "4";
            this.cell5.UseVisualStyleBackColor = false;
            this.cell5.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell6
            // 
            this.cell6.BackColor = System.Drawing.Color.Transparent;
            this.cell6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell6.FlatAppearance.BorderSize = 0;
            this.cell6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell6.Location = new System.Drawing.Point(336, 168);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(160, 160);
            this.cell6.TabIndex = 5;
            this.cell6.Tag = "5";
            this.cell6.UseVisualStyleBackColor = false;
            this.cell6.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell7
            // 
            this.cell7.BackColor = System.Drawing.Color.Transparent;
            this.cell7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell7.FlatAppearance.BorderSize = 0;
            this.cell7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell7.Location = new System.Drawing.Point(4, 335);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(158, 161);
            this.cell7.TabIndex = 6;
            this.cell7.Tag = "6";
            this.cell7.UseVisualStyleBackColor = false;
            this.cell7.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell8
            // 
            this.cell8.BackColor = System.Drawing.Color.Transparent;
            this.cell8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell8.FlatAppearance.BorderSize = 0;
            this.cell8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell8.Location = new System.Drawing.Point(169, 335);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(160, 161);
            this.cell8.TabIndex = 7;
            this.cell8.Tag = "7";
            this.cell8.UseVisualStyleBackColor = false;
            this.cell8.Click += new System.EventHandler(this.SelectCell);
            // 
            // cell9
            // 
            this.cell9.BackColor = System.Drawing.Color.Transparent;
            this.cell9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cell9.FlatAppearance.BorderSize = 0;
            this.cell9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cell9.Location = new System.Drawing.Point(336, 335);
            this.cell9.Name = "cell9";
            this.cell9.Size = new System.Drawing.Size(160, 161);
            this.cell9.TabIndex = 8;
            this.cell9.Tag = "8";
            this.cell9.UseVisualStyleBackColor = false;
            this.cell9.Click += new System.EventHandler(this.SelectCell);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameMenu";
            this.Size = new System.Drawing.Size(800, 700);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cell9;
        private System.Windows.Forms.Button cell8;
        private System.Windows.Forms.Button cell7;
        private System.Windows.Forms.Button cell6;
        private System.Windows.Forms.Button cell5;
        private System.Windows.Forms.Button cell4;
        private System.Windows.Forms.Button cell3;
        private System.Windows.Forms.Button cell2;
        private System.Windows.Forms.Button cell1;
    }
}
