using _2048.Common;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize;
        private const int offset = 6;
        private Label[,] labelsMap;
        private Panel gamePanel;
        private bool IsGameEndMessageShow = false;
        private int bestScore;
        private int tileSize = 70;

        public MainForm()
        {
            new OptionsForm().ShowDialog();
            InitializeComponent();            
            SetBestScore();

            currentUserLabel.Text = $"Текущий игрок: {StaticData.User.Name}";

            StaticData.MainForm = this;
            mapSize = StaticData.MapSize;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
            ShowScore();
        }
        private void ShowScore()
        {
            scoreLabel.Text = StaticData.User.Score.ToString();
            if (StaticData.User.Score > bestScore)
            {
                bestScoreLabel.Text = StaticData.User.Score.ToString();
            }
        }
        private void SetBestScore()
        {
            bestScore = UserStorage.GetAll()
                .DefaultIfEmpty(StaticData.User)
                .Max(x => x.Score);
            bestScoreLabel.Text = bestScore.ToString();
        }
        private void InitMap()
        {
            gamePanel?.Dispose();
            gamePanel = new Panel();

            this.SetFormSize((mapSize * (tileSize + offset) + offset + 35), (mapSize * (tileSize + offset) + offset + 250));

            gamePanel.BackColor = Color.FromArgb(187, 173, 160);
            gamePanel.Location = new Point(10, 200);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(mapSize * (tileSize + offset) + offset, mapSize * (tileSize + offset) + offset);

            Controls.Add(gamePanel);

            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);                    
                    gamePanel.Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GenerateNumber()
        {
            var emptyLabels = GetEmptyLabels();
            if (emptyLabels.Length == 0) return;

            var randomNumberLabel = new Random().Next(emptyLabels.Length);

            if (new Random().Next(101) > 10)
            {
                emptyLabels[randomNumberLabel].Text = "2";
                return;
            }
            emptyLabels[randomNumberLabel].Text = "4";
        }
        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = Color.FromArgb(204, 192, 179);
            label.Font = new Font("Montserrat ExtraBold", 14F, FontStyle.Bold);
            label.Size = new Size(tileSize, tileSize);
            label.Text = string.Empty;
            label.TextAlign = ContentAlignment.MiddleCenter;

            int x = offset + indexColumn * (tileSize + offset);
            int y = offset + indexRow * (tileSize + offset);
            label.Location = new Point(x, y);

            label.TextChanged += Label_TextChanged;
            return label;
        }
        private void Label_TextChanged(object? sender, EventArgs e)
        {
            var label = (Label)sender;
            var labelsColor = new[]
            {
                new {Value = "", BackColor = Color.FromArgb(204, 192, 179)},
                new {Value = "2", BackColor = Color.FromArgb(244, 244, 230)},
                new { Value = "4", BackColor = Color.FromArgb(219, 216, 188)},
                new { Value = "8", BackColor = Color.FromArgb(246, 217, 106)},
                new {Value = "16", BackColor = Color.FromArgb(246, 144, 107)},
                new {Value = "32", BackColor = Color.FromArgb(247, 107, 131)},
                new {Value = "64", BackColor = Color.FromArgb(255, 1, 1)},
                new {Value = "128", BackColor = Color.FromArgb(255, 242, 205)},
                new {Value = "256", BackColor = Color.FromArgb(255, 229, 154)},
                new { Value = "512", BackColor = Color.FromArgb(255, 223, 134)},
                new {Value = "1024", BackColor = Color.FromArgb(255, 217, 101)},
                new { Value = "2048", BackColor = Color.FromArgb(255, 207, 67)},
                new { Value = "4096", BackColor = Color.FromArgb(237, 229, 255)},
                new { Value = "8196", BackColor = Color.FromArgb(201, 177, 254)},
                new { Value = "16392", BackColor = Color.FromArgb(177, 123, 255)}
            };

            var targetParameter = labelsColor.FirstOrDefault(param => param.Value == label.Text);
            label.BackColor = targetParameter?.BackColor ?? labelsColor.Last().BackColor;
        }
        private bool CheckGameOver()
        {
            //RightCheck
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j > -1; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    return false;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            //LeftCheck
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    return false;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            //UpCheck
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    return false;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            //DownCheck
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i > -1; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k > -1; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    return false;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            if (GetEmptyLabels().Length > 0) return false;

            UserStorage.Save(StaticData.User);

            return true;
        }
        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (CheckGameOver())
            {
                if (!IsGameEndMessageShow)
                {
                    MessageBox.Show($"Игра окончена, {StaticData.User.Name}\nВаш результат: {StaticData.User.Score}");
                    IsGameEndMessageShow = true;
                }
                return;
            }

            var isCorrectButtonPressed = false;

            if (e.KeyData == Keys.Right)
            {
                isCorrectButtonPressed = true;
                MoveRight();
            }
            if (e.KeyData == Keys.Left)
            {
                isCorrectButtonPressed = true;
                MoveLeft();
            }
            if (e.KeyData == Keys.Up)
            {
                isCorrectButtonPressed = true;
                MoveUp();
            }
            if (e.KeyData == Keys.Down)
            {
                isCorrectButtonPressed = true;
                MoveDown();
            }

            if (isCorrectButtonPressed)
            {
                GenerateNumber();
                ShowScore();
            }
            
        }
        private void ResetGame()
        {
            labelsMap.Cast<Label>()
                .ToList()
                .ForEach(label => label.Text = string.Empty);

            StaticData.User.ResetResults();

            IsGameEndMessageShow = false;
            SetBestScore();
            GenerateNumber();
            ShowScore();
        }
        private void restartButton_Click(object sender, EventArgs e) => ResetGame();
        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();
        private void rulesButton_Click(object sender, EventArgs e) => WinFormsProvider.HideFormShowDialog(new RulesForm());
        private void leaderBoardButton_Click(object sender, EventArgs e)
        {
            WinFormsProvider.HideFormShowDialog(new LeaderBoardForm());
            SetBestScore();
        }        
        private void optionsButton_Click(object sender, EventArgs e)
        {
            var IsResetNeeded = false;
            var currentUser = StaticData.User;
            Hide();
            new OptionsForm().ShowDialog();

            if (currentUser != StaticData.User )
            {
                currentUserLabel.Text = $"Текущий игрок: {StaticData.User.Name}";
                IsResetNeeded = true;
            }

            if (mapSize != StaticData.MapSize)
            {
                mapSize = StaticData.MapSize;
                InitMap();
                IsResetNeeded = true;
            }

            if (IsResetNeeded) ResetGame();
            Show();            
        }
        private Label[] GetEmptyLabels() => labelsMap.Cast<Label>().Where(label => label.Text == string.Empty).ToArray();
        private void MoveRight()
        {
            //for each row
            for (int i = 0; i < mapSize; i++)
            {
                //for each cells in current row from end to start
                for (int j = mapSize - 1; j > -1; j--)
                {
                    //find first non - empty cell
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        //for each cells k in current row i left from non-empty cell in column j
                        for (int k = j - 1; k > -1; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    StaticData.User.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            //for each row
            for (int i = 0; i < mapSize; i++)
            {
                //for each cells in current row from end to start
                for (int j = mapSize - 1; j > -1; j--)
                {
                    //find first empty cell
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        //for each cells k in current row i left from empty cell in column j
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveLeft()
        {
            //for each row
            for (int i = 0; i < mapSize; i++)
            {
                //for each cells in current row from start to end
                for (int j = 0; j < mapSize; j++)
                {
                    //find first non - empty cell
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        //for each cells k in current row i rigth from non-empty cell in column j
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    StaticData.User.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            //for each row
            for (int i = 0; i < mapSize; i++)
            {
                //for each cells in current row from start to end
                for (int j = 0; j < mapSize; j++)
                {
                    //find first empty cell
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        //for each cells k in current row i rigth from non-empty cell in column j
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveUp()
        {
            //for column
            for (int j = 0; j < mapSize; j++)
            {
                //for each rows from start to end
                for (int i = 0; i < mapSize; i++)
                {
                    //find first non - empty cell
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        //for each cells k in current column j down from non-empty cell in row i
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    StaticData.User.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            //for column
            for (int j = 0; j < mapSize; j++)
            {
                //for each rows from start to end
                for (int i = 0; i < mapSize; i++)
                {
                    //find first empty cell
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        //for each cells k in current column j down from non-empty cell in row i
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveDown()
        {
            //for column
            for (int j = 0; j < mapSize; j++)
            {
                //for each rows from end to start
                for (int i = mapSize - 1; i > -1; i--)
                {
                    //find first non - empty cell
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        //for each cells k in current column j up from non-empty cell in row i
                        for (int k = i - 1; k > -1; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    StaticData.User.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            //for column
            for (int j = 0; j < mapSize; j++)
            {
                //for each rows from end to start
                for (int i = mapSize - 1; i > -1; i--)
                {
                    //find first empty cell
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        //for each cells k in current column j up from non-empty cell in row i
                        for (int k = i - 1; k > -1; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        //Данный метод убирает стандартное действие по переключению кнопок с помощью стрелок клавиатуры
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ActiveControl = null;
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.Tab)
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }        
    }
}
