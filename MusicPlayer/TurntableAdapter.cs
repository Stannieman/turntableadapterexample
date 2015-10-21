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
    If you want to use a turntable but you can only speak cd player language, you can
    use this adapter. It will translate the cd player to turntable language for the turntable.
    */

    public class TurntableAdapter : CDPlayer
    {
        private Turntable _turnTable;

        public TurntableAdapter(Turntable turnTable)
        {
            _turnTable = turnTable;
        }

        public void InsertCD()
        {
            _turnTable.PutVinylOnPlatter();
        }

        public void StartPlayingCD()
        {
            _turnTable.StartSpinningPlatter();
            _turnTable.PutNeedleOnVinyl();
        }

        public void PlayNextTrack()
        {
            _turnTable.SetNeedleToNextTrack();
        }

        public void StopPlayingCD()
        {
            _turnTable.TakeNeedleOfVinyl();
            _turnTable.StopSpinningPlatter();
        }

        public void EjectCD()
        {
            _turnTable.TakeVinylOffPlatter();
        }
    }
}
