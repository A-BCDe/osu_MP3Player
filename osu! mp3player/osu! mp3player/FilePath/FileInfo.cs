using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace osu__mp3player.FilePath
{
    class FileInfo
    {
        public List<SongInfo> SongsInfo;
        private string info = "songinfo.info";
        private string currentVersion = "0.9";
        private string boundary = "#####";

        public string RootDir
        {
            get;
            private set;
        }

        /// <summary>
        /// songinfo.info
        /// 
        /// osu!MusicPlayer (currentVersion)
        /// RootDir
        /// 
        /// #####
        /// 
        /// songinfos
        /// 
        /// </summary>

        public FileInfo()
        {
            SongsInfo = new List<SongInfo>(0);
            try
            {
                using (StreamReader sr = new StreamReader(info, Encoding.UTF8, true))
                {
                    string currentVersion = sr.ReadLine();

                    while ((RootDir = sr.ReadLine()) == "") ;
                    while (sr.ReadLine() != boundary || sr.EndOfStream) ;
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ReadSongInfoFromsonginfoFile(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                using (FolderBrowserDialog fd = new FolderBrowserDialog())
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        string path = fd.SelectedPath;

                        try
                        {
                            using (FileStream f = new FileStream(info, FileMode.CreateNew))
                            {
                                AddText(f, "osu!MusicPlayer " + currentVersion + "\r\n\r\n");
                                AddText(f, path + "\r\n\r\n");
                                RootDir = path;

                                AddText(f, boundary + "\r\n");

                                ReadSongInfoFromosuFile(f);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Why does this happen? " + ex.StackTrace, ex);
                        }
                    }
                }
            }
        }

        private void AddText(FileStream f, string str)
        {
            byte[] info = Encoding.UTF8.GetBytes(str);
            f.Write(info, 0, info.Length);
        }

        /// <summary>
        /// will this be implemented
        /// </summary>

        public void ChangePath()
        {
            using (System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                dialog.ShowNewFolderButton = false;
                dialog.SelectedPath = this.RootDir;
                dialog.ShowDialog();
                this.RootDir = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// songinfos
        /// each line is blank or has a form of
        /// ||AudioFileName||Title||Title(Unicode)||Artist||Artist(Unicode)||Creator||BeatmapSetID||Directory||
        /// </summary>

        private void ReadSongInfoFromsonginfoFile(String line)
        {
            String[] Info = line.Split(new String[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
            SongsInfo.Add(new SongInfo(Info));
        }
        private void WriteSongInfoTosonginfoFile(FileStream f, String[] Info)
        {
            for(int i = 0; i < 8; i++)
            {
                AddText(f, "||" + Info[i]);
            }
            AddText(f, "||\r\n");
        }

        private void ReadSongInfoFromosuFile(FileStream f)
        {
            string[] dirs = Directory.GetFiles(RootDir, @"*.osu", SearchOption.AllDirectories);

            foreach(string dir in dirs)
            {
                String[] Info = new String[8];
                 using (StreamReader sr = new StreamReader(dir, Encoding.UTF8, true))
                 {
                     String line;
                     while ((line = sr.ReadLine()) != null)
                     {
                         string audiofilename = @"AudioFilename: ";
                         if (line.Contains(audiofilename))
                         {
                             Info[0] = line.Substring(audiofilename.Length);
                             int index = dir.LastIndexOf('\\');
                             if (index >= 0)
                             {
                                 string tmpdir = dir;
                                 Info[7] = tmpdir.Substring(0, index) + '\\' + Info[0];
                             }
                             continue;
                         }
                         string title = "Title:";
                         if (line.Contains(title))
                         {
                             Info[1] = line.Substring(title.Length);
                             continue;
                         }
                         string titleunicode = "TitleUnicode:";
                         if (line.Contains(titleunicode))
                         {
                             Info[2] = line.Substring(titleunicode.Length);
                             continue;
                         }
                         string artist = "Artist:";
                         if (line.Contains(artist))
                         {
                             Info[3] = line.Substring(artist.Length);
                             continue;
                         }
                         string artistunicode = "ArtistUnicode:";
                         if (line.Contains(artistunicode))
                         {
                             Info[4] = line.Substring(artistunicode.Length);
                             continue;
                         }
                         string creator = "Creator:";
                         if (line.Contains(creator))
                         {
                             Info[5] = line.Substring(creator.Length);
                             continue;
                         }
                         string beatmapid = "BeatmapID:";
                         if (line.Contains(beatmapid))
                         {
                             Info[6] = line.Substring(beatmapid.Length);
                            if (Info[0] == "" || Info[0] == null)
                            {
                                Info[0] = "Unknown";
                            }
                            if (Info[1] == "" || Info[1] == null)
                            {
                                Info[1] = "Unknown";
                            }
                            if (Info[2] == "" || Info[2] == null)
                            {
                                Info[2] = Info[1];
                            }
                            if (Info[3] == "" || Info[3] == null)
                            {
                                Info[3] = "Unknown";
                            }
                            if (Info[4] == "" || Info[4] == null)
                            {
                                Info[4] = Info[3];
                            }
                            if (Info[5] == "" || Info[5] == null)
                            {
                                Info[5] = "Unknown";
                            }
                            if (Info[6] == "" || Info[6] == null)
                            {
                                Info[6] = "-1";
                            }
                            if (Info[7] == "" || Info[7] == null)
                            {
                                Info[7] = "Unknown";
                            }
                            break;
                         }
                     }
                    if (Info[0] == "" || Info[0] == null)
                    {
                        Info[0] = "Unknown";
                    }
                    if (Info[1] == "" || Info[1] == null)
                    {
                        Info[1] = "Unknown";
                    }
                    if (Info[2] == "" || Info[2] == null)
                    {
                        Info[2] = Info[1];
                    }
                    if (Info[3] == "" || Info[3] == null)
                    {
                        Info[3] = "Unknown";
                    }
                    if (Info[4] == "" || Info[4] == null)
                    {
                        Info[4] = Info[3];
                    }
                    if (Info[5] == "" || Info[5] == null)
                    {
                        Info[5] = "Unknown";
                    }
                    if (Info[6] == "" || Info[6] == null)
                    {
                        Info[6] = "-1";
                    }
                    if (Info[7] == "" || Info[7] == null)
                    {
                        Info[7] = "Unknown";
                    }
                }
                 SongsInfo.Add(new SongInfo(Info));
                 WriteSongInfoTosonginfoFile(f, Info);
            }
        }
    }
}
