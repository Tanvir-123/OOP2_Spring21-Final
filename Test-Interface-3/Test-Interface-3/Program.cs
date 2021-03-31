using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile("Blank Space", "Taylor swift", 2014, 450);
            MusicFile m2 = new MusicFile("Tu Jaane Na", "Atif Aslam", 2012, 974);
            Phone phone = new MusicPlayer("Music Player", m1);
            phone.addMusic(m1, m2);
            phone.play(true);
            phone.playNext();

            Console.WriteLine();
            Console.WriteLine();

            Phone radio = new RadioPlayer("Radio Player", 55.02);
            radio.play(true);
            radio.playNext();
        }
    }
}