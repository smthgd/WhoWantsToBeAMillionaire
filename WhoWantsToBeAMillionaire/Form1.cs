using System.Data.SQLite;
using System.Media;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();

        private int level = 0;
        private string playerName;
        private bool isErrorMargin = false;

        private Random rnd = new Random();
        private static Random random = new Random();
        private Question currentQuestion;
        private SoundPlayer soundPlayer;

        private WMPLib.WindowsMediaPlayer rightAnsSound;
        private WMPLib.WindowsMediaPlayer wrongAnsSound;
        private WMPLib.WindowsMediaPlayer fiftyFiftyHint;

        private WMPLib.WindowsMediaPlayer RightAnsSound 
        {  
            get 
            {
                rightAnsSound = new WMPLib.WindowsMediaPlayer();
                rightAnsSound.URL = "khsm_q1-5-correct-o.mp3";

                return rightAnsSound; 
            }
        }

        private WMPLib.WindowsMediaPlayer WrongAnsSound
        {
            get
            {
                wrongAnsSound = new WMPLib.WindowsMediaPlayer();
                wrongAnsSound.URL = "khsm_q1-5-wrong.mp3";

                return wrongAnsSound;
            }
        }

        private WMPLib.WindowsMediaPlayer FiftyFiftyHint
        {
            get
            {
                fiftyFiftyHint = new WMPLib.WindowsMediaPlayer();
                fiftyFiftyHint.URL = "khsm_50-50.mp3";

                return fiftyFiftyHint;
            }
        }

        public Form1()
        {
            InitializeComponent();
            StartGame();
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
            SQLiteConnection connection = new SQLiteConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["questions"].ConnectionString;
            connection.Open();

            var command = new SQLiteCommand($@"select * from Questions WHERE Level={level} order by Random() LIMIT 1", connection);

            var dataReader = command.ExecuteReader();
            dataReader.Read();
            Question question = new Question(dataReader);

            return question;
        }

        // Метод для перехода на следующий этап игры
        private void NextStep()
        {
            Button[] buttons = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }

            level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
            panel1.Controls.Clear();
        }

        // Метод для начала игры
        private void StartGame()
        {
            WMPLib.WindowsMediaPlayer soundPlayer = new WMPLib.WindowsMediaPlayer();
            soundPlayer.URL = "hello-new-punter-2008-long.mp3";
            soundPlayer.controls.play();

            Button[] hintButtons = new Button[] { btnFiftyFifty, btnFriendCall, btnQuestionReplace, btnErrorMargin, btnAudienceHelp };

            foreach (Button button in hintButtons)
            {
                button.Enabled = true;
            }

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

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                RightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    WrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName,level);
                    StartGame();
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

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                RightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    WrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName, level);
                    StartGame();
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

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                RightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    WrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName, level);
                    StartGame();
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

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                RightAnsSound.controls.play();
                NextStep();
            }
            else
            {
                if (!isErrorMargin)
                {
                    WrongAnsSound.controls.play();
                    MessageBox.Show("Неверный ответ!");
                    SaveResultToDatabase(playerName,level);
                    StartGame();
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

            FiftyFiftyHint.controls.play();
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
            int friendAnswerNumber = random.Next(1,5); // Друг отвечает не обязательно правильно. Выбирается случайный ответ
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
            Chart pieChart = new Chart();
            pieChart.Dock = DockStyle.Fill;
            pieChart.Legends.Add("Legend");
            pieChart.ChartAreas.Add("ChartArea1");

            List<int> numbers = new List<int>();
            int percentLeft = 0;

            for (int i = 0; i < 3; i++)
            {
                int newValue = random.Next(1, 100 - percentLeft);
                percentLeft += newValue;
                numbers.Add(newValue);
            }

            numbers.Add(100 - percentLeft);
            pieChart.Series.Add("Series1");

            // Добавить данные в круговую диаграмму
            // Зал отвечает не обязательно верно. Данные генерируются случайно
            foreach (int number in numbers)
            {
                pieChart.Series["Series1"].Points.AddXY(number, number);
            }

            string[] legendLabels = { btnAnswerA.Text, btnAnswerB.Text, btnAnswerC.Text, btnAnswerD.Text };

            for (int i = 0; i < pieChart.Series["Series1"].Points.Count; i++)
            {
                pieChart.Series["Series1"].Points[i].LegendText = legendLabels[i];
            }

            // Устанавливаем свойства диаграммы
            pieChart.Series["Series1"].ChartType = SeriesChartType.Pie;
            pieChart.Series["Series1"].LegendText = "#VALY";
            pieChart.Series["Series1"].Label = "#VALY%";
            pieChart.Legends["Legend"].Docking = Docking.Bottom;

            panel1.Controls.Add(pieChart);
            btnAudienceHelp.Enabled = false;
        }

        private void btnQuestionReplace_Click(object sender, EventArgs e)
        {
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            this.btnQuestionReplace.Enabled = false;
        }

        // Метод для сохранения данных в базу данных
        private void SaveResultToDatabase(string playerName, int level)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["rating"].ConnectionString))
            {
                connection.Open();

                // Проверяем, существует ли игрок с таким именем уже в базе данных
                string selectQuery = "SELECT * FROM Rating WHERE Name = @Name";

                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Name", playerName);

                    // Выполняем запрос
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read()) // Если игрок найден
                        {
                            // Обновляем его уровень
                            int existingLevel = reader.GetInt32(reader.GetOrdinal("Level"));

                            if (level > existingLevel)
                            {
                                string updateQuery = "UPDATE Rating SET Level = @Level WHERE Name = @Name";

                                using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, connection))
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

                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, connection))
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

        // Метод для загрузки топа игроков
        private void LoadTopPlayers()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["rating"].ConnectionString))
            {
                connection.Open();

                // Создание SQL-запроса для выборки топ-10 игроков
                string selectQuery = "SELECT Name, Level FROM Rating ORDER BY Level DESC LIMIT 10";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    // Выполнение SQL-запроса и получение результатов
                    using (SQLiteDataReader dr = command.ExecuteReader())
                    {
                        topPlayersListBox.Items.Clear();

                        // Отображение результатов на форме
                        while (dr.Read())
                        {
                            string playerName = dr.GetString(0);
                            int level = dr.GetInt32(1);

                            topPlayersListBox.Items.Add($"{playerName} - Уровень {level}");
                        }
                    }
                }
            }
        }
    }
}