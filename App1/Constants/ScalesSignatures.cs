using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Constants
{
    static class ScalesSignatures
    {
        private static readonly bool[] ionianSignature = { true, false, true, false, true, true, false, true, false, true, false, true };
        private static readonly bool[] dorianSignature = { true, false, true, true, false, true, false, true, false, true, false, true };
        private static readonly bool[] phrigianSignature = { true, true, false, true, false, true, false, true, true, false, true, false };
        private static readonly bool[] lydianSignature = { true, false, true, false, true, false, true, true, false, true, false, true };
        private static readonly bool[] mixolidianSignature = { true, false, true, false, true, true, false, true, false, true, true, false };
        private static readonly bool[] aeoleanSignature = { true, false, true, true, false, true, false, true, true, false, true, false };
        private static readonly bool[] locrianSignature = { true, true, false, true, true, true, false, true, false, true, false };
  
        #region Properties
        public static bool[] IonianSignature
        {
            get
            {
                return ionianSignature;
            }
        }

        public static bool[] DorianSignature
        {
            get
            {
                return dorianSignature;
            }
        }

        public static bool[] PhrigianSignature
        {
            get
            {
                return phrigianSignature;
            }
        }

        public static bool[] LydianSignature
        {
            get
            {
                return lydianSignature;
            }
        }

        public static bool[] MixolidianSignature
        {
            get
            {
                return mixolidianSignature;
            }
        }

        public static bool[] AeoleanSignature
        {
            get
            {
                return aeoleanSignature;
            }
        }

        public static bool[] LocrianSignature
        {
            get
            {
                return locrianSignature;
            }
        }
        #endregion
    }
}
