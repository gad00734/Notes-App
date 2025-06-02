using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Forms
{
    public partial class DeleteNoteForm : Form
    {
        private int _noteId;
        private AppDbContext _context;
        private NotesListForm _parentForm;

        public DeleteNoteForm(int noteId, NotesListForm parentForm)
        {
            InitializeComponent();
            _noteId = noteId;
            _context = new AppDbContext();
            _parentForm = parentForm;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            var note = _context.Notes.Find(_noteId);
            if (note != null)
            {
                _context.Notes.Remove(note);
                _context.SaveChanges();
                MessageBox.Show("Note deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                _parentForm.LoadNotes();
                this.Close();
            }
            else
            {
                MessageBox.Show("Note not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteNoteForm_Load(object sender, EventArgs e)
        {
            SetRoundedButton(btnConfirmDelete, 26);
            SetRoundedButton(btnCancel, 26);

        }
        private void SetRoundedButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }
    }
}
