using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Services
{
    public class FakeNoteService : INoteService
    {
        private readonly List<Note> _notes = new ();

        public List<Note> GetAllNotes() => _notes;

        public void AddNote(Note note)
        {
            _notes.Add(note);
        }

        public void RemoveNote(Note note)
        {
            _notes.Remove(note);    
        }
    }
}
