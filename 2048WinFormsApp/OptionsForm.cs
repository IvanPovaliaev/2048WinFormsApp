using _2048.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib;

namespace _2048WinFormsApp
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            userNameTextBox.Text = StaticData.User is null ? "NoName" : StaticData.User.Name;
            if (StaticData.MainForm != null) returnButton.Text = "Вернуться";

            InitializeFieldSizeСomboBox();

            if (StaticData.BgMusicPlayer is null) PlayBgMusic();
            musicTrackBar.Value = StaticData.BgMusicPlayer.settings.volume;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (StaticData.User == null || StaticData.User.Name != userNameTextBox.Text)
                StaticData.User = new User(userNameTextBox.Text);

            StaticData.MapSize = (int)fieldSizeСomboBox.SelectedValue;
            
            Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (StaticData.MainForm is null)
                Application.Exit();

            Close();
        }
        private void InitializeFieldSizeСomboBox()
        {
            var fieldSizes = new Dictionary<int, string>()
            {
                [4] = "4 x 4",
                [5] = "5 x 5",
                [6] = "6 x 6"
            };

            fieldSizeСomboBox.DataSource = new BindingSource(fieldSizes, null);
            fieldSizeСomboBox.DisplayMember = "Value";
            fieldSizeСomboBox.ValueMember = "Key";
        }
        private void PlayBgMusic()
        {
            StaticData.BgMusicPlayer = new WindowsMediaPlayer();
            StaticData.BgMusicPlayer.URL = "2048-Bg.wav";
            StaticData.BgMusicPlayer.settings.setMode("loop", true);
            StaticData.BgMusicPlayer.controls.play();
            StaticData.BgMusicPlayer.settings.volume = 20;
        }

        private void musicTrackBar_Scroll(object sender, EventArgs e)
        {
            StaticData.BgMusicPlayer.settings.volume = musicTrackBar.Value;
        }
    }
}
