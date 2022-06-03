namespace Tic_Tac_Toe
{
    public partial class Gameform : Form
    {
        bool player = true;
        byte player_turn = 0;
        public Gameform()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRA1.Text = "X";
                player = !player;
            }
            else
            {
                bttnRA1.Text = "O";
                player = !player;
            }
            bttnRA1.Enabled = false;
            player_turn++;
            results();
        }
        private void ExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bttnRA2_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRA2.Text = "X";
                player = !player;
            }
            else
            {
                bttnRA2.Text = "O";
                player = !player;
            }
            bttnRA2.Enabled = false;
            player_turn++;
            results();
        }
        private void bttnRA3_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRA3.Text = "X";
                player = !player;
            }
            else
            {
                bttnRA3.Text = "O";
                player = !player;
            }
            bttnRA3.Enabled = false;
            player_turn++;
            results();
        }
        private void bttnRB1_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRB1.Text = "X";
                player = !player;
            }
            else
            {
                bttnRB1.Text = "O";
                player = !player;
            }
            bttnRB1.Enabled = false;
            player_turn++;
            results();
        }
        private void bttnRB2_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRB2.Text = "X";
                player = !player;
            }
            else
            {
                bttnRB2.Text = "O";
                player = !player;
            }
            bttnRB2.Enabled = false;
            player_turn++;
            results();
        }
        private void bttnRB3_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRB3.Text = "X";
                player = !player;
            }
            else
            {
                bttnRB3.Text = "O";
                player = !player;
            }
            bttnRB3.Enabled = false;
            player_turn++;
            results();
        }
        private void bttnRC1_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRC1.Text = "X";
                player = !player;
            }
            else
            {
                bttnRC1.Text = "O";
                player = !player;
            }
            bttnRC1.Enabled = false;
            player_turn++;
            results();
        }
        private void bttnRC2_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRC2.Text = "X";
                player = !player;
            }
            else
            {
                bttnRC2.Text = "O";
                player = !player;
            }
            bttnRC2.Enabled = false;
            player_turn++;
            results();
        }
        private void bttnRC3_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                bttnRC3.Text = "X";
                player = !player;
            }
            else
            {
                bttnRC3.Text = "O";
                player = !player;
            }
            bttnRC3.Enabled = false;
            player_turn++;
            results();
        }
        private void results()
        {
            bool winner = false;

            if ((bttnRA1.Text == bttnRA2.Text && bttnRA2.Text == bttnRA3.Text) && (!bttnRA1.Enabled))
                winner = true;
            else if ((bttnRB1.Text == bttnRB2.Text && bttnRB2.Text == bttnRB3.Text) && (!bttnRB1.Enabled))
                winner = true;
            else if ((bttnRC1.Text == bttnRC2.Text && bttnRC2.Text == bttnRC3.Text) && (!bttnRC1.Enabled))
                winner = true;

            else if ((bttnRA1.Text == bttnRB1.Text && bttnRB1.Text == bttnRC1.Text) && (!bttnRA1.Enabled))
                winner = true;
            else if ((bttnRA2.Text == bttnRB2.Text && bttnRB2.Text == bttnRC2.Text) && (!bttnRA2.Enabled))
                winner = true;
            else if ((bttnRA3.Text == bttnRB3.Text && bttnRB3.Text == bttnRC3.Text) && (!bttnRA3.Enabled))
                winner = true;

            else if ((bttnRA1.Text == bttnRB2.Text && bttnRB2.Text == bttnRC3.Text) && (!bttnRA1.Enabled))
                winner = true;
            else if ((bttnRC1.Text == bttnRB2.Text && bttnRB2.Text == bttnRA3.Text) && (!bttnRC1.Enabled))
                winner = true;

            if (winner)
            {
                String wins = "";
                
                if (player)
                    wins = "O";
                else
                    wins = "X";
                MessageBox.Show(wins + " is Victory!!");
            }
            else
            {
                if (player_turn == 9)
                    MessageBox.Show("It's a tie!");
            }
        }
    }
}