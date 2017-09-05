using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using osu__mp3player.FilePath;

namespace osu__mp3player.EventClass
{
    public class SongInfoValueUpdatedEventArgs : System.EventArgs
    {
        public string str
        {
            get;
            private set;
        }

        public SongInfoValueUpdatedEventArgs(string str)
        {
            this.str = str;
        }
    }

    public delegate void SongInfoValueUpdated(object sender, SongInfoValueUpdatedEventArgs e);
}
