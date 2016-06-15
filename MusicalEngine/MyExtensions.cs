using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalEngine
{
    public static class MyExtensions
    {
        public static int ToInt(this float interval, float[] mode)
        {
            int j = Array.IndexOf(mode, interval);
            return j;
        }
        public static string ToNote(this float f, float[] mode, string root)
        {
            string[] s = Notes.AdjustChomaticNotesOneOtave(root);
            string note = s[(int)(f * 2)];
            return note;
        }
        public static float[] ToMode(this int i)
        {
            return ScaleModesNotes.modesIntervalsFromRoot[i - 1];
        }
        public static float ToInterval(this int i, int mode)
        {
            float[] m = ScaleModesNotes.modesIntervalsFromRoot[mode];
            float intervalFromRoot = m[i];
            return intervalFromRoot;
        }
        public static float ToInterval(this int i, float[] mode)
        {
            float[] m = mode;
            float intervalFromRoot = m[i];
            return intervalFromRoot;
        }
    }
}
