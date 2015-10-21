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

    /*
    This class represents a normal cd player. Because a cd player is... just a cd player,
    we can obviously talk to the cd player like we would usually talk to a cd player.
    */

    public class NormalCDPlayer : CDPlayer
    {
        private int _currentlyPlayingTrack;

        public void InsertCD()
        {
            Console.WriteLine("CD Player: Inserting CD into player.");
        }

        public void StartPlayingCD()
        {
            _currentlyPlayingTrack = 1;
            Console.WriteLine("CD Player: Start playing first track.");
        }

        public void PlayNextTrack()
        {
            _currentlyPlayingTrack++;
            Console.WriteLine("CD Player: Start playing track {0}.", _currentlyPlayingTrack);
        }

        public void StopPlayingCD()
        {
            Console.WriteLine("CD Player: Stop playing CD.");
        }

        public void EjectCD()
        {
            Console.WriteLine("CD Player: Ejecting CD.");
        }
    }       
}
