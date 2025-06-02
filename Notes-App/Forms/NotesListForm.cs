using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Digital_Notes_Manager.Forms
{
    public partial class NotesListForm : Form
    {
        private AppDbContext _context;
        private MDIParentForm _mdiParent;
        public NotesListForm(MDIParentForm mdiParent)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _context = new AppDbContext();
            LoadCategories();
            LoadNotes();
        }
        //load notes
        public void LoadNotes()
        {
            var query = _context.Notes.AsQueryable();

            if (cmbCategory.SelectedItem?.ToString() != "All")
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                query = query.Where(n => n.Category == selectedCategory);
            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string searchQuery = txtSearch.Text.ToLower();
                query = query.Where(n => n.Title.ToLower().Contains(searchQuery) ||
                                         n.Content.ToLower().Contains(searchQuery));
            }

            dgvNotes.DataSource = query.Select(n => new
            {
                n.NoteID,
                n.Title,
                n.Content,
                n.Category,
                ReminderDate = n.ReminderDate.HasValue ? n.ReminderDate.Value.ToString("yyyy-MM-dd") : "No Reminder"
            }).ToList();

            //hidden
            if (dgvNotes.Columns["NoteID"] != null)
            {
                dgvNotes.Columns["NoteID"].Visible = false;
            }
        }


        private void LoadCategories()
        {
            var categories = _context.Notes
                                     .Select(n => n.Category)
                                     .Distinct()
                                     .ToList();
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            cmbCategory.Items.AddRange(categories.ToArray());
            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void dgvNotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string title = dgvNotes.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                string content = dgvNotes.Rows[e.RowIndex].Cells["Content"].Value.ToString();
                string category = dgvNotes.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                DateTime? reminderDate = dgvNotes.Rows[e.RowIndex].Cells["ReminderDate"].Value as DateTime?;

                EditNoteForm editForm = new EditNoteForm(title, content, category, reminderDate);
                editForm.Show();
            }
        }

        //to open text file
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Open a Text File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(filePath);

                //new DataTable 
                DataTable dt = new DataTable();
                dt.Columns.Add("Title");
                dt.Columns.Add("Content");
                dt.Columns.Add("Category");

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 3)
                    {
                        dt.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }

                dgvNotes.DataSource = dt;

                MessageBox.Show("Notes loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //save to text file
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Notes"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                List<string> lines = new List<string>();

                foreach (DataGridViewRow row in dgvNotes.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string title = row.Cells["Title"].Value?.ToString() ?? "";
                        string content = row.Cells["Content"].Value?.ToString() ?? "";
                        string category = row.Cells["Category"].Value?.ToString() ?? "";

                        lines.Add($"{title}|{content}|{category}");
                    }
                }

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Notes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //add new note
        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            int userID = 1;
            MDIParentForm mdiParent = this.MdiParent as MDIParentForm;
            CreateNoteForm createNoteForm = new CreateNoteForm(userID, this, mdiParent);
            createNoteForm.Show();
            this.Hide();
        }

        //delete note 
        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                int noteId = (int)dgvNotes.SelectedRows[0].Cells["NoteId"].Value;

                DeleteNoteForm deleteNoteForm = new DeleteNoteForm(noteId, this);
                deleteNoteForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a note to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NotesListForm_Load(object sender, EventArgs e)
        {
            SetRoundedButton(btnOpenFile, 26);
            SetRoundedButton(btnCreateNote, 26);
            SetRoundedButton(btnDeleteNote, 26);
            SetRoundedButton(btnSaveFile, 26);


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

        private void NotesListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Prevent the form from closing
            this.Hide(); // Hide the form instead
        }
    }
}
