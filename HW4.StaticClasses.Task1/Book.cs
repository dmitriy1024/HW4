using System;
using System.Collections.Generic;

namespace HW4.StaticClasses.Task1
{
    class Book
    {   
        public string Title { get; private set; }
        public string Author { get; private set; }
        public Notes BookNotes { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            BookNotes = new Notes();
        }

        public override string ToString()
        {
            return String.Format("Title : {0}  Author: {1}",Title, Author);
        }

        public class Notes
        {
            private List<string> _notes = new List<string>();

            public string[] GetAll () { return _notes.ToArray(); }
            public void AddNote(string note) { _notes.Add(note); }
        }
    }
}
