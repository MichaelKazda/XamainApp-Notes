using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotesApp {
    public partial class MainPage : ContentPage {
        protected SfPopupLayout addNotePopup;

        public ICommand SaveNoteCommand { get; set; }

        public MainPage() {
            InitializeComponent();
            addNotePopup = PopupContent();
            
        }

        public SfPopupLayout PopupContent() {
            SfPopupLayout popup = new SfPopupLayout();
            popup.PopupView.HeaderTitle = "Add new note";
            popup.PopupView.AcceptButtonText = "Save";
            popup.PopupView.AcceptCommand = SaveNoteCommand;

            DataTemplate templateView = new DataTemplate(() => {
                StackLayout popupLayout = new StackLayout {
                    Children = {
                        new Label { Text = "Title (max 20 chars)", TextColor = Color.Black },
                        new Entry { Placeholder = "Title of the note",  MaxLength = 20, },
                        new Label { Text = "Note", TextColor = Color.Black},
                        new Entry { Placeholder = "What is on your mind...", MaxLength = 100},
                    }
                };

                return popupLayout;
            });

            popup.PopupView.ContentTemplate = templateView;
            popup.PopupView.AnimationMode = AnimationMode.SlideOnBottom;

            return popup;
        }

        private void addNotePopup_Clicked(object sender, EventArgs e) {
            addNotePopup.Show();

        }

        private ICommand saveNote() {
            
        }
    }
}
