using System;

namespace osu__mp3player.FilePath
{
    public class SongInfo
    {
        public string AudioFileName
        {
            get;
            private set;
        }
        public string Title
        {
            get;
            private set;
        }
        public string TitleUnicode
        {
            get;
            private set;
        }
        public string Artist
        {
            get;
            private set;
        }
        public string ArtistUnicode
        {
            get;
            private set;
        }
        public string Creator
        {
            get;
            private set;
        }
        public int BeatmapID
        {
            get;
            private set;
        }
        public string Directory
        {
            get;
            private set;
        }

        public SongInfo(String[] info)
        {
            AudioFileName = info[0];
            Title = info[1];
            TitleUnicode = info[2];
            Artist = info[3];
            ArtistUnicode = info[4];
            Creator = info[5];
            int tmpid = -1;
            Int32.TryParse(info[6], out tmpid);
            BeatmapID = tmpid;
            Directory = info[7];
            //Console.WriteLine(Artist + " - " + Title);
        }

        public override string ToString()
        {
            return Artist + " - " + Title;
        }
    }
}