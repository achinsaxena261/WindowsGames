namespace WindowsGames.Games
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.TicTacToePanel = new System.Windows.Forms.TableLayoutPanel();
            this.cell9 = new System.Windows.Forms.PictureBox();
            this.cell8 = new System.Windows.Forms.PictureBox();
            this.cell7 = new System.Windows.Forms.PictureBox();
            this.cell6 = new System.Windows.Forms.PictureBox();
            this.cell5 = new System.Windows.Forms.PictureBox();
            this.cell4 = new System.Windows.Forms.PictureBox();
            this.cell3 = new System.Windows.Forms.PictureBox();
            this.cell2 = new System.Windows.Forms.PictureBox();
            this.cell1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.crossScored = new System.Windows.Forms.Label();
            this.circleScored = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TicTacToePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cell9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TicTacToePanel
            // 
            this.TicTacToePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.TicTacToePanel.ColumnCount = 3;
            this.TicTacToePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TicTacToePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TicTacToePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.TicTacToePanel.Controls.Add(this.cell9, 2, 2);
            this.TicTacToePanel.Controls.Add(this.cell8, 1, 2);
            this.TicTacToePanel.Controls.Add(this.cell7, 0, 2);
            this.TicTacToePanel.Controls.Add(this.cell6, 2, 1);
            this.TicTacToePanel.Controls.Add(this.cell5, 1, 1);
            this.TicTacToePanel.Controls.Add(this.cell4, 0, 1);
            this.TicTacToePanel.Controls.Add(this.cell3, 2, 0);
            this.TicTacToePanel.Controls.Add(this.cell2, 1, 0);
            this.TicTacToePanel.Controls.Add(this.cell1, 0, 0);
            this.TicTacToePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicTacToePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TicTacToePanel.Location = new System.Drawing.Point(87, 89);
            this.TicTacToePanel.Name = "TicTacToePanel";
            this.TicTacToePanel.RowCount = 3;
            this.TicTacToePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.TicTacToePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.TicTacToePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.TicTacToePanel.Size = new System.Drawing.Size(298, 256);
            this.TicTacToePanel.TabIndex = 0;
            // 
            // cell9
            // 
            this.cell9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell9.Location = new System.Drawing.Point(198, 174);
            this.cell9.Name = "cell9";
            this.cell9.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell9.Size = new System.Drawing.Size(94, 76);
            this.cell9.TabIndex = 8;
            this.cell9.TabStop = false;
            this.cell9.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell8
            // 
            this.cell8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell8.Location = new System.Drawing.Point(102, 174);
            this.cell8.Name = "cell8";
            this.cell8.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell8.Size = new System.Drawing.Size(87, 76);
            this.cell8.TabIndex = 7;
            this.cell8.TabStop = false;
            this.cell8.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell7
            // 
            this.cell7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell7.Location = new System.Drawing.Point(6, 174);
            this.cell7.Name = "cell7";
            this.cell7.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell7.Size = new System.Drawing.Size(87, 76);
            this.cell7.TabIndex = 6;
            this.cell7.TabStop = false;
            this.cell7.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell6
            // 
            this.cell6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell6.Location = new System.Drawing.Point(198, 84);
            this.cell6.Name = "cell6";
            this.cell6.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell6.Size = new System.Drawing.Size(94, 81);
            this.cell6.TabIndex = 5;
            this.cell6.TabStop = false;
            this.cell6.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell5
            // 
            this.cell5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell5.Location = new System.Drawing.Point(102, 84);
            this.cell5.Name = "cell5";
            this.cell5.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell5.Size = new System.Drawing.Size(87, 81);
            this.cell5.TabIndex = 4;
            this.cell5.TabStop = false;
            this.cell5.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell4
            // 
            this.cell4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell4.Location = new System.Drawing.Point(6, 84);
            this.cell4.Name = "cell4";
            this.cell4.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell4.Size = new System.Drawing.Size(87, 81);
            this.cell4.TabIndex = 3;
            this.cell4.TabStop = false;
            this.cell4.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell3
            // 
            this.cell3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell3.Location = new System.Drawing.Point(198, 6);
            this.cell3.Name = "cell3";
            this.cell3.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell3.Size = new System.Drawing.Size(94, 69);
            this.cell3.TabIndex = 2;
            this.cell3.TabStop = false;
            this.cell3.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell2
            // 
            this.cell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell2.Location = new System.Drawing.Point(102, 6);
            this.cell2.Name = "cell2";
            this.cell2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell2.Size = new System.Drawing.Size(87, 69);
            this.cell2.TabIndex = 1;
            this.cell2.TabStop = false;
            this.cell2.Click += new System.EventHandler(this.Cell_Click);
            // 
            // cell1
            // 
            this.cell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell1.Location = new System.Drawing.Point(6, 6);
            this.cell1.Name = "cell1";
            this.cell1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cell1.Size = new System.Drawing.Size(87, 69);
            this.cell1.TabIndex = 0;
            this.cell1.TabStop = false;
            this.cell1.Click += new System.EventHandler(this.Cell_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // crossScored
            // 
            this.crossScored.AutoSize = true;
            this.crossScored.Location = new System.Drawing.Point(144, 383);
            this.crossScored.Name = "crossScored";
            this.crossScored.Size = new System.Drawing.Size(47, 13);
            this.crossScored.TabIndex = 3;
            this.crossScored.Text = "Score: 0";
            // 
            // circleScored
            // 
            this.circleScored.AutoSize = true;
            this.circleScored.Location = new System.Drawing.Point(341, 383);
            this.circleScored.Name = "circleScored";
            this.circleScored.Size = new System.Drawing.Size(47, 13);
            this.circleScored.TabIndex = 4;
            this.circleScored.Text = "Score: 0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(129, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 66);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.circleScored);
            this.Controls.Add(this.crossScored);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TicTacToePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Activated += new System.EventHandler(this.TicTacToe_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicTacToe_FormClosing);
            this.TicTacToePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cell9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TicTacToePanel;
        private System.Windows.Forms.PictureBox cell9;
        private System.Windows.Forms.PictureBox cell8;
        private System.Windows.Forms.PictureBox cell7;
        private System.Windows.Forms.PictureBox cell6;
        private System.Windows.Forms.PictureBox cell5;
        private System.Windows.Forms.PictureBox cell4;
        private System.Windows.Forms.PictureBox cell3;
        private System.Windows.Forms.PictureBox cell2;
        private System.Windows.Forms.PictureBox cell1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label crossScored;
        private System.Windows.Forms.Label circleScored;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}