using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Windows.Management.Core;
namespace MusicalEngine
{
    public class Notes
    {
        public static string[] chromaticNotes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B",
                                    "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        string[] adjustedCromaticNotesOneOctave;
        public string[] AdjustedChromaticNotesOneOctave    
        {
            get { return adjustedCromaticNotesOneOctave; }
            set { adjustedCromaticNotesOneOctave = value; }
        }

        public Notes(string value)
        {
            adjustedCromaticNotesOneOctave = AdjustChomaticNotesOneOtave(value);
        }

        public static string[] AdjustChomaticNotesOneOtave(string note)
        {
            int noteIndex = Array.IndexOf(chromaticNotes, note);
            string[] musicalNotes = new string[12];

            for (int i = 0; i < musicalNotes.Length; i++)
            {
                musicalNotes[i] = chromaticNotes[i + noteIndex];
            }
            return musicalNotes;
        }

        public static List<string[]> SetRootNote(params string[] str)
        {
            List<string[]> list = new List<string[]>();
            List<string> tempList = new List<string>();

            foreach (string s in str)
            {
                int i = 0;
                tempList.Clear();
                tempList.Add(s);
                do
                {
                    if (str[i] != s)
                    {
                        tempList.Add(str[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                while (i < str.Length);
                list.Add(tempList.ToArray());
            }
            return list;
        }
    }
}
