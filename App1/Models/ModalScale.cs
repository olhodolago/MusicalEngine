using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    class ModalScale
    {
        private string[] modeNotes;
        string modeName;

        #region Properties
        public string[] ModeNotes
        {
            get
            {
                return modeNotes;
            }

            set
            {
                modeNotes = value;
            }
        }

        public string ModeName
        {
            get
            {
                return modeName;
            }

            set
            {
                modeName = value;
            }
        }
        #endregion
    }
}
