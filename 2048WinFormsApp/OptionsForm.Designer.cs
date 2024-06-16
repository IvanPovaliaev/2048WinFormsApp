namespace _2048WinFormsApp
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            logoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            userNameTextBox = new System.Windows.Forms.TextBox();
            acceptButton = new System.Windows.Forms.Button();
            returnButton = new System.Windows.Forms.Button();
            chooseFieldSizeLabel = new System.Windows.Forms.Label();
            fieldSizeСomboBox = new System.Windows.Forms.ComboBox();
            musicTrackBar = new System.Windows.Forms.TrackBar();
            musicVolumeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)musicTrackBar).BeginInit();
            SuspendLayout();
            // 
            // logoLabel
            // 
            logoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            logoLabel.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Bold);
            logoLabel.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            logoLabel.Location = new System.Drawing.Point(0, 0);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(329, 108);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "2048";
            logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(187, 173, 160);
            label1.Location = new System.Drawing.Point(0, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(329, 35);
            label1.TabIndex = 1;
            label1.Text = "Введите имя:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            userNameTextBox.BackColor = System.Drawing.Color.FromArgb(204, 192, 179);
            userNameTextBox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            userNameTextBox.Location = new System.Drawing.Point(12, 146);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PlaceholderText = "Введите своё имя";
            userNameTextBox.Size = new System.Drawing.Size(305, 30);
            userNameTextBox.TabIndex = 2;
            userNameTextBox.Text = "NoName";
            userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // acceptButton
            // 
            acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            acceptButton.BackColor = System.Drawing.Color.FromArgb(119, 116, 101);
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            acceptButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            acceptButton.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            acceptButton.Location = new System.Drawing.Point(197, 364);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(120, 35);
            acceptButton.TabIndex = 3;
            acceptButton.TabStop = false;
            acceptButton.Text = "Подтвердить";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // returnButton
            // 
            returnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            returnButton.BackColor = System.Drawing.Color.FromArgb(119, 116, 101);
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            returnButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            returnButton.ForeColor = System.Drawing.Color.FromArgb(250, 248, 239);
            returnButton.Location = new System.Drawing.Point(12, 364);
            returnButton.Name = "returnButton";
            returnButton.Size = new System.Drawing.Size(120, 35);
            returnButton.TabIndex = 3;
            returnButton.TabStop = false;
            returnButton.Text = "Выход";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // chooseFieldSizeLabel
            // 
            chooseFieldSizeLabel.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            chooseFieldSizeLabel.ForeColor = System.Drawing.Color.FromArgb(187, 173, 160);
            chooseFieldSizeLabel.Location = new System.Drawing.Point(0, 179);
            chooseFieldSizeLabel.Name = "chooseFieldSizeLabel";
            chooseFieldSizeLabel.Size = new System.Drawing.Size(329, 35);
            chooseFieldSizeLabel.TabIndex = 4;
            chooseFieldSizeLabel.Text = "Выберите размер поля";
            chooseFieldSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldSizeСomboBox
            // 
            fieldSizeСomboBox.BackColor = System.Drawing.Color.FromArgb(204, 192, 179);
            fieldSizeСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fieldSizeСomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            fieldSizeСomboBox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            fieldSizeСomboBox.ForeColor = System.Drawing.Color.FromArgb(119, 116, 101);
            fieldSizeСomboBox.FormattingEnabled = true;
            fieldSizeСomboBox.Location = new System.Drawing.Point(12, 217);
            fieldSizeСomboBox.Name = "fieldSizeСomboBox";
            fieldSizeСomboBox.Size = new System.Drawing.Size(305, 34);
            fieldSizeСomboBox.TabIndex = 5;
            // 
            // musicTrackBar
            // 
            musicTrackBar.BackColor = System.Drawing.Color.FromArgb(250, 248, 239);
            musicTrackBar.Location = new System.Drawing.Point(12, 313);
            musicTrackBar.Maximum = 100;
            musicTrackBar.Name = "musicTrackBar";
            musicTrackBar.Size = new System.Drawing.Size(305, 45);
            musicTrackBar.TabIndex = 6;
            musicTrackBar.Value = 30;
            musicTrackBar.Scroll += musicTrackBar_Scroll;
            // 
            // musicVolumeLabel
            // 
            musicVolumeLabel.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            musicVolumeLabel.ForeColor = System.Drawing.Color.FromArgb(187, 173, 160);
            musicVolumeLabel.Location = new System.Drawing.Point(0, 264);
            musicVolumeLabel.Name = "musicVolumeLabel";
            musicVolumeLabel.Size = new System.Drawing.Size(329, 35);
            musicVolumeLabel.TabIndex = 4;
            musicVolumeLabel.Text = "Громкость музыки";
            musicVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 248, 239);
            ClientSize = new System.Drawing.Size(329, 411);
            Controls.Add(musicTrackBar);
            Controls.Add(fieldSizeСomboBox);
            Controls.Add(musicVolumeLabel);
            Controls.Add(chooseFieldSizeLabel);
            Controls.Add(returnButton);
            Controls.Add(acceptButton);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Controls.Add(logoLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(345, 450);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(345, 450);
            Name = "OptionsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)musicTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label chooseFieldSizeLabel;
        private System.Windows.Forms.ComboBox fieldSizeСomboBox;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.Label musicVolumeLabel;
    }
}