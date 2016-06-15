using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1.ViewModel;
using App1.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace App1.Controls
{
    public sealed partial class ChromaticWheel : UserControl
    {
        ChromaticNotesViewModel cmvm;
        Models.ChromaticNotes cm;
        public string SelectedIndex
        {
            get { return (string)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register("MyProperty", typeof(string), typeof(ChromaticWheel), new PropertyMetadata(null));

        public ChromaticWheel()
        {
            this.InitializeComponent();
            cmvm = new ChromaticNotesViewModel();
            cm = new Models.ChromaticNotes();
        }

        public void cBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cm.INote = cBox.SelectedItem.ToString();
        }
    }
}
