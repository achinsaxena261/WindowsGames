namespace WindowsGames
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gamesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.snake = new System.Windows.Forms.Button();
            this.checkers = new System.Windows.Forms.Button();
            this.colorMatch = new System.Windows.Forms.Button();
            this.shooter = new System.Windows.Forms.Button();
            this.carRacing = new System.Windows.Forms.Button();
            this.tictactoe = new System.Windows.Forms.Button();
            this.ladder_snake = new System.Windows.Forms.Button();
            this.sudoku = new System.Windows.Forms.Button();
            this.matchPic = new System.Windows.Forms.Button();
            this.gamesLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesLayoutPanel
            // 
            this.gamesLayoutPanel.ColumnCount = 3;
            this.gamesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66667F));
            this.gamesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.33333F));
            this.gamesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.gamesLayoutPanel.Controls.Add(this.snake, 2, 1);
            this.gamesLayoutPanel.Controls.Add(this.checkers, 1, 1);
            this.gamesLayoutPanel.Controls.Add(this.colorMatch, 0, 1);
            this.gamesLayoutPanel.Controls.Add(this.shooter, 2, 0);
            this.gamesLayoutPanel.Controls.Add(this.carRacing, 1, 0);
            this.gamesLayoutPanel.Controls.Add(this.tictactoe, 0, 0);
            this.gamesLayoutPanel.Controls.Add(this.ladder_snake, 0, 2);
            this.gamesLayoutPanel.Controls.Add(this.sudoku, 2, 2);
            this.gamesLayoutPanel.Controls.Add(this.matchPic, 1, 2);
            this.gamesLayoutPanel.Location = new System.Drawing.Point(7, 8);
            this.gamesLayoutPanel.Name = "gamesLayoutPanel";
            this.gamesLayoutPanel.RowCount = 3;
            this.gamesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.6124F));
            this.gamesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.3876F));
            this.gamesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.gamesLayoutPanel.Size = new System.Drawing.Size(439, 402);
            this.gamesLayoutPanel.TabIndex = 0;
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.snake.Enabled = false;
            this.snake.Image = ((System.Drawing.Image)(resources.GetObject("snake.Image")));
            this.snake.Location = new System.Drawing.Point(303, 138);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(133, 132);
            this.snake.TabIndex = 5;
            this.snake.UseVisualStyleBackColor = false;
            // 
            // checkers
            // 
            this.checkers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkers.Enabled = false;
            this.checkers.Image = ((System.Drawing.Image)(resources.GetObject("checkers.Image")));
            this.checkers.Location = new System.Drawing.Point(152, 138);
            this.checkers.Name = "checkers";
            this.checkers.Size = new System.Drawing.Size(145, 132);
            this.checkers.TabIndex = 4;
            this.checkers.UseVisualStyleBackColor = false;
            // 
            // colorMatch
            // 
            this.colorMatch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorMatch.Enabled = false;
            this.colorMatch.Image = ((System.Drawing.Image)(resources.GetObject("colorMatch.Image")));
            this.colorMatch.Location = new System.Drawing.Point(3, 138);
            this.colorMatch.Name = "colorMatch";
            this.colorMatch.Size = new System.Drawing.Size(143, 132);
            this.colorMatch.TabIndex = 3;
            this.colorMatch.UseVisualStyleBackColor = false;
            // 
            // shooter
            // 
            this.shooter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shooter.Enabled = false;
            this.shooter.Image = ((System.Drawing.Image)(resources.GetObject("shooter.Image")));
            this.shooter.Location = new System.Drawing.Point(303, 3);
            this.shooter.Name = "shooter";
            this.shooter.Size = new System.Drawing.Size(133, 129);
            this.shooter.TabIndex = 2;
            this.shooter.UseVisualStyleBackColor = false;
            // 
            // carRacing
            // 
            this.carRacing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carRacing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.carRacing.Enabled = false;
            this.carRacing.Image = ((System.Drawing.Image)(resources.GetObject("carRacing.Image")));
            this.carRacing.Location = new System.Drawing.Point(152, 3);
            this.carRacing.Name = "carRacing";
            this.carRacing.Size = new System.Drawing.Size(145, 129);
            this.carRacing.TabIndex = 1;
            this.carRacing.UseVisualStyleBackColor = false;
            // 
            // tictactoe
            // 
            this.tictactoe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tictactoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tictactoe.BackgroundImage")));
            this.tictactoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tictactoe.Location = new System.Drawing.Point(3, 3);
            this.tictactoe.Name = "tictactoe";
            this.tictactoe.Size = new System.Drawing.Size(143, 129);
            this.tictactoe.TabIndex = 0;
            this.tictactoe.UseVisualStyleBackColor = false;
            this.tictactoe.Click += new System.EventHandler(this.Tictactoe_Click);
            // 
            // ladder_snake
            // 
            this.ladder_snake.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ladder_snake.Enabled = false;
            this.ladder_snake.Image = ((System.Drawing.Image)(resources.GetObject("ladder_snake.Image")));
            this.ladder_snake.Location = new System.Drawing.Point(3, 276);
            this.ladder_snake.Name = "ladder_snake";
            this.ladder_snake.Size = new System.Drawing.Size(143, 123);
            this.ladder_snake.TabIndex = 6;
            this.ladder_snake.UseVisualStyleBackColor = false;
            // 
            // sudoku
            // 
            this.sudoku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sudoku.Enabled = false;
            this.sudoku.Image = ((System.Drawing.Image)(resources.GetObject("sudoku.Image")));
            this.sudoku.Location = new System.Drawing.Point(303, 276);
            this.sudoku.Name = "sudoku";
            this.sudoku.Size = new System.Drawing.Size(133, 123);
            this.sudoku.TabIndex = 8;
            this.sudoku.UseVisualStyleBackColor = false;
            // 
            // matchPic
            // 
            this.matchPic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matchPic.Enabled = false;
            this.matchPic.Image = ((System.Drawing.Image)(resources.GetObject("matchPic.Image")));
            this.matchPic.Location = new System.Drawing.Point(152, 276);
            this.matchPic.Name = "matchPic";
            this.matchPic.Size = new System.Drawing.Size(145, 123);
            this.matchPic.TabIndex = 7;
            this.matchPic.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(453, 419);
            this.Controls.Add(this.gamesLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "All Games";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.gamesLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gamesLayoutPanel;
        private System.Windows.Forms.Button sudoku;
        private System.Windows.Forms.Button matchPic;
        private System.Windows.Forms.Button snake;
        private System.Windows.Forms.Button checkers;
        private System.Windows.Forms.Button colorMatch;
        private System.Windows.Forms.Button shooter;
        private System.Windows.Forms.Button carRacing;
        private System.Windows.Forms.Button tictactoe;
        private System.Windows.Forms.Button ladder_snake;
    }
}

