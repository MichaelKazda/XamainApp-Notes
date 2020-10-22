using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NotesApp {
    class MainViewModel : INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;
        private string todayDate = DateTime.Now.ToString("dddd, dd. M. yyyy");

        public string TodayDate {
            set {
                OnPropertyChanged("TodayDate");
            }
            get { return todayDate; }
        }

        protected void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
