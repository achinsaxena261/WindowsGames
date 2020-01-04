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
    }
}
