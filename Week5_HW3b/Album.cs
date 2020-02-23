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
    public class Album
    {
        public Album(string albumName, string albumStudio, int yearRelease, Song song1, Song song2, Song song3)
        {
            MyAlbumName = albumName;
            MyAlbumStudio = albumStudio;
            MyYearRelease = yearRelease;
            ThisSong1 = song1;
            ThisSong2 = song2;
            ThisSong3 = song3;
        }
        public string MyAlbumName { get; set; }
        public string MyAlbumStudio { get; set; }
        public double MyYearRelease { get; set; }
        public Song ThisSong1 { get; set; }
        public Song ThisSong2 { get; set; }
        public Song ThisSong3 { get; set; }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "\n" + "Album Name " + MyAlbumName + "\n" + "Album Release by:" + MyAlbumStudio + "\n" + "Album Release: " + MyYearRelease + "\n" + "\n" + "\t" + "Song 1 Info" + ThisSong1 + "\n" + "\n" + "\t" + "Song 2 Info" + ThisSong2 + "\n" + "\n" + "\t" + "Song 3 Info" + ThisSong3;
        }
    }
}
