using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotesApp {
    public partial class MainPage : ContentPage {
        protected SfPopupLayout addNotePopup;

        public MainPage() {
            InitializeComponent();
            addNotePopup = new SfPopupLayout();
        }

        private void addNotePopup_Clicked(object sender, EventArgs e) {
            addNotePopup.Show();
        }
    }
}
