using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Services
{
    internal interface INoteService
    {
        List<Note> GetAllNotes();
        void AddNote(Note note);
        void RemoveNote(Note note);

    }
}
