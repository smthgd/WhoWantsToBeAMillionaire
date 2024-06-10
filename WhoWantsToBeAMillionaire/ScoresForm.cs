namespace WhoWantsToBeAMillionaire
{
    public partial class ScoresForm : Form
    {
        public ScoresForm()
        {
            InitializeComponent();
        }

        public string PlayerName { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PlayerName = txtName.Text;
            Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
