using System;
using System.Windows.Forms;
using WindowsGames.Games;

namespace WindowsGames
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Tictactoe_Click(object sender, EventArgs e)
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;

            toolTip.SetToolTip(tictactoe, "Tic Tac Toe");
            toolTip.SetToolTip(carRacing, "Car Racing");
            toolTip.SetToolTip(shooter, "Shooting");
            toolTip.SetToolTip(colorMatch, "Card Color Match");
            toolTip.SetToolTip(checkers, "Checkers");
            toolTip.SetToolTip(snake, "Snake");
            toolTip.SetToolTip(ladder_snake, "Snakes and Ladders");
            toolTip.SetToolTip(matchPic, "Match Picture");
            toolTip.SetToolTip(sudoku, "Sudoku");
        }
    }
}
