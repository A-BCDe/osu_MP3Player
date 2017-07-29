using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using osu__mp3player.Object;

namespace osu__mp3player
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerWindow window = new PlayerWindow(640, 480);
            window.Run();
        }
    }
}
