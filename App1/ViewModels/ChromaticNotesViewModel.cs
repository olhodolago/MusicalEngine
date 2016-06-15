using App1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Commands;
using App1.Controls;
using Windows.UI.Xaml;

namespace App1.ViewModel
{
    class ChromaticNotesViewModel : INotifyPropertyChanged
    {
        ChromaticNotes cNotesObject;

        private static string[] oneOctave;
        private static string[] twoOctaves;
        private string m_SelectedItem;
        private string[] m_AdjustedChromaticNotes;


        #region Constructor
        public ChromaticNotesViewModel()
        {
            OneOctave = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            TwoOctaves = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B",
                                    "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            cNotesObject = new Models.ChromaticNotes();
        }
        #endregion

        public string[] AdjustedChromaticNotes
        {
            get { return m_AdjustedChromaticNotes; }
            set
            {
                m_AdjustedChromaticNotes = value;
                    RaisePropertyChanged("AdjustedChromaticNotes");
            }
        }

        public string SelectedItem
        {
            get { return m_SelectedItem; }
            set
            {
                m_SelectedItem = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedItem"));
            }
        }

        public static string[] TwoOctaves
        {
            get
            {
                return twoOctaves;
            }

            private set
            {
                twoOctaves = value;
            }
        }

        public static string[] OneOctave
        {
            get
            {
                return oneOctave;
            }

            set
            {
                oneOctave = value;
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    
        #region Methods

        public string[] AdjustChomaticNotesOneOtave(string note)
        {
            int noteIndex = Array.IndexOf(TwoOctaves, note);
            string[] musicalNotes = new string[12];

            for (int i = 0; i < musicalNotes.Length; i++)
            {
                musicalNotes[i] = TwoOctaves[i + noteIndex];
            }
            return musicalNotes;
        }

        #endregion
    }
}
