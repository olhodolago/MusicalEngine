using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;

namespace App1.Models
{
    public class ChromaticNotes : DependencyObject,INotifyPropertyChanged
    {
        public ChromaticNotes()
        {
            INote = "A";
        }
        public string INote
        {
            get { return (string)GetValue(IProperty); }
            set { SetValue(IProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IProperty =
            DependencyProperty.Register("I", typeof(string), typeof(ChromaticNotes), new PropertyMetadata(null));

        private string[] m_Notes;
        public string[] Notes
        {
            get { return m_Notes; }
            set
            {
                m_Notes = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Notes"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
