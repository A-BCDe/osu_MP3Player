using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using osu__mp3player.FilePath;

namespace osu__mp3player.EventClass
{
    public class CurrentSongUpdatedEventArgs : EventArgs
    {
        public SongInfo CurrentSong
        {
            get;
            private set;
        }
        public CurrentSongUpdatedEventArgs(SongInfo currentSong)
        {
            CurrentSong = currentSong;
        }
    }
    public delegate void CurrentSongUpdated(object sender, CurrentSongUpdatedEventArgs e);
}
