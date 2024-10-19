namespace ticTacToe
{
    public partial class Form1 : Form
    {
        private bool checkTurn = false; //Indicate whose turn it is; false = X and true = O

        private int winner; //Holds the current Winner's score

        private string lastWinner; // for tracking the last player who won the game
        private void Enable_False()
        {
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button btn in buttons)
            {
                btn.Enabled = false; // Disable each button
            }
        }

        private void scoreBoard()
        {
            // Horizontal Combination for X
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
                btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
                btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                HighlightWinningButtons("X");
                MessageBox.Show("The Player X wins the match");
                winner = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(winner + 1);
                lastWinner = "X";
                Enable_False(); //Once the player win this function call and disable all the other buttons
                return;
            }

            //Vertical combination for X
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
                btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
                btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                HighlightWinningButtons("X");
                MessageBox.Show("The Player X wins the match");
                winner = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(winner + 1);
                lastWinner = "X";
                Enable_False();
                return;
            }

            //------------------------------------------------------------------------------
            //Horizontal Combination for O
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" ||
                btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" ||
                btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                HighlightWinningButtons("O");
                MessageBox.Show("The Player O wins the match");
                winner = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(winner + 1);
                lastWinner = "O";
                Enable_False();
                return;
            }

            //Vertical Combinatopn for O
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" ||
                btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" ||
                btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                HighlightWinningButtons("O");
                MessageBox.Show("The Player O wins the match");
                winner = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(winner + 1);
                lastWinner = "O";
                Enable_False();
                return;
            }

            //------------------------------------------------------------------------------
            //Diagonals and Anti-Diagonals for the both players
            //Diagonal for X
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
                btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                HighlightWinningButtons("X");
                MessageBox.Show("The Player X wins the match");
                winner = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(winner + 1);
                lastWinner = "X";
                Enable_False();
                return;
            }

            //Diagonal for O
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" ||
                    btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                HighlightWinningButtons("O");
                MessageBox.Show("The Player O wins the match");
                winner = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(winner + 1);
                lastWinner = "O";
                Enable_False();
                return;
            }

            //------------------------------------------------------------------------------
            //For Tie
            // Count filled buttons
            int filledCount = 0;
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (Button btn in buttons)
            {
                if (btn.Text == "X" || btn.Text == "O")
                {
                    filledCount++;
                }
            }

            // Check for tie condition
            if (filledCount == 9) // All buttons filled
            {
                MessageBox.Show("The match is a tie!");
                Enable_False();
            }
        }
        private void HighlightWinningButtons(string player)
        {
            if (player == "X")
            {
                // Highlight buttons if player X wins
                if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") { btn1.BackColor = Color.Green; btn2.BackColor = Color.Green; btn3.BackColor = Color.Green; }
                if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") { btn4.BackColor = Color.Green; btn5.BackColor = Color.Green; btn6.BackColor = Color.Green; }
                if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") { btn7.BackColor = Color.Green; btn8.BackColor = Color.Green; btn9.BackColor = Color.Green; }
                if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") { btn1.BackColor = Color.Green; btn4.BackColor = Color.Green; btn7.BackColor = Color.Green; }
                if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") { btn2.BackColor = Color.Green; btn5.BackColor = Color.Green; btn8.BackColor = Color.Green; }
                if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") { btn3.BackColor = Color.Green; btn6.BackColor = Color.Green; btn9.BackColor = Color.Green; }
                if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") { btn1.BackColor = Color.Green; btn5.BackColor = Color.Green; btn9.BackColor = Color.Green; }
                if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X") { btn3.BackColor = Color.Green; btn5.BackColor = Color.Green; btn7.BackColor = Color.Green; }
            }
            else if (player == "O")
            {
                // Highlight buttons if player O wins
                if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") { btn1.BackColor = Color.Green; btn2.BackColor = Color.Green; btn3.BackColor = Color.Green; }
                if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") { btn4.BackColor = Color.Green; btn5.BackColor = Color.Green; btn6.BackColor = Color.Green; }
                if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") { btn7.BackColor = Color.Green; btn8.BackColor = Color.Green; btn9.BackColor = Color.Green; }
                if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") { btn1.BackColor = Color.Green; btn4.BackColor = Color.Green; btn7.BackColor = Color.Green; }
                if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") { btn2.BackColor = Color.Green; btn5.BackColor = Color.Green; btn8.BackColor = Color.Green; }
                if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") { btn3.BackColor = Color.Green; btn6.BackColor = Color.Green; btn9.BackColor = Color.Green; }
                if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") { btn1.BackColor = Color.Green; btn5.BackColor = Color.Green; btn9.BackColor = Color.Green; }
                if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") { btn3.BackColor = Color.Green; btn5.BackColor = Color.Green; btn7.BackColor = Color.Green; }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            
            // Loop through each button to enable them for gameplay
            foreach (Button btn in buttons)
            {
                btn.Enabled = true; // Enable each button
            }

            // Reset the score board
            lblPlayerX.Text = "0";
            lblPlayerO.Text = "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn1.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn1.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn2.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn2.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn3.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn3.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn4.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn4.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn5.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn5.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn6.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn6.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn7.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn7.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn8.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn8.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checkTurn == false)
            {
                btn9.Text = "X";
                checkTurn = true;
            }
            else
            {
                btn9.Text = "O";
                checkTurn = false;
            }
            scoreBoard();
            btn9.Enabled = false;
        }
        //New game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
                Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
                // Loop through each button to reset properties
                foreach (Button btn in buttons)
                {
                    btn.Enabled = true;
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }

                // Reset score labels
                lblPlayerX.Text = "0";
                lblPlayerO.Text = "0";

                // Always start with X
                checkTurn = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
                Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
                // Loop through each button to reset properties
                foreach (Button btn in buttons)
                {
                    btn.Enabled = true;
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
                btnNewGame.Enabled = true;
                // Reset the check variable based on the last winner.
                // If lastWinner is "X", X will go first
                // If lastWinner is "O", O will go first
                checkTurn = lastWinner == "X" ? false : true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
                DialogResult iExit;
                iExit = MessageBox.Show("Are you sure? You want to exit the game");
                if(iExit == DialogResult.OK)
                {
                    Application.Exit();
                }
        }
    }
}
