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
    }
}