using Digital_Notes_Manager.Services;

namespace Digital_Notes_Manager
{
    public class NoteServices:INoteService, IDisposable
    {
       private readonly AppDbContext _context;
        private bool _disposed;
       public NoteServices(AppDbContext cotext)
        {
            _context = cotext;
        }
        public  List<Note> GetAllNotes() 
        {
         return _context.Notes.ToList();
        }

        public void AddNote(Note note)
        {

            ArgumentNullException.ThrowIfNull(note, nameof(note));
            _context.Notes.Add(note);
            _context.SaveChanges();    
        }

        public void RemoveNote(Note note)
        {
            ArgumentNullException.ThrowIfNull(note, nameof(note));
            _context.Notes.Remove(note);
            _context.SaveChanges();

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }

    }
}
