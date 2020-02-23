using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    3b) Create the following program by using C# OOP Composition technique. An Album contains 3 songs. Create the class "Album" and the class "Song". Create the an Album object call "nirvanaAlbum" 
    and use composition to make sure that the Album object contain the 3 Song objects (song1 , song2 and song3).
    The following are properties for each of the object.
    Album Object "nirvanaAlbum" Album Name = "Nevermind" Album Studio = "Geffen" Year Release = 1991
    Song Object "Song1"
    Song Name =  "On A Plain" Song Singer =  "Nirvana" Song Length = 3.30
    Song Object "Song2"
    Song Name =  "Endless, Nameless" Song Singer =  "Nirvana feat Pearl Jam" Song Length = 5.00
    Song Object "Song3"
    Song Name =  "Lounge Act" Song Singer =  "Nirvana" Song Length = 4.10
    Finally, output all the album info along with all of the songs to the screen.   < 5 pts >

*/

namespace Week5_HW3b
{
    public class Song
    {
        public Song(string songName, string singerName, double songLength)
        {
            MySongName = songName;
            MySingerName = singerName;
            MySongLength = songLength;
        }
        public string MySongName { get; set; }
        public string MySingerName { get; set; }
        public double MySongLength { get; set; }
        public override string ToString()
        {
            return "\n" + "\t" + "Song Name: " + MySongName + "\n" + "\t" + "SingerName: " + MySingerName + "\t" + "\n" + "\t" + "Song Length: " + MySongLength + " Song 1SongName mins";
        }
    }

}
