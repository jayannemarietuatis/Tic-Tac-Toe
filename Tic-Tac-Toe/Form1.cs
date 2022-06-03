namespace Tic_Tac_Toe
{
    public partial class Gameform : Form
    {
        public Gameform()
        {
            InitializeComponent();
        }
        bool player = true;
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
        }
    }
}