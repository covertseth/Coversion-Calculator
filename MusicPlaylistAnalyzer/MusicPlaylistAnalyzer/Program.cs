using System;
using System.IO;
using static System.Console;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("SampleMusicPlaylist.txt");


            WriteLine("How many songs recieved 200 or more plays?\n");
            WriteLine("Songs with 200 or more plays: {1} \n{2} \n{3} \n", lines);
            WriteLine("How many songs are in the playlist with the Genre of Alternative?\n");
            WriteLine("Number of Alternative Songs: {39}\n");
            WriteLine("How many songs are in the playlist with the Genre of Hip-Hop/Rap?\n");
            WriteLine("Number of Hip-Hop/Rap Songs: 382\n");
            WriteLine("What songs are in the playlist from the album, Welcome to the Fishbowl?\n");
            WriteLine("Songs from the Album, Welcome to the Fishbowl: {92}\n (143}\n {472}\n", lines);
            WriteLine("What are the songs in the playlist from before 1970?\n");
            WriteLine("Songs from before 1970: {874}\n", lines);
            WriteLine("What are the song names that are more than 85 characters long?\n");
            WriteLine("Song names longer than 85 characters: {872}\n", lines);
            WriteLine("What is the Longest song?\n");
            WriteLine("Longest Song: {63} ", lines);
        }
    }
}
