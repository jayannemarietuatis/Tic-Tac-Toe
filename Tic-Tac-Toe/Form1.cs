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
    }
}