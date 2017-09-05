using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using osu__mp3player.FilePath;

namespace osu__mp3player.EventClass
{
    public class findSongListBoxSelectedIndexChangedEventArgs : System.EventArgs
    {
        public SongInfo songinfo
        {
            get;
            private set;
        }

        public findSongListBoxSelectedIndexChangedEventArgs(SongInfo songinfo)
        {
            this.songinfo = songinfo;
        }
    }

    public delegate void findSongListBoxSelectedIndexChanged(object sender, findSongListBoxSelectedIndexChangedEventArgs e);
}
