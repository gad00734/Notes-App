using System;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Forms
{
    public partial class EditNoteForm : Form
    {
        private string _originalTitle;
        private string _originalContent;
        private string _originalCategory;
        private DateTime? _originalReminderDate;
        private int _id;
      

        public EditNoteForm(string title, string content, string category, DateTime? reminderDate)
        {
            InitializeComponent();
            _originalTitle = title;
            _originalContent = content;
            _originalCategory = category;
            _originalReminderDate = reminderDate;

            LoadCategories(); // 

            txtTitle.Text = title;
            txtContent.Text = content;
            cmbCategory.Text = category;
            if (reminderDate.HasValue)
            {
                dtpReminder.Value = reminderDate.Value;
                dtpReminder.Checked = true;
            }
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            using (var context = new AppDbContext())
            {
                var categories = context.Notes
                                        .Where(n => !string.IsNullOrEmpty(n.Category))
                                        .Select(n => n.Category)
                                        .Distinct()
                                        .ToList();

                if (categories.Count == 0)
                {
                    categories = new System.Collections.Generic.List<string> { "Work", "study", "other" };
                }

                cmbCategory.Items.AddRange(categories.ToArray());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var note = context.Notes.FirstOrDefault(n => n.Title == _originalTitle && n.Content == _originalContent);

                if (note != null)
                {
                    note.Title = txtTitle.Text;
                    note.Content = txtContent.Text;
                    note.Category = cmbCategory.Text;
                    note.ReminderDate = dtpReminder.Checked ? dtpReminder.Value : (DateTime?)null;

                    context.SaveChanges();
                    MessageBox.Show("Note Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Note not found!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditNoteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (var context = new AppDbContext())
            {
                var note = context.Notes.FirstOrDefault(n => n.Title == _originalTitle && n.Content == _originalContent);
                _id = note.UserID;


            }
            MDIParentForm form = new MDIParentForm(_id);
            form.ShowDialog();
            this.Hide();
        }
    }
}
