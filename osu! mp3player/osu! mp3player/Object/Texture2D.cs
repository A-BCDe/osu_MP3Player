using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu__mp3player.Object
{
    class Texture2D
    {
        public int ID
        {
            get;
            private set;
        }
        public int Width
        {
            get;
            private set;
        }
        public int Height
        {
            get;
            private set;
        }

        public Texture2D(int id, int width, int height)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
        }
    }
}
