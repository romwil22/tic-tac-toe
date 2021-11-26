using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_tictactoe
{
    public partial class tictactoe : Form
    {
        Boolean checker;
        int scorePoint;

        void enableFalse()
        {
            box1.Enabled = false;
            box2.Enabled = false;
            box3.Enabled = false;
            box4.Enabled = false;
            box5.Enabled = false;
            box6.Enabled = false;
            box7.Enabled = false;
            box8.Enabled = false;
            box9.Enabled = false;
        }

        void playersScore()
        {
            //player 1, X combination win
            if (box1.Text == "X" && box2.Text == "X" && box3.Text == "X") // row 1 X win
            {
                box1.BackColor = Color.Green;
                box2.BackColor = Color.Green;
                box3.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();
                
            }
            if (box4.Text == "X" && box5.Text == "X" && box6.Text == "X") // row 2 X win
            {
                box4.BackColor = Color.Green;
                box5.BackColor = Color.Green;
                box6.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box7.Text == "X" && box8.Text == "X" && box9.Text == "X") // row 3 X win
            {
                box7.BackColor = Color.Green;
                box8.BackColor = Color.Green;
                box9.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box1.Text == "X" && box4.Text == "X" && box7.Text == "X") // column 1 X win
            {
                box1.BackColor = Color.Green;
                box4.BackColor = Color.Green;
                box7.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box2.Text == "X" && box5.Text == "X" && box8.Text == "X") // column 2 X win
            {
                box1.BackColor = Color.Green;
                box2.BackColor = Color.Green;
                box3.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box3.Text == "X" && box6.Text == "X" && box9.Text == "X") // column 3 X win
            {
                box3.BackColor = Color.Green;
                box6.BackColor = Color.Green;
                box9.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box1.Text == "X" && box5.Text == "X" && box9.Text == "X") // column diagonal right X win
            {
                box1.BackColor = Color.Green;
                box5.BackColor = Color.Green;
                box9.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box3.Text == "X" && box5.Text == "X" && box7.Text == "X") // column diagonal left X win
            {
                box3.BackColor = Color.Green;
                box5.BackColor = Color.Green;
                box7.BackColor = Color.Green;

                MessageBox.Show("Player 1 win the match!");

                scorePoint = int.Parse(player1Score.Text);
                player1Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }

            //player 2, O combination win
            if (box1.Text == "O" && box2.Text == "O" && box3.Text == "O") // row 1 O win
            {
                box1.BackColor = Color.Green;
                box2.BackColor = Color.Green;
                box3.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box4.Text == "O" && box5.Text == "O" && box6.Text == "O") // row 2 O win
            {
                box4.BackColor = Color.Green;
                box5.BackColor = Color.Green;
                box6.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box7.Text == "O" && box8.Text == "O" && box9.Text == "O") // row 3 O win
            {
                box7.BackColor = Color.Green;
                box8.BackColor = Color.Green;
                box9.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box1.Text == "O" && box4.Text == "O" && box7.Text == "O") // column 1 O win
            {
                box1.BackColor = Color.Green;
                box4.BackColor = Color.Green;
                box7.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box2.Text == "O" && box5.Text == "O" && box8.Text == "O") // column 2 O win
            {
                box1.BackColor = Color.Green;
                box2.BackColor = Color.Green;
                box3.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box3.Text == "O" && box6.Text == "O" && box9.Text == "O") // column 3 O win
            {
                box3.BackColor = Color.Green;
                box6.BackColor = Color.Green;
                box9.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box1.Text == "O" && box5.Text == "O" && box9.Text == "O") // column diagonal right O win
            {
                box1.BackColor = Color.Green;
                box5.BackColor = Color.Green;
                box9.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }
            if (box3.Text == "O" && box5.Text == "O" && box7.Text == "O") // column diagonal left O win
            {
                box3.BackColor = Color.Green;
                box5.BackColor = Color.Green;
                box7.BackColor = Color.Green;

                MessageBox.Show("Player 2 win the match!");

                scorePoint = int.Parse(player2Score.Text);
                player2Score.Text = Convert.ToString(scorePoint + 1);

                enableFalse();

            }

        }
        public tictactoe()
        {
            InitializeComponent();
        }


        private void tictactoe_Load(object sender, EventArgs e)
        {

        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box1.Text = "X";
                checker = true;
            }
            else
            {
                box1.Text = "O";
                checker = false;
            }
            
            playersScore();

            box1.Enabled = false;
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box2.Text = "X";
                checker = true;
            }
            else
            {
                box2.Text = "O";
                checker = false;
            }

            playersScore();

            box2.Enabled = false;
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box3.Text = "X";
                checker = true;
            }
            else
            {
                box3.Text = "O";
                checker = false;
            }

            playersScore();

            box3.Enabled = false;
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box4.Text = "X";
                checker = true;
            }
            else
            {
                box4.Text = "O";
                checker = false;
            }

            playersScore();

            box4.Enabled = false;
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box5.Text = "X";
                checker = true;
            }
            else
            {
                box5.Text = "O";
                checker = false;
            }

            playersScore();

            box5.Enabled = false;
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box6.Text = "X";
                checker = true;
            }
            else
            {
                box6.Text = "O";
                checker = false;
            }

            playersScore();

            box6.Enabled = false;
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box7.Text = "X";
                checker = true;
            }
            else
            {
                box7.Text = "O";
                checker = false;
            }

            playersScore();

            box7.Enabled = false;
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box8.Text = "X";
                checker = true;
            }
            else
            {
                box8.Text = "O";
                checker = false;
            }

            playersScore();

            box8.Enabled = false;
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                box9.Text = "X";
                checker = true;
            }
            else
            {
                box9.Text = "O";
                checker = false;
            }

            playersScore();

            box9.Enabled = false;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            box1.Enabled = true;
            box2.Enabled = true;
            box3.Enabled = true;
            box4.Enabled = true;
            box5.Enabled = true;
            box6.Enabled = true;
            box7.Enabled = true;
            box8.Enabled = true;
            box9.Enabled = true;

            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
            box6.Text = "";
            box7.Text = "";
            box8.Text = "";
            box9.Text = "";

            player1Score.Text = "0";
            player2Score.Text = "0";

            box1.BackColor = Color.LightGray;
            box2.BackColor = Color.LightGray;
            box3.BackColor = Color.LightGray;
            box4.BackColor = Color.LightGray;
            box5.BackColor = Color.LightGray;
            box6.BackColor = Color.LightGray;
            box7.BackColor = Color.LightGray;
            box8.BackColor = Color.LightGray;
            box9.BackColor = Color.LightGray;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            box1.Enabled = true;
            box2.Enabled = true;
            box3.Enabled = true;
            box4.Enabled = true;
            box5.Enabled = true;
            box6.Enabled = true;
            box7.Enabled = true;
            box8.Enabled = true;
            box9.Enabled = true;

            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
            box6.Text = "";
            box7.Text = "";
            box8.Text = "";
            box9.Text = "";

            newGameButton.Enabled = true;

            box1.BackColor = Color.LightGray;
            box2.BackColor = Color.LightGray;
            box3.BackColor = Color.LightGray;
            box4.BackColor = Color.LightGray;
            box5.BackColor = Color.LightGray;
            box6.BackColor = Color.LightGray;
            box7.BackColor = Color.LightGray;
            box8.BackColor = Color.LightGray;
            box9.BackColor = Color.LightGray;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
