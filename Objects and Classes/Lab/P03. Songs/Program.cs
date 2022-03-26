using System;
using System.Collections.Generic;

namespace P03._Songs
{
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
    internal class Program
    {
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songsList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split('_', StringSplitOptions.RemoveEmptyEntries);

                string typeList = commandArgs[0];
                string name = commandArgs[1];
                string time = commandArgs[2];

                Song newSong = new Song() {TypeList = typeList, Name = name, Time = time};

                songsList.Add(newSong);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> chosenList = songsList.FindAll(song => song.TypeList == command);

                foreach (Song song in chosenList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
