/*
    Author: Stan Wijckmans
    Creation date: 13/10/2015
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi all! I'm Vladimir and I'm gonna play a CD!");
            
            // This is my CD player!
            CDPlayer cdPlayer;

            // This time it's a normal cd player, but actually I don't care because I can
            // work with anything that talks "cd player language".
            cdPlayer = new NormalCDPlayer();

            // Let's start playing a cd.
            cdPlayer.InsertCD();
            cdPlayer.StartPlayingCD();

            // Now we're skipping a track.
            cdPlayer.PlayNextTrack();

            // And we stop playing the cd.
            cdPlayer.StopPlayingCD();
            cdPlayer.EjectCD();


            // Now we're going to play a vinyl. I don't know how to do that, but I can use
            // my adapter to talk "cd player language" to the turntable. Actually I don't
            // even know I'm using a turntable!
            Turntable turntable = new Turntable();
            TurntableAdapter adapter = new TurntableAdapter(turntable);
            cdPlayer = adapter;

            // Let's start playing a "cd"
            cdPlayer.InsertCD();
            cdPlayer.StartPlayingCD();

            // Now we're skipping a track.
            cdPlayer.PlayNextTrack();

            // And we stop playing the "cd".
            cdPlayer.StopPlayingCD();
            cdPlayer.EjectCD();

            Console.WriteLine("This was Vladimir's music session, thanks for listening!");
            Console.Read();
        }
    }
}
