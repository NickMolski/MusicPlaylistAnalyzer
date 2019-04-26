using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Music Playlist Analyzer");
            Console.WriteLine("");
            Console.WriteLine("What is the file name? (no ext.): ");
            Console.WriteLine("");
            string input = Console.ReadLine();
            string filename = input + ".txt";
            Console.WriteLine("");

            int fileLength = File.ReadLines(filename).Count();
            Data[] values = new Data[fileLength - 1];

            StreamReader streamReader = new StreamReader(filename);
            string currentLine;
            bool hasSeenFirstLine = false;
            int i = 0;
            while ((currentLine = streamReader.ReadLine()) != null)
            {
                if (!hasSeenFirstLine)
                {
                    hasSeenFirstLine = true;
                    continue;
                }

                Object[] readValues = currentLine.Split('\t');

                values[i] = new Data(readValues[0].ToString(), readValues[1].ToString(), readValues[2].ToString(), readValues[3].ToString(), Convert.ToInt32(readValues[4]), Convert.ToInt32(readValues[5]), Convert.ToInt32(readValues[6]), Convert.ToInt32(readValues[7]));
                i++;
            }
            //values.ToList().ForEach(x => Console.WriteLine(x.name));

            // How many songs received 200 or more plays?
            // How many songs are in the playlist with the Genre of “Alternative”?
            // How many songs are in the playlist with the Genre of “Hip - Hop / Rap”?
            // What songs are in the playlist from the album “Welcome to the Fishbowl?”
            // What are the songs in the playlist from before 1970 ?
            // What are the song names that are more than 85 characters long?
            // What is the longest song ? (longest in Time)





            Console.WriteLine("Songs that received 200 or more plays:");
            var playValues = from value in values where value.plays > 200 select value;
            foreach (var play in playValues)
                Console.WriteLine("Name: " + play.name + ", " + "Artist: " + play.artist + ", " + "Album: " + play.album + ", " + "Genre: " + play.genre + ", " + "Size: " + play.size + ", " + "Time: " + play.time + ", " + "Year: " + play.year + ", " + "Plays: " + play.plays);
            Console.WriteLine("");

            int altCount = 0;
            var altValues = from value in values where value.genre == "Alternative" select value;
            foreach (var alt in altValues)
                altCount++;
            Console.WriteLine("Number of Alternative songs: " + altCount);

            Console.WriteLine("");

            int hipCount = 0;
            var hipValues = from value in values where value.genre == "Hip-Hop/Rap" select value;
            foreach (var hip in hipValues)
                hipCount++;
            Console.WriteLine("Number of Hip-Hop/Rap songs: " + hipCount);

            Console.WriteLine("");

            Console.WriteLine("Songs from the album Welcome to the Fishbowl:");
            var fishValues = from value in values where value.album == "Welcome to the Fishbowl" select value;
            foreach (var fish in fishValues)
                Console.WriteLine("Name: " + fish.name + ", " + "Artist: " + fish.artist + ", " + "Album: " + fish.album + ", " + "Genre: " + fish.genre + ", " + "Size: " + fish.size + ", " + "Time: " + fish.time + ", " + "Year: " + fish.year + ", " + "Plays: " + fish.plays);

            Console.WriteLine("");

            Console.WriteLine("Songs from before 1970:");
            var beforeSevSongs = from value in values where value.year < 1970 select value;
            foreach (var beforeSev in beforeSevSongs)
                Console.WriteLine("Name: " + beforeSev.name + ", " + "Artist: " + beforeSev.artist + ", " + "Album: " + beforeSev.album + ", " + "Genre: " + beforeSev.genre + ", " + "Size: " + beforeSev.size + ", " + "Time: " + beforeSev.time + ", " + "Year: " + beforeSev.year + ", " + "Plays: " + beforeSev.plays);

            Console.WriteLine("");

            Console.WriteLine("Song names longer than 85 characters:");
            var songsLonger = from value in values where value.name.Length > 85 select value;
            foreach (var songLonger in songsLonger)
                Console.WriteLine("Name: " + songLonger.name + ", " + "Artist: " + songLonger.artist + ", " + "Album: " + songLonger.album + ", " + "Genre: " + songLonger.genre + ", " + "Size: " + songLonger.size + ", " + "Time: " + songLonger.time + ", " + "Year: " + songLonger.year + ", " + "Plays: " + songLonger.plays);

            Console.WriteLine("");

            Console.WriteLine("Longest song:");
            int longTime = 0;
            var longestSongs = from value in values where value.time > 0 select value;
            foreach (var longestSong in longestSongs)
                if (longestSong.time > longTime)
                {           
                    longTime = longestSong.time;
                }
            foreach (var longestSong in longestSongs)
                if (longestSong.time == longTime)
                {
                    Console.WriteLine("Name: " + longestSong.name + ", " + "Artist: " + longestSong.artist + ", " + "Album: " + longestSong.album + ", " + "Genre: " + longestSong.genre + ", " + "Size: " + longestSong.size + ", " + "Time: " + longestSong.time + ", " + "Year: " + longestSong.year + ", " + "Plays: " + longestSong.plays);
                }


            var hipValuez = from value in values where value.genre == "Hip-Hop/Rap" select value;
            foreach (var hip in hipValuez)
                Console.WriteLine("Name: " + hip.name + ", " + "Artist: " + hip.artist + ", " + "Album: " + hip.album + ", " + "Genre: " + hip.genre + ", " + "Size: " + hip.size + ", " + "Time: " + hip.time + ", " + "Year: " + hip.year + ", " + "Plays: " + hip.plays);






            //What are the songs in the playlist from before 1970 ?
            //Song names longer than 85 characters:








            //Number of Alternative songs: 




            //Console.WriteLine("Period: " + firstYear + "-" + lastYear + " (" + range + " years)");

            Console.ReadLine();
        }
    }
}
