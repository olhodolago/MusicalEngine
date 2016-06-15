using System;
using System.Collections.Generic;

namespace MusicalEngine
{
    static class ScaleModesNotes
    {
        public static readonly bool[] ionianSignature = { true, false, true, false, true, true, false, true, false, true, false, true };
        public static readonly bool[] dorianSignature = { true, false, true, true, false, true, false, true, false, true, false, true };
        public static readonly bool[] phrigianSignature = { true, true, false, true, false, true, false, true, true, false, true, false };
        public static readonly bool[] lydianSignature = { true, false, true, false, true, false, true, true, false, true, false, true };
        public static readonly bool[] mixolidianSignature = { true, false, true, false, true, true, false, true, false, true, true, false };
        public static readonly bool[] aeoleanSignature = { true, false, true, true, false, true, false, true, true, false, true, false };
        public static readonly bool[] locrianSignature = { true, true, false, true, true, true, false, true, false, true, false };


        #region members
        public static readonly float[] jonianIntervalsFromRoot = { 1, 2, 2.5f, 3.5f, 4.5f, 5.5f };
        public static readonly float[] dorianIntervalsFromRoot = { 1, 1.5f, 2.5f, 3.5f, 4.5f, 5 };
        public static readonly float[] phrigianIntervalsFromRoot = { 0.5f, 1.5f, 2.5f, 3.5f, 4, 5 };
        public static readonly float[] lydianIntervalsFromRoot = { 1, 2, 3, 3.5f, 4.5f, 5.5f };
        public static readonly float[] mixolidianIntervalsFromRoot = { 1, 2, 2.5f, 3.5f, 4.5f, 5 };
        public static readonly float[] aeolianIntervalsFromRoot = { 1, 1.5f, 2.5f, 3.5f, 4, 5 };
        public static readonly float[] locrianIntervalsFromRoot = { 0.5f, 1.5f, 2.5f, 3, 4, 5 };

        public static readonly float[] jonianHarmIntervalsFromRoot = { 1, 2, 2.5f, 4, 4.5f, 5.5f };
        public static readonly float[] dorianHarmIntervalsFromRoot = { 1, 1.5f, 3, 3.5f, 4.5f, 5 };
        public static readonly float[] phrigianHarmIntervalsFromRoot = { 0.5f, 2, 2.5f, 3.5f, 4, 5 };
        public static readonly float[] lydianHarmIntervalsFromRoot = { 1.5f, 2, 3, 3.5f, 4.5f, 5.5f };
        public static readonly float[] mixolidianHarmIntervalsFromRoot = { 0.5f, 2, 2.5f, 3.5f, 4.5f, 5 };
        public static readonly float[] aeolianHarmIntervalsFromRoot = { 1, 1.5f, 2.5f, 3.5f, 4, 5.5f };
        public static readonly float[] locrianHarmIntervalsFromRoot = { 0.5f, 1.5f, 2.5f, 3, 4.5f, 5 };

        public static readonly string jonianStr = "Jonian";
        public static readonly string dorianStr = "Dorian";
        public static readonly string phrigianStr = "Phrigian";
        public static readonly string lydianStr = "Lydian";
        public static readonly string mixolidianStr = "Mixolidian";
        public static readonly string aeolianStr = "Aeolian";
        public static readonly string locrianStr = "Locrian";

        public static List<float[]> modesIntervalsFromRoot = new List<float[]> { jonianIntervalsFromRoot, dorianIntervalsFromRoot
        ,phrigianIntervalsFromRoot,lydianIntervalsFromRoot,mixolidianIntervalsFromRoot
        ,aeolianIntervalsFromRoot,locrianIntervalsFromRoot};

        public static List<float[]> modesHarmIntervalsFromRoot = new List<float[]> { jonianHarmIntervalsFromRoot, dorianHarmIntervalsFromRoot
        ,phrigianHarmIntervalsFromRoot,lydianHarmIntervalsFromRoot,mixolidianHarmIntervalsFromRoot
        ,aeolianHarmIntervalsFromRoot,locrianHarmIntervalsFromRoot};

        public static List<string> modesNames = new List<string> { jonianStr,dorianStr,phrigianStr,lydianStr,mixolidianStr,
            aeolianStr, locrianStr };
        #endregion
    }
}
