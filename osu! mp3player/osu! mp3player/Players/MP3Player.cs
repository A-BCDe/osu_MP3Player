using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using osu__mp3player.FilePath;
using System.Windows.Forms;
using System.ComponentModel;

/// <summary>
/// thanks to https://www.codeproject.com/Articles/63094/Simple-MCI-Player
/// </summary>

namespace osu__mp3player.Players
{
    public class MP3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);
        [DllImport("winmm.dll")]
        public static extern int mciGetErrorString(int errCode, StringBuilder errMsg, int buflen);
        
        public List<SongInfo> _SongInfos
        {
            get;
            private set;
        }
        private StringBuilder msg;
        private StringBuilder returnData;
        private long error;
        private int ListSize;
        private int cur = 0;
        private bool paused;
        private int volume;
        private bool muted;


        public MP3Player(List<SongInfo> songInfos)
        {
            GetFiles(songInfos);
            ShuffleSongInfo();
            paused = false;
            volume = 100;
            muted = false;
            msg = new StringBuilder(128);
            returnData = new StringBuilder(128);
        }

        public void GetFiles(List<SongInfo> songInfos)
        {
            _SongInfos = songInfos;
            ListSize = songInfos.Count;
            if (ListSize == 0)
            {
                throw new Exception(@"No .osu File! Check if the folder is osu! songs folder.
If not, check if the songinfo.info is empty.");
            }
        }

        private void ShuffleSongInfo()
        {
            Random rand = new Random();
            int n = _SongInfos.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                SongInfo value = _SongInfos[k];
                _SongInfos[k] = _SongInfos[n];
                _SongInfos[n] = value;
            }
        }

        private void curChanger(short condition)
        {
            cur += condition;
            cur = cur % ListSize;
            if (cur == -1)
            {
                cur = ListSize - 1;
            }
        }

        public void Close()
        {
            string command = "close MyMP3";
            mciSendString(command, null, 0, 0);
        }

        public SongInfo Open(short condition)
        {
            Close();
            curChanger(condition);
            string command = "open \"" + _SongInfos[cur].Directory + "\" type MPEGVideo alias MyMP3";
            error = mciSendString(command, null, 0, 0);
            if (error != 0)
            {
                command= "open \"" + _SongInfos[cur].Directory + "\" alias MyMP3";
                error = mciSendString(command, null, 0, 0);
                //if (error != 0)
                //{
                //    throw new Exception("Cannot open file!");
                //}
            }
            return _SongInfos[cur];
        }

        public void Play()
        {
            string command = "play MyMP3";
            error = mciSendString(command, null, 0, 0);
            //if (error != 0)
            //{
            //    Close();
            //    throw new Exception("Cannot play file!");
            //}
            
        }

        public void Pause()
        {
            if (paused)
            {
                Resume();
                paused = false;
            }
            else if (IsPlaying())
            {
                string command = "pause MyMP3";
                error = mciSendString(command, null, 0, 0);
                paused = true;
            }
        }

        public void Stop()
        {
            string command = "stop MyMP3";
            mciSendString(command, null, 0, 0);
            paused = false;
            Close();
        }

        public void Resume()
        {
            string command = "resume MyMP3";
            error = mciSendString(command, null, 0, 0);
        }

        public bool IsPlaying()
        {
            string command = "status MyMP3 mode";
            error = mciSendString(command, returnData, 128, 0);
            if (returnData.Length == 7 && returnData.ToString().Substring(0, 7) == "playing")
            {

                return true;
            }
            return false;

        }

        public int GetCurrentMillisecond()
        {
            string command = "status MediaFile position";
            error = mciSendString(command, returnData, returnData.Capacity, 0);
            return int.Parse(returnData.ToString());
        }

        public void SetPosition(int miliseconds)
        {
            string command;
            if (IsPlaying())
            {
                command = "play MyMP3 from " + miliseconds.ToString();
                error = mciSendString(command, null, 0, 0);
            }
            else
            {
                command = "seek MyMP3 to " + miliseconds.ToString();
                error = mciSendString(command, null, 0, 0);
            }
        }

        public int GetSongLength()
        {
            if (IsPlaying())
            {
                string command = "status MyMP3 length";
                error = mciSendString(command, returnData, returnData.Capacity, 0);
                return int.Parse(returnData.ToString());
            }
            return 0;
        }

        public void SetVolume(int volume)
        {
            if (volume >= 0 && volume <= 1000 && !muted)
            {
                this.volume = volume;
                string command = "setaudio MyMP3 volume to " + volume.ToString();
                error = mciSendString(command, null, 0, 0);
            }
        }

        public void Mute()
        {
            if (muted)
            {
                muted = false;
                SetVolume(volume);
            }
            else
            {
                muted = true;
                SetVolume(0);
            }
        }

        public void ResetCur()
        {
            cur = 0;
        }
        /*
        public void UpdateFindingSongInfos(List<SongInfo> songinfos)
        {
            _SongInfos = songinfos;
        }

        public void GetSongInfoandPlay(SongInfo songinfo)
        {
            cur = _SongInfos.IndexOf(songinfo);
            Open(0);
            Play();
        }
        */
    }
}
