namespace WhoWantsToBeAMillionaire
{
    public partial class HintsForm : Form
    {
        List<int> hints = new List<int> { 0, 1, 2, 3, 4 };

        public List<int> Hints
        {
            get { return hints; }
            set { hints = value; }
        }

        public HintsForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                hints.Remove(0);
            }
            else
            {
                hints.Add(0);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                hints.Remove(1);
            }
            else
            {
                hints.Add(1);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                hints.Remove(2);
            }
            else
            {
                hints.Add(2);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                hints.Remove(3);
            }
            else
            {
                hints.Add(3);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                hints.Remove(4);
            }
            else
            {
                hints.Add(4);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрано нужное количество подсказок, а именно 3 из 5
            if (hints.Count == 2)
            {
                Hints = hints;
                Close();
            }
            else
            {
                MessageBox.Show("Вам требуется выбрать 3 подсказки");
            }
        }

        private void HintsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
