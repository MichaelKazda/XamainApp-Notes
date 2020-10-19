using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotesApp.Models {
    public class Note {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
