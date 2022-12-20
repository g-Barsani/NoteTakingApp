namespace NoteTakingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutOption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Gabriel Barsani");
        }
    }
}