using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using osu__mp3player.Players;
using osu__mp3player.FilePath;
using osu__mp3player.EventClass;

namespace osu__mp3player.WinForm_Implements
{
    public partial class Osu__MP3_Player : Form
    {
        private MP3Player mp3Player;
        private FileInfo fileInfo;
        private FindingSongForm findingSongForm;
        private string findingString;
        private bool allowClose;
        public SongInfo CurrentSong
        {
            get;
            private set;
        }
        ToolTip mapInfoToolTip;

        public Osu__MP3_Player()
        {
            fileInfo = new FileInfo();
            mp3Player = new MP3Player(fileInfo.SongsInfo);
            findingString = "";
            //mapInfoToolTip = new ToolTip();
            //mapInfoToolTip.AutoPopDelay = 5000;
            //mapInfoToolTip.InitialDelay = 500;
            //mapInfoToolTip.SetToolTip(this.mapInfo, "hi");
            InitializeComponent();
            
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            CurrentSong = mp3Player.Open(-1);
            UpdateTitle();
            UpdateSongLength();
            mp3Player.Play();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            CurrentSong = mp3Player.Open(0);
            UpdateTitle();
            UpdateSongLength();
            mp3Player.Play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            mp3Player.Pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mp3Player.Stop();
            ResetTimeLabel();
            EraseTitle();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            CurrentSong = mp3Player.Open(1);
            UpdateTitle();
            UpdateSongLength();
            mp3Player.Play();
        }

        private void FindSongButton_Click(object sender, EventArgs e)
        {
            findingSongForm = new FindingSongForm(mp3Player._SongInfos);
            // findingSongForm.songInfoValueUpdated += new SongInfoValueUpdated(findingSongForm_SongInfoValueUpdated);
            // findingSongForm.findingSongInfoValueUpdated += new FindingSongInfoValueUpdated(findingSongForm_findingSongInfoValueUpdated);
            // findingSongForm.findsongListBoxSelectedIndexChanged += new findSongListBoxSelectedIndexChanged(findingSongForm_findSongListBoxSelectedIndexChanged);
            findingSongForm.Show();
        }

        private void findingSongForm_findSongListBoxSelectedIndexChanged(object sender, findSongListBoxSelectedIndexChangedEventArgs e)
        {
            // mp3Player.GetSongInfoandPlay(e.songinfo);
        }

        private void findingSongForm_findingSongInfoValueUpdated(object sender, FindingSongInfoValueUpdatedEventArgs e)
        {
            // mp3Player.UpdateFindingSongInfos(e.FindingSongInfos);
        }

        private void findingSongForm_SongInfoValueUpdated(object sender, SongInfoValueUpdatedEventArgs e)
        {
            findingString = e.str;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            NotImplementedForm notImplementedForm = new NotImplementedForm();
            notImplementedForm.ShowDialog();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            allowClose = false;
            this.Hide();
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            mp3Player.SetVolume(VolumeTrackBar.Value);
        }

        private void MuteBox_CheckedChanged(object sender, EventArgs e)
        {
            mp3Player.Mute(VolumeTrackBar.Value);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
                value = false;
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!this.allowClose)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.allowClose = true;
            this.Show();
        }

        private void MapInfo_MouseHover(object sender, System.EventArgs e)
        {
            
        }

        private void UpdateTitle()
        {
            TitleTextLabel.Text = CurrentSong.Title;
            TitleTextUnicodeLabel.Text = CurrentSong.TitleUnicode;
        }

        private void UpdateSongLength()
        {
            int lengthMillisecond = mp3Player.GetSongLength();
            SongTrackBar.Maximum = lengthMillisecond;
            TimeLabel.Text = (lengthMillisecond / 60000).ToString("00") + ":" + ((lengthMillisecond % 60000) / 1000).ToString("00");
        }

        private void ResetTimeLabel()
        {
            TimeLabel.Text = "00:00 / 00:00";
        }

        private void EraseTitle()
        {
            TitleTextUnicodeLabel.Text = "";
            TitleTextLabel.Text = "";
        }
    }
}
