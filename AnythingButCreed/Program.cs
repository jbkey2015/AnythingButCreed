using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            List<Song> allSongs = new List<Song>(12);

            Song bohemianRhapsody = new Song("Queen", "Bohemian Rhapsody");
            Song creedSucks = new Song("Creed", "Creed Sucks");
            Song poison = new Song("Alice Cooper", "Poison");
            Song pourSomeSugarOnMe = new Song("Def Leppard", "Pour Some Sugar On Me");
            Song creedStillSucks = new Song("Creed", "Creed Still Sucks");
            Song hotForTeacher = new Song("Van Halen", "Hot For Teacher");
            Song friendsInLowPlaces = new Song("Garth Brooks", "Friends In Low Places");
            Song pony = new Song("Ginuwine", "Pony");
            Song tiredOfLookingUpSongs = new Song("No One Cares", "Tired Of Looking Up Songs");
            Song creedSucksRemix = new Song("Creed", "Creed Sucks Remix");
            Song numberEleven = new Song("Eleven", "Number Eleven");
            Song numberTwelve = new Song("Twelve", "Number Twelve");

            allSongs.Add(bohemianRhapsody);
            allSongs.Add(creedSucks);
            allSongs.Add(poison);
            allSongs.Add(pourSomeSugarOnMe);
            allSongs.Add(creedStillSucks);
            allSongs.Add(hotForTeacher);
            allSongs.Add(friendsInLowPlaces);
            allSongs.Add(pony);
            allSongs.Add(tiredOfLookingUpSongs);
            allSongs.Add(creedSucksRemix);
            allSongs.Add(numberEleven);
            allSongs.Add(numberTwelve);

            var filterSongs = allSongs.Where(x => x.Artist != "Creed");

            goodSongs.AddRange(filterSongs);

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");
            }
        }
    }
}
