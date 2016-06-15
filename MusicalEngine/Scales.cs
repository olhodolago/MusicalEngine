using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalEngine
{
    public delegate string[] NotesHandler(string str);
    public delegate List<string[]> FillScaleNotesHandler(params string[] list);

    public class ScalesWorker
    {
        public List<string[]> possibleScales = new List<string[]>();
        public List<string> possibleScalesNames = new List<string>();
        public List<string> possibleScalesRootNote = new List<string>();

        public List<string[]> PossibleScales
        {
            get { return possibleScales; }
            set { possibleScales = value; }
        }
        public List<string> PossibleScalesNames
        {
            get { return possibleScalesNames; }
            set { possibleScalesNames = value; }
        }

        public List<string> PossibleScalesRootNote
        {
            get { return possibleScalesRootNote; }
            set { possibleScalesNames = value; }
        }

        List<float[]> tempList = ScaleModesNotes.modesIntervalsFromRoot;

        public ScalesWorker(params string[] arrStr)
        {

            foreach (float[] f in tempList)
            {
                if (arrStr.Length == 0)
                    continue;
                string[] temp = new string[f.Length + 1];
                string strTemp;

                temp[0] = arrStr[0];
                for (int j = 1; j < temp.Length; j++)
                {
                    temp[j] = f[j - 1].ToNote(f, arrStr[0]);
                    strTemp = ScaleModesNotes.modesNames[j];
                }
                if (arrStr.All(x => temp.Contains(x)))
                {
                    possibleScales.Add(temp);
                    possibleScalesNames.Add(ScaleModesNotes.modesNames[0]);
                    possibleScalesRootNote.Add(temp[0]);
                }
            }
        }

        public ScalesWorker(ObservableCollection<string> selectedNotes)
        {
            foreach (float[] f in tempList)
            {
                if (selectedNotes.Count == 0)
                    continue;
                string[] temp = new string[f.Length + 1];
                string modesNames;

                temp[0] = selectedNotes[0];
                for (int j = 1; j < temp.Length; j++)
                {
                    temp[j] = f[j - 1].ToNote(f, selectedNotes[0]);
                    modesNames = ScaleModesNotes.modesNames[j];
                }
                if (selectedNotes.All(x => temp.Contains(x)))
                {
                    possibleScales.Add(temp);
                    possibleScalesNames.Add(ScaleModesNotes.modesNames[0]);
                    possibleScalesRootNote.Add(temp[0]);
                }
            }
        }
    }
}
