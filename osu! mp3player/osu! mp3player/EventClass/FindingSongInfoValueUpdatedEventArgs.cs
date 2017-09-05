using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using osu__mp3player.FilePath;

namespace osu__mp3player.EventClass
{
    public class FindingSongInfoValueUpdatedEventArgs : System.EventArgs
    {
        public List<SongInfo> FindingSongInfos
        {
            get;
            private set;
        }

        public FindingSongInfoValueUpdatedEventArgs(List<SongInfo> findingSongInfos)
        {
            FindingSongInfos = findingSongInfos;
        }
    }

    public delegate void FindingSongInfoValueUpdated(object sender, FindingSongInfoValueUpdatedEventArgs e);
}
