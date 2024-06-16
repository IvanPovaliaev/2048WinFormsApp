namespace _2048WinFormsApp
{
    partial class LeaderBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoardForm));
            leaderboardDataGridView = new System.Windows.Forms.DataGridView();
            returnButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            searchTextBox = new System.Windows.Forms.TextBox();
            searchLabel = new System.Windows.Forms.Label();
            bestUserPieChart = new LiveCharts.WinForms.PieChart();
            exportButton = new System.Windows.Forms.Button();
            clearResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)leaderboardDataGridView).BeginInit();
            SuspendLayout();
            // 
            // leaderboardDataGridView
            // 
            leaderboardDataGridView.AllowUserToAddRows = false;
            leaderboardDataGridView.AllowUserToDeleteRows = false;
            leaderboardDataGridView.AllowUserToOrderColumns = true;
            leaderboardDataGridView.AllowUserToResizeColumns = false;
            leaderboardDataGridView.AllowUserToResizeRows = false;
            leaderboardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            leaderboardDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(187, 173, 160);
            leaderboardDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            leaderboardDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(119, 116, 101);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            leaderboardDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            leaderboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            leaderboardDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            leaderboardDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            leaderboardDataGridView.GridColor = System.Drawing.Color.FromArgb(187, 173, 160);
            leaderboardDataGridView.Location = new System.Drawing.Point(370, 0);
            leaderboardDataGridView.Name = "leaderboardDataGridView";
            leaderboardDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(250, 248, 239);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            leaderboardDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            leaderboardDataGridView.RowHeadersVisible = false;
            leaderboardDataGridView.Size = new System.Drawing.Size(329, 616);
            leaderboardDataGridView.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            returnButton.BackColor = System.Drawing.Color.FromArgb(119, 116, 101);
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            returnButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            returnButton.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            returnButton.Location = new System.Drawing.Point(12, 564);
            returnButton.Name = "returnButton";
            returnButton.Size = new System.Drawing.Size(100, 40);
            returnButton.TabIndex = 2;
            returnButton.TabStop = false;
            returnButton.Text = "Вернуться";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(352, 23);
            label1.TabIndex = 4;
            label1.Text = "Лучшие результаты игроков";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = System.Drawing.Color.FromArgb(204, 192, 179);
            searchTextBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            searchTextBox.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            searchTextBox.Location = new System.Drawing.Point(92, 61);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Введите имя игрока";
            searchTextBox.Size = new System.Drawing.Size(229, 24);
            searchTextBox.TabIndex = 6;
            searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            searchLabel.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            searchLabel.Location = new System.Drawing.Point(12, 61);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new System.Drawing.Size(74, 23);
            searchLabel.TabIndex = 7;
            searchLabel.Text = "Найти:";
            // 
            // bestUserPieChart
            // 
            bestUserPieChart.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            bestUserPieChart.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            bestUserPieChart.Location = new System.Drawing.Point(12, 91);
            bestUserPieChart.Name = "bestUserPieChart";
            bestUserPieChart.Size = new System.Drawing.Size(352, 411);
            bestUserPieChart.TabIndex = 8;
            // 
            // exportButton
            // 
            exportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            exportButton.BackColor = System.Drawing.Color.FromArgb(119, 116, 101);
            exportButton.FlatAppearance.BorderSize = 0;
            exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exportButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            exportButton.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            exportButton.Location = new System.Drawing.Point(158, 564);
            exportButton.Name = "exportButton";
            exportButton.Size = new System.Drawing.Size(100, 40);
            exportButton.TabIndex = 2;
            exportButton.TabStop = false;
            exportButton.Text = "Export...";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // clearResults
            // 
            clearResults.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            clearResults.BackColor = System.Drawing.Color.FromArgb(119, 116, 101);
            clearResults.FlatAppearance.BorderSize = 0;
            clearResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clearResults.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            clearResults.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            clearResults.Location = new System.Drawing.Point(264, 564);
            clearResults.Name = "clearResults";
            clearResults.Size = new System.Drawing.Size(100, 40);
            clearResults.TabIndex = 2;
            clearResults.TabStop = false;
            clearResults.Text = "Очистить результаты";
            clearResults.UseVisualStyleBackColor = false;
            clearResults.Click += clearResults_Click;
            // 
            // LeaderBoardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 248, 239);
            ClientSize = new System.Drawing.Size(699, 616);
            Controls.Add(bestUserPieChart);
            Controls.Add(searchLabel);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            Controls.Add(clearResults);
            Controls.Add(exportButton);
            Controls.Add(returnButton);
            Controls.Add(leaderboardDataGridView);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(715, 655);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(715, 655);
            Name = "LeaderBoardForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LeaderBoardForm";
            ((System.ComponentModel.ISupportInitialize)leaderboardDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView leaderboardDataGridView;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private LiveCharts.WinForms.PieChart bestUserPieChart;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button clearResults;
    }
}