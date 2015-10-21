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
    This class represents a turntable. Because a turntable is a turntable, we should talk to it
    in turntable language.
    */

    public class Turntable
    {
        private int _currentlyPlayingTrack;

        public void PutVinylOnPlatter()
        {
            Console.WriteLine("Turntable: Put vinyl on platter.");
        }

        public void StartSpinningPlatter()
        {
            Console.WriteLine("Turntable: Start spinning platter.");
        }

        public void PutNeedleOnVinyl()
        {
            _currentlyPlayingTrack = 1;
            Console.WriteLine("Turntable: Put needle on vinyl.");
        }

        public void SetNeedleToNextTrack()
        {
            _currentlyPlayingTrack++;
            Console.WriteLine("Turntable: Set needle to track {0}.", _currentlyPlayingTrack);
        }

        public void TakeNeedleOfVinyl()
        {
            Console.WriteLine("Turntable: Take needle of vinyl.");
        }

        public void StopSpinningPlatter()
        {
            Console.WriteLine("Turntable: Stop spinning platter.");
        }

        public void TakeVinylOffPlatter()
        {
            Console.WriteLine("Turntable: Take vinyl off platter.");
        }
    }
}
