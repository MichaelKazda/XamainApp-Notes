using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp.Templates {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNoteTemp : ContentPage {
        public AddNoteTemp() {
            InitializeComponent();
        }
    }
}