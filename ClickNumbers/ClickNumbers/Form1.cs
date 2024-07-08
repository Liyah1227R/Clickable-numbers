namespace ClickNumbers
{
    public partial class ClickNumbers : Form
    {
        public ClickNumbers()
        {
            InitializeComponent();
        }

        private void PBS1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void PBS2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void PBS3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void PBS4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void PBS5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }

        private void ExitAll_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}