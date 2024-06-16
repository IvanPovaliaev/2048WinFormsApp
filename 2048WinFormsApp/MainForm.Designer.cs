using System.Drawing;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            scoreTextLabel = new Label();
            restartButton = new Button();
            rulesButton = new Button();
            exitButton = new Button();
            scorePanel = new Panel();
            scoreLabel = new Label();
            bestScorePanel = new Panel();
            bestScoreLabel = new Label();
            bestTextLabel = new Label();
            leaderBoardButton = new Button();
            logoLabel = new Label();
            currentUserLabel = new Label();
            optionsButton = new Button();
            scorePanel.SuspendLayout();
            bestScorePanel.SuspendLayout();
            SuspendLayout();
            // 
            // scoreTextLabel
            // 
            scoreTextLabel.BackColor = Color.Transparent;
            scoreTextLabel.Dock = DockStyle.Top;
            scoreTextLabel.Font = new Font("Montserrat ExtraBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreTextLabel.ForeColor = Color.FromArgb(250, 248, 239);
            scoreTextLabel.ImageAlign = ContentAlignment.MiddleRight;
            scoreTextLabel.Location = new Point(0, 0);
            scoreTextLabel.Name = "scoreTextLabel";
            scoreTextLabel.Size = new Size(100, 27);
            scoreTextLabel.TabIndex = 4;
            scoreTextLabel.Text = "SCORE";
            scoreTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            restartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            restartButton.BackColor = Color.FromArgb(119, 116, 101);
            restartButton.FlatAppearance.BorderSize = 0;
            restartButton.FlatStyle = FlatStyle.Flat;
            restartButton.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            restartButton.ForeColor = Color.FromArgb(250, 248, 239);
            restartButton.Location = new Point(111, 73);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(100, 25);
            restartButton.TabIndex = 3;
            restartButton.TabStop = false;
            restartButton.Text = "Новая игра";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // rulesButton
            // 
            rulesButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rulesButton.BackColor = Color.FromArgb(119, 116, 101);
            rulesButton.FlatAppearance.BorderSize = 0;
            rulesButton.FlatStyle = FlatStyle.Flat;
            rulesButton.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            rulesButton.ForeColor = Color.FromArgb(250, 248, 239);
            rulesButton.Location = new Point(111, 104);
            rulesButton.Name = "rulesButton";
            rulesButton.Size = new Size(100, 25);
            rulesButton.TabIndex = 2;
            rulesButton.TabStop = false;
            rulesButton.Text = "Правила";
            rulesButton.UseVisualStyleBackColor = false;
            rulesButton.Click += rulesButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.BackColor = Color.FromArgb(119, 116, 101);
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            exitButton.ForeColor = Color.FromArgb(250, 248, 239);
            exitButton.Location = new Point(217, 104);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 25);
            exitButton.TabIndex = 1;
            exitButton.TabStop = false;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // scorePanel
            // 
            scorePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scorePanel.BackColor = Color.FromArgb(187, 173, 160);
            scorePanel.Controls.Add(scoreLabel);
            scorePanel.Controls.Add(scoreTextLabel);
            scorePanel.ForeColor = Color.FromArgb(250, 248, 239);
            scorePanel.Location = new Point(111, 12);
            scorePanel.Name = "scorePanel";
            scorePanel.Size = new Size(100, 55);
            scorePanel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Dock = DockStyle.Bottom;
            scoreLabel.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreLabel.ForeColor = Color.FromArgb(250, 248, 239);
            scoreLabel.ImageAlign = ContentAlignment.MiddleRight;
            scoreLabel.Location = new Point(0, 27);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(100, 28);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "0000000";
            scoreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // bestScorePanel
            // 
            bestScorePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bestScorePanel.BackColor = Color.FromArgb(187, 173, 160);
            bestScorePanel.Controls.Add(bestScoreLabel);
            bestScorePanel.Controls.Add(bestTextLabel);
            bestScorePanel.ForeColor = Color.FromArgb(250, 248, 239);
            bestScorePanel.Location = new Point(217, 12);
            bestScorePanel.Name = "bestScorePanel";
            bestScorePanel.Size = new Size(100, 55);
            bestScorePanel.TabIndex = 5;
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.BackColor = Color.Transparent;
            bestScoreLabel.Dock = DockStyle.Bottom;
            bestScoreLabel.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bestScoreLabel.ForeColor = Color.FromArgb(250, 248, 239);
            bestScoreLabel.ImageAlign = ContentAlignment.MiddleRight;
            bestScoreLabel.Location = new Point(0, 27);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(100, 28);
            bestScoreLabel.TabIndex = 4;
            bestScoreLabel.Text = "0000000";
            bestScoreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // bestTextLabel
            // 
            bestTextLabel.BackColor = Color.Transparent;
            bestTextLabel.Dock = DockStyle.Top;
            bestTextLabel.Font = new Font("Montserrat ExtraBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bestTextLabel.ForeColor = Color.FromArgb(250, 248, 239);
            bestTextLabel.ImageAlign = ContentAlignment.MiddleRight;
            bestTextLabel.Location = new Point(0, 0);
            bestTextLabel.Name = "bestTextLabel";
            bestTextLabel.Size = new Size(100, 27);
            bestTextLabel.TabIndex = 4;
            bestTextLabel.Text = "BEST";
            bestTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leaderBoardButton
            // 
            leaderBoardButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            leaderBoardButton.BackColor = Color.FromArgb(119, 116, 101);
            leaderBoardButton.FlatAppearance.BorderSize = 0;
            leaderBoardButton.FlatStyle = FlatStyle.Flat;
            leaderBoardButton.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            leaderBoardButton.ForeColor = Color.FromArgb(250, 248, 239);
            leaderBoardButton.Location = new Point(217, 73);
            leaderBoardButton.Name = "leaderBoardButton";
            leaderBoardButton.Size = new Size(100, 25);
            leaderBoardButton.TabIndex = 1;
            leaderBoardButton.TabStop = false;
            leaderBoardButton.Text = "Результаты";
            leaderBoardButton.UseVisualStyleBackColor = false;
            leaderBoardButton.Click += leaderBoardButton_Click;
            // 
            // logoLabel
            // 
            logoLabel.BackColor = Color.FromArgb(237, 197, 63);
            logoLabel.Font = new Font("Montserrat ExtraBold", 14.25F, FontStyle.Bold);
            logoLabel.ForeColor = Color.FromArgb(250, 248, 239);
            logoLabel.Location = new Point(12, 12);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(85, 85);
            logoLabel.TabIndex = 6;
            logoLabel.Text = "2048";
            logoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentUserLabel
            // 
            currentUserLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            currentUserLabel.BackColor = Color.FromArgb(119, 116, 101);
            currentUserLabel.Font = new Font("Montserrat ExtraBold", 10F, FontStyle.Bold);
            currentUserLabel.ForeColor = Color.FromArgb(250, 248, 239);
            currentUserLabel.Location = new Point(12, 143);
            currentUserLabel.Name = "currentUserLabel";
            currentUserLabel.Size = new Size(305, 40);
            currentUserLabel.TabIndex = 7;
            currentUserLabel.Text = "username";
            currentUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // optionsButton
            // 
            optionsButton.BackColor = Color.FromArgb(119, 116, 101);
            optionsButton.FlatAppearance.BorderSize = 0;
            optionsButton.FlatStyle = FlatStyle.Flat;
            optionsButton.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            optionsButton.ForeColor = Color.FromArgb(250, 248, 239);
            optionsButton.Location = new Point(12, 104);
            optionsButton.Name = "optionsButton";
            optionsButton.Size = new Size(85, 25);
            optionsButton.TabIndex = 2;
            optionsButton.TabStop = false;
            optionsButton.Text = "Опции";
            optionsButton.UseVisualStyleBackColor = false;
            optionsButton.Click += optionsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 248, 239);
            ClientSize = new Size(329, 521);
            Controls.Add(currentUserLabel);
            Controls.Add(logoLabel);
            Controls.Add(bestScorePanel);
            Controls.Add(scorePanel);
            Controls.Add(leaderBoardButton);
            Controls.Add(exitButton);
            Controls.Add(optionsButton);
            Controls.Add(rulesButton);
            Controls.Add(restartButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048Game";
            Load += MainForm_Load;
            PreviewKeyDown += MainForm_PreviewKeyDown;
            scorePanel.ResumeLayout(false);
            bestScorePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label scoreTextLabel;
        private Button restartButton;
        private Button rulesButton;
        private Button exitButton;
        private Panel scorePanel;
        private Label scoreLabel;
        private Panel bestScorePanel;
        private Label bestScoreLabel;
        private Label bestTextLabel;
        private Button leaderBoardButton;
        private Label logoLabel;
        private Label currentUserLabel;
        private Button optionsButton;
    }
}
