using System;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;

namespace WindowsGames.Games
{
    public partial class TicTacToe : Form
    {
        private bool _isCross { get; set; }
        private Symbole firstmove { get; set; }
        private PlayMove[,] moves = new PlayMove[3, 3];
        private bool finished { get; set; }
        private int turns { get; set; }
        private int xscore { get; set; }
        private int oscore { get; set; }
        private SoundPlayer player;
        public TicTacToe()
        {
            InitializeComponent();
            xscore = 0;
            oscore = 0;
            firstmove = Symbole.Circle;
            ResetGame();
            player = new SoundPlayer(Resource.Click);
        }

        public enum Symbole
        {
            Blank,
            Cross,
            Circle,
            Draw
        }

        public class PlayMove
        {
            public Symbole Symbole { get; set; }
            public Tuple<int, int> Position { get; set; }
        }

        public delegate void UserActionDelegate(Symbole symbole);

        private void ResetGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    moves.SetValue(new PlayMove { Symbole = Symbole.Blank, Position = new Tuple<int, int>(i, j) }, i, j);
                }
            }
            firstmove = firstmove == Symbole.Cross ? Symbole.Circle : Symbole.Cross;
            turns = 1;
            cell1.Image = null;
            cell2.Image = null;
            cell3.Image = null;
            cell4.Image = null;
            cell5.Image = null;
            cell6.Image = null;
            cell7.Image = null;
            cell8.Image = null;
            cell9.Image = null;
        }

        private void TicTacToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            new MainForm().Show();
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.Play();
            var clickedCell = sender as PictureBox;
            if (clickedCell.Image == null)
            {
                _isCross = turns == 1 ? (firstmove == Symbole.Cross) : _isCross;
                var image = _isCross ? Resource.cross : Resource.circle;
                clickedCell.Image = image;
                var cellPosition = GetCellPosition(clickedCell.Name);
                var move = (PlayMove)moves.GetValue(cellPosition.Item1, cellPosition.Item2);
                if (move.Symbole == Symbole.Blank)
                {
                    move.Symbole = _isCross ? Symbole.Cross : Symbole.Circle;
                    finished = PlayMoveAction(move, UserAction);
                    _isCross = !_isCross;
                }
                if (turns > 9 && !finished)
                {
                    circleScored.Text = "Score:" + ++oscore;
                    crossScored.Text = "Score:" + ++xscore;
                    UserAction(Symbole.Draw);
                }
            }
        }

        private void UserAction(Symbole symbole)
        {
            string message = string.Format("{0}.", symbole == Symbole.Circle ? "Player O Wins" : symbole == Symbole.Cross ? "Player X Wins" : "Match Drawn");
            string caption = "Would you like to play again?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
                ResetGame();
            else
                this.Close();
        }

        private Tuple<int, int> GetCellPosition(string name)
        {
            if (name == "cell1")
                return new Tuple<int, int>(0, 0);
            else if (name == "cell2")
                return new Tuple<int, int>(0, 1);
            else if (name == "cell3")
                return new Tuple<int, int>(0, 2);
            else if (name == "cell4")
                return new Tuple<int, int>(1, 0);
            else if (name == "cell5")
                return new Tuple<int, int>(1, 1);
            else if (name == "cell6")
                return new Tuple<int, int>(1, 2);
            else if (name == "cell7")
                return new Tuple<int, int>(2, 0);
            else if (name == "cell8")
                return new Tuple<int, int>(2, 1);
            else if (name == "cell9")
                return new Tuple<int, int>(2, 2);
            else
                return null;
        }

        private bool PlayMoveAction(PlayMove move, UserActionDelegate userActionDelegate)
        {
            bool gameover = false;
            moves.SetValue(move, move.Position.Item1, move.Position.Item2);
            switch (CheckState())
            {
                case Symbole.Circle:
                    circleScored.Text = "Score:" + ++oscore;
                    userActionDelegate(Symbole.Circle);
                    gameover = true;
                    break;
                case Symbole.Cross:
                    crossScored.Text = "Score:" + ++xscore;
                    userActionDelegate(Symbole.Cross);
                    gameover = true;
                    break;
                default:
                    gameover = false;
                    turns++;
                    break;
            }
            return gameover;
        }

        private Symbole CheckState()
        {
            for (int i = 0, j = 0; i < 3 && j < 3; i++, j++)
            {
                if (moves[i, 0].Symbole == moves[i, 1].Symbole && moves[i, 1].Symbole == moves[i, 2].Symbole)
                {
                    return moves[i, 0].Symbole;
                }
                if (moves[0, j].Symbole == moves[1, j].Symbole && moves[1, j].Symbole == moves[2, j].Symbole)
                {
                    return moves[0, j].Symbole;
                }
            }
            if (moves[0, 0].Symbole == moves[1, 1].Symbole && moves[1, 1].Symbole == moves[2, 2].Symbole)
            {
                return moves[1, 1].Symbole;
            }
            if (moves[2, 0].Symbole == moves[1, 1].Symbole && moves[1, 1].Symbole == moves[0, 2].Symbole)
            {
                return moves[1, 1].Symbole;
            }
            return Symbole.Blank;
        }

        private void TicTacToe_Activated(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
