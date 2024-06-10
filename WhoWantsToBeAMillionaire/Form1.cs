using System.Data.SQLite;
using System.Media;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form1 : Form
    {
        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        Question currentQuestion;
        bool isErrorMargin = false;
        static Random random = new Random();
        string playerName;
        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            startGame();
        }

        // Метод для отображения в форме вопроса и вариантов ответов
        private void ShowQuestion(Question q)
        {
            lblQuestion.Text = q.Text;
            btnAnswerA.Text = q.Answers[0];
            btnAnswerB.Text = q.Answers[1];
            btnAnswerC.Text = q.Answers[2];
            btnAnswerD.Text = q.Answers[3];
        }

        // Метод для получения вопроса соответсвующего уровня сложности из базы данных
        private Question GetQuestion(int level)
        {
            SQLiteConnection cn = new SQLiteConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["questions"].ConnectionString;
            cn.Open();

            var cmd = new SQLiteCommand($@"select * from Questions WHERE Level={level} order by Random() LIMIT 1", cn);

            var dr = cmd.ExecuteReader();
            dr.Read();
            Question q = new Question(dr);

            return q;
        }


        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            foreach (Button btn in btns)
            {
                btn.Enabled = true;
            }

            level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
            panel1.Controls.Clear();
        }

        private void startGame()
        {
            WMPLib.WindowsMediaPlayer soundPlayer = new WMPLib.WindowsMediaPlayer();
            soundPlayer.URL = "hello-new-punter-2008-long.mp3";
            soundPlayer.controls.play();
            btnFiftyFifty.Enabled = true;
            btnFriendCall.Enabled = true;
            btnQuestionReplace.Enabled = true;
            btnErrorMargin.Enabled = true;
            btnAudienceHelp.Enabled = true;

            level = 0;
            HintsForm hints = new HintsForm();
            ScoresForm enterNameForm = new ScoresForm();
            NextStep();
            enterNameForm.ShowDialog();
            hints.ShowDialog();

            playerName = enterNameForm.PlayerName;

            for (int i = 0; i < 2; i++)
            {
                switch (hints.Hints[i]) 
                {
                    case 0:
                        btnFiftyFifty.Enabled = false;
                        break;

                    case 1:
                        btnFriendCall.Enabled = false;
                        break;

                    case 2:
                        btnErrorMargin.Enabled = false;
                        break;

                    case 3:
                        btnAudienceHelp.Enabled = false;
                        break;

                    case 4:
                        btnQuestionReplace.Enabled = false;
                        break;
                }
            }

            hints.Hints.Clear();
            LoadTopPlayers();
        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            WMPLib.WindowsMediaPlayer rightAnsSound = new WMPLib.WindowsMediaPlayer();
            rightAnsSound.URL = "khsm_q1-5-correct-o.mp3";

            WMPLib.WindowsMediaPlayer wrongAnsSound = new WMPLib.WindowsMediaPlayer();
            wrongAnsSound.URL = "khsm_q1-5-wrong.mp3";

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                rightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    wrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName,level);
                    startGame();
                }
                else
                {
                    btnAnswerA.Enabled = false;
                    isErrorMargin = false;
                }
            }
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            WMPLib.WindowsMediaPlayer rightAnsSound = new WMPLib.WindowsMediaPlayer();
            rightAnsSound.URL = "khsm_q1-5-correct-o.mp3";

            WMPLib.WindowsMediaPlayer wrongAnsSound = new WMPLib.WindowsMediaPlayer();
            wrongAnsSound.URL = "khsm_q1-5-wrong.mp3";

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                rightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    wrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName, level);
                    startGame();
                }
                else
                {
                    btnAnswerB.Enabled = false;
                    isErrorMargin = false;
                }
            }
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            WMPLib.WindowsMediaPlayer rightAnsSound = new WMPLib.WindowsMediaPlayer();
            rightAnsSound.URL = "khsm_q1-5-correct-o.mp3";

            WMPLib.WindowsMediaPlayer wrongAnsSound = new WMPLib.WindowsMediaPlayer();
            wrongAnsSound.URL = "khsm_q1-5-wrong.mp3";

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                rightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    wrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName, level);
                    startGame();
                }
                else
                {
                    btnAnswerC.Enabled = false;
                    isErrorMargin = false;
                }
            }
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            WMPLib.WindowsMediaPlayer rightAnsSound = new WMPLib.WindowsMediaPlayer();
            rightAnsSound.URL = "khsm_q1-5-correct-o.mp3";

            WMPLib.WindowsMediaPlayer wrongAnsSound = new WMPLib.WindowsMediaPlayer();
            wrongAnsSound.URL = "khsm_q1-5-wrong.mp3";

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                rightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    wrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName,level);
                    startGame();
                }
                else
                {
                    btnAnswerD.Enabled = false;
                    isErrorMargin = false;
                }
            }
        }

        private void bntFiftyFifty_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            WMPLib.WindowsMediaPlayer soundPlayer = new WMPLib.WindowsMediaPlayer();
            soundPlayer.URL = "khsm_50-50.mp3";
            soundPlayer.controls.play();
            int count = 0;

            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }

            this.btnFiftyFifty.Enabled = false;
        }

        private void lstLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }

        private void btnFriendCall_Click(object sender, EventArgs e)
        {
            FriendCallForm friendCallForm = new FriendCallForm();
            friendCallForm.timer1.Start();
            friendCallForm.ShowDialog();

            string phoneNumber = friendCallForm.PhoneNumber;
            int friendAnswerNumber = random.Next(1,5);
            string friendAnswerText = "";

            if (phoneNumber != null && phoneNumber != "")
            {
                switch (friendAnswerNumber)
                {
                    case 1:
                        friendAnswerText = btnAnswerA.Text;
                        break;

                    case 2:
                        friendAnswerText= btnAnswerB.Text;
                        break;

                    case 3:
                        friendAnswerText = btnAnswerC.Text;
                        break;

                    case 4:
                        friendAnswerText = btnAnswerD.Text;
                        break;
                }

                MessageBox.Show("Ваш друг, считает, что верный ответ: " + friendAnswerText);
            }

            btnFriendCall.Enabled = false;
        }

        private void btnErrorMargin_Click(object sender, EventArgs e)
        {
            isErrorMargin = true;
            btnErrorMargin.Enabled = false;
        }

        private void btnAudienceHelp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Chart pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pieChart.Dock = DockStyle.Fill;
            pieChart.Legends.Add("Legend");
            pieChart.ChartAreas.Add("ChartArea1");
            int percentLeft = 0;
            List<int> numbers = new List<int>();


            for (int i = 0; i < 3; i++)
            {
                int newValue = random.Next(1, 100 - percentLeft);
                percentLeft += newValue;
                numbers.Add(newValue);
            }

            numbers.Add(100 - percentLeft);
            pieChart.Series.Add("Series1");

            // Добавить данные в круговую диаграмму
            foreach (int number in numbers)
            {
                pieChart.Series["Series1"].Points.AddXY(number, number);
            }

            string[] legendLabels = { btnAnswerA.Text, btnAnswerB.Text, btnAnswerC.Text, btnAnswerD.Text };
            for (int i = 0; i < pieChart.Series["Series1"].Points.Count; i++)
            {
                pieChart.Series["Series1"].Points[i].LegendText = legendLabels[i];
            }

            // Установить свойства диаграммы
            pieChart.Series["Series1"].ChartType = SeriesChartType.Pie;
            pieChart.Series["Series1"].LegendText = "#VALY";
            pieChart.Series["Series1"].Label = "#VALY%";
            pieChart.Legends["Legend"].Docking = Docking.Bottom;

            // Добавить диаграмму на панель
            panel1.Controls.Add(pieChart);
            btnAudienceHelp.Enabled = false;
        }

        private void btnQuestionReplace_Click(object sender, EventArgs e)
        {
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            this.btnQuestionReplace.Enabled = false;
        }

        private void SaveResultToDatabase(string playerName, int level)
        {
            using (SQLiteConnection cn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["rating"].ConnectionString))
            {
                cn.Open();

                // Проверяем, существует ли игрок с таким именем уже в базе данных
                string selectQuery = "SELECT * FROM Rating WHERE Name = @Name";

                using (SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, cn))
                {
                    selectCmd.Parameters.AddWithValue("@Name", playerName);

                    // Выполняем запрос
                    using (SQLiteDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read()) // Если игрок найден
                        {
                            // Обновляем его уровень
                            int existingLevel = reader.GetInt32(reader.GetOrdinal("Level"));
                            if (level > existingLevel)
                            {
                                string updateQuery = "UPDATE Rating SET Level = @Level WHERE Name = @Name";
                                using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, cn))
                                {
                                    updateCmd.Parameters.AddWithValue("@Level", level);
                                    updateCmd.Parameters.AddWithValue("@Name", playerName);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }
                        else // Если игрок не найден, добавляем новую запись
                        {
                            string insertQuery = "INSERT INTO Rating (Name, Level) VALUES (@Name, @Level)";
                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, cn))
                            {
                                insertCmd.Parameters.AddWithValue("@Name", playerName);
                                insertCmd.Parameters.AddWithValue("@Level", level);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        private void LoadTopPlayers()
        {
            // Подключение к базе данных SQLite
            using (SQLiteConnection cn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["rating"].ConnectionString))
            {
                cn.Open();

                // Создание SQL-запроса для выборки топ-10 игроков
                string sql = "SELECT Name, Level FROM Rating ORDER BY Level DESC LIMIT 10";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                {
                    // Выполнение SQL-запроса и получение результатов
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        // Очистка списка топ-10 игроков
                        topPlayersListBox.Items.Clear();

                        // Отображение результатов на форме
                        while (dr.Read())
                        {
                            string playerName = dr.GetString(0);
                            int level = dr.GetInt32(1);

                            // Отображение имени игрока и его уровня в списке топ-10
                            topPlayersListBox.Items.Add($"{playerName} - Уровень {level}");
                        }
                    }
                }
            }
        }
    }
}