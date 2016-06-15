using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalEngine
{
    interface IModalTone
    {

    }

    interface IHeptatonic : IModalTone
    {
        bool IsHemitonic { get; set; }
        bool[] ScaleTonesSignature { get; set; }
        string[] ScaleTonesNotes { get; set; }
    }

    class Ionian : IHeptatonic
    {
        public Ionian()
        {
            scaleTonesSignature = new bool[12];
            scaleTonesNotes = new string[7];
        }

        private bool isHemitonic;
        private bool[] scaleTonesSignature;
        private string[] scaleTonesNotes;

        public bool IsHemitonic
        {
            get
            {
                return isHemitonic;
            }

            set
            {
                isHemitonic = value;
            }
        }

        public bool[] ScaleTonesSignature
        {
            get
            {
                return scaleTonesSignature;
            }

            set
            {
                scaleTonesSignature = value;

            }
        }

        public string[] ScaleTonesNotes
        {
            get
            {
                return scaleTonesNotes;
            }

            set
            {
                scaleTonesNotes = value;
            }
        }
    }

    interface IDiatonic : IHeptatonic
    {

    }

    interface IJonian : IDiatonic
    {

    }

}
