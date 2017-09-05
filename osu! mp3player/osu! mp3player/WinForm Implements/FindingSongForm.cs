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
    public partial class FindingSongForm : Form
    {
        public event SongInfoValueUpdated songInfoValueUpdated;
        public event FindingSongInfoValueUpdated findingSongInfoValueUpdated;
        public event findSongListBoxSelectedIndexChanged findsongListBoxSelectedIndexChanged;
        private List<SongInfo> _SongInfos;
        private List<SongInfo> _findingSongInfos;
        public FindingSongForm(List<SongInfo> SongInfos) 
        {
            NotImplementedForm notImplementedForm = new NotImplementedForm();
            notImplementedForm.ShowDialog();
            //return;
            //_SongInfos = SongInfos;
            //InitializeComponent();
        }

        private void textTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textTextBox.Text;
            SongInfoValueUpdatedEventArgs songInfoValueUpdatedEventArgs = new SongInfoValueUpdatedEventArgs(str);
            FindingSongInfoValueUpdatedEventArgs findingSongInfoValueUpdatedEventArgs = new FindingSongInfoValueUpdatedEventArgs(_findingSongInfos);

            FindSong(textTextBox.Text);
            findSongListBox.MultiColumn = true;
            findSongListBox.SelectionMode = SelectionMode.One;
            foreach (SongInfo songinfo in _findingSongInfos)
            {
                findSongListBox.Items.Add(songinfo);
            }
            findSongListBox.Update();

            songInfoValueUpdated(this, songInfoValueUpdatedEventArgs);
            findingSongInfoValueUpdated(this, findingSongInfoValueUpdatedEventArgs);
        }

        public void FindSong(string str)
        {
            if (str == "")
            {
                _findingSongInfos = _SongInfos;
                findSongListBox.Items.Clear();
            }
            else
            {
                _findingSongInfos = new List<SongInfo>(0);
                findSongListBox.Items.Clear();
                Parallel.ForEach(_SongInfos, (info) =>
                {
                    if (
                        info.Title.Contains(str)
                        || info.TitleUnicode.Contains(str)
                        || info.Creator.Contains(str)
                        || info.Artist.Contains(str)
                        )
                    {
                        _findingSongInfos.Add(info);
                    }
                });
                findSongListBox.Update();
            }
        }

        private void findSongListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_findingSongInfos == null)
            {
                return;
            }
            SongInfo songinfo = findSongListBox.SelectedItem as SongInfo;
            findSongListBoxSelectedIndexChangedEventArgs findsongListBoxSelectedIndexChangedEventArgs = new findSongListBoxSelectedIndexChangedEventArgs(songinfo);
            findsongListBoxSelectedIndexChanged(this, findsongListBoxSelectedIndexChangedEventArgs);
        }
    }
}
