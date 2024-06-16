using _2048.Common;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class LeaderBoardForm : Form
    {
        private IEnumerable<User> bestUsersResults { get; set; }
        private IEnumerable<User> topFiveUsers { get; set; }
        private BindingSource dataSource;

        public LeaderBoardForm()
        {
            InitializeComponent();

            var dataList = new BindingList<User>(UserStorage.GetAll().OrderByDescending(user => user.Score).ToList());
            dataSource = new BindingSource(dataList, null);

            InitializeLeaderboardTable();

            bestUsersResults = dataList.ToLookup(user => user.Name)
                .Select(user => user.OrderByDescending(game => game.Score).First());

            topFiveUsers = bestUsersResults.Take(5);
            CreateBestResultsChart();
        }

        private void InitializeLeaderboardTable()
        {
            leaderboardDataGridView.DataSource = dataSource;
            leaderboardDataGridView.Columns[0].HeaderText = "Пользователь";
            leaderboardDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            leaderboardDataGridView.Columns[1].HeaderText = "Счёт";
            leaderboardDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            leaderboardDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(204, 192, 179);
            leaderboardDataGridView.DefaultCellStyle.ForeColor = Color.Black;

            leaderboardDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            leaderboardDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        }
        private void returnButton_Click(object sender, EventArgs e) => Close();
        private void CreateBestResultsChart()
        {
            Func<ChartPoint, string> labelPoint = chartpoint => $"{chartpoint.Y}";
            var chartSeries = new SeriesCollection();

            foreach (var user in topFiveUsers)
                chartSeries.Add(new PieSeries() { Title = user.Name, Values = new ChartValues<int> { user.Score }, DataLabels = true, LabelPoint = labelPoint });

            bestUserPieChart.Series = chartSeries;
            bestUserPieChart.LegendLocation = LegendLocation.Bottom;
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var name = ((TextBox)sender).Text?.ToUpper() ?? string.Empty;

            topFiveUsers = bestUsersResults
                .Where(user => user.Name.ToUpper().StartsWith(name))
                .OrderByDescending(user => user.Score)
                .Take(5)
                .ToArray();

            CreateBestResultsChart();
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            var sfDialog = new SaveFileDialog();
            sfDialog.FileName = "2048Game_Leaderboard";
            sfDialog.Filter = "Книга Excel|*.xlsx";

            if (sfDialog.ShowDialog() != DialogResult.OK) return;

            FileProvider.ExportCollectionExcel(sfDialog.FileName, "Leaderboard", UserStorage.GetAll());
        }
        private void clearResults_Click(object sender, EventArgs e)
        {
            UserStorage.Clear();
            dataSource.Clear();
            bestUserPieChart.Series.Clear();
        }
    }
}
