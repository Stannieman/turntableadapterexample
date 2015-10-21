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
    This interface defines the language used to talk to cd players.
    */

    public interface CDPlayer
    {
        void InsertCD();

        void StartPlayingCD();

        void PlayNextTrack();

        void StopPlayingCD();

        void EjectCD();
    }
}
