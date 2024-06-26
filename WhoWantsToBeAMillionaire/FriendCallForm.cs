namespace WhoWantsToBeAMillionaire
{
    public partial class FriendCallForm : Form
    {
        private bool isValid = false;
        private int secondsLeft = 30;

        public string PhoneNumber
        {
            get { return txtFriendNumber.Text; }
            set { txtFriendNumber.Text = value; }
        }

        public FriendCallForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            isValid = System.Text.RegularExpressions.Regex.IsMatch(txtFriendNumber.Text, @"(\+7|8)9\d{9}");

            // Проверяем подходит ли телефон маске
            if (isValid)
            {
                MessageBox.Show("Спасибо! Номер телефона принят: " + txtFriendNumber.Text);
                timer1.Stop();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный формат номера телефона. Попробуйте еще раз.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            btnOK.Text = $"OK ({secondsLeft})";

            if (secondsLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Вы превысили время и потеряли попытку!");
                this.Close();
            }
        }
    }
}
