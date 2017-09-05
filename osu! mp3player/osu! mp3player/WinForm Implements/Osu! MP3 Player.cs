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
        public SongInfo CurrentSong
        {
            get;
            private set;
        }

        public Osu__MP3_Player()
        {
            fileInfo = new FileInfo();
            mp3Player = new MP3Player(fileInfo.SongsInfo);
            CurrentSong = mp3Player.Open(0);
            findingString = "";
            InitializeComponent();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            CurrentSong = mp3Player.Open(-1);
            mp3Player.Play();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            CurrentSong = mp3Player.Open(0);
            mp3Player.Play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            mp3Player.Pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mp3Player.Stop();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            CurrentSong = mp3Player.Open(1);
            mp3Player.Play();
        }

        private void FindSongButton_Click(object sender, EventArgs e)
        {
            findingSongForm = new FindingSongForm(mp3Player._findingSongInfos);
            findingSongForm.songInfoValueUpdated += new SongInfoValueUpdated(findingSongForm_SongInfoValueUpdated);
            findingSongForm.findingSongInfoValueUpdated += new FindingSongInfoValueUpdated(findingSongForm_findingSongInfoValueUpdated);
            findingSongForm.findsongListBoxSelectedIndexChanged += new findSongListBoxSelectedIndexChanged(findingSongForm_findSongListBoxSelectedIndexChanged);
            findingSongForm.Show();
        }

        private void findingSongForm_findSongListBoxSelectedIndexChanged(object sender, findSongListBoxSelectedIndexChangedEventArgs e)
        {
            mp3Player.GetSongInfoandPlay(e.songinfo);
        }

        private void findingSongForm_findingSongInfoValueUpdated(object sender, FindingSongInfoValueUpdatedEventArgs e)
        {
            mp3Player.UpdateFindingSongInfos(e.FindingSongInfos);
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

        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            mp3Player.SetVolume(VolumeTrackBar.Value);
        }

        private void MuteBox_CheckedChanged(object sender, EventArgs e)
        {
            mp3Player.Mute();
        }
    }
}
