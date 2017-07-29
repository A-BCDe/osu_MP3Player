using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu__mp3player.Path
{
    class Path
    {
        public string Directory
        {
            get;
            private set;
        }

        public Path()
        {
            this.Directory = Environment.CurrentDirectory;
        }

        public Path(string directory)
        {
            this.Directory = directory;
        }

        public void ChangePath()
        {
            using (System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                dialog.ShowNewFolderButton = false;
                dialog.SelectedPath = this.Directory;
                dialog.ShowDialog();
                this.Directory = dialog.SelectedPath;
            }
        }
    }
}
