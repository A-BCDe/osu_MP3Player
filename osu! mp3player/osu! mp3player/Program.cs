using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using osu__mp3player.Object;
using osu__mp3player.WinForm_Implements;
using System.Windows.Forms;

/// <summary>
/// As you see, EventClass is very dirty, but don't mind that now.
/// </summary>

namespace osu__mp3player
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Osu__MP3_Player form = new Osu__MP3_Player();
            form.ShowDialog();
        }
    }
}
