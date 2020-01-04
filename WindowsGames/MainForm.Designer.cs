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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tictactoe = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.gamesLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesLayoutPanel
            // 
            this.gamesLayoutPanel.ColumnCount = 3;
            this.gamesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66667F));
            this.gamesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.33333F));
            this.gamesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.gamesLayoutPanel.Controls.Add(this.button6, 2, 1);
            this.gamesLayoutPanel.Controls.Add(this.button5, 1, 1);
            this.gamesLayoutPanel.Controls.Add(this.button4, 0, 1);
            this.gamesLayoutPanel.Controls.Add(this.button3, 2, 0);
            this.gamesLayoutPanel.Controls.Add(this.button2, 1, 0);
            this.gamesLayoutPanel.Controls.Add(this.tictactoe, 0, 0);
            this.gamesLayoutPanel.Controls.Add(this.button7, 0, 2);
            this.gamesLayoutPanel.Controls.Add(this.button9, 2, 2);
            this.gamesLayoutPanel.Controls.Add(this.button8, 1, 2);
            this.gamesLayoutPanel.Location = new System.Drawing.Point(7, 8);
            this.gamesLayoutPanel.Name = "gamesLayoutPanel";
            this.gamesLayoutPanel.RowCount = 3;
            this.gamesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.6124F));
            this.gamesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.3876F));
            this.gamesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.gamesLayoutPanel.Size = new System.Drawing.Size(439, 402);
            this.gamesLayoutPanel.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(303, 276);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 123);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(152, 276);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 123);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 132);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(152, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 132);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 132);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 129);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 129);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
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
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 276);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 123);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tictactoe;
        private System.Windows.Forms.Button button7;
    }
}

