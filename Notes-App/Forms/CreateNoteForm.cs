using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using FR_Project.Presentation;

namespace Digital_Notes_Manager.Forms
{
    public partial class CreateNoteForm : Form
    {
        private readonly int _userId;
        private readonly NotesListForm _notesListForm;
        private readonly MDIParentForm _mdiParent;
        private readonly IServiceProvider _serviceProvider;
        CategorySelector categorySelector = new CategorySelector();

        public CreateNoteForm(int userId, NotesListForm notesListForm, MDIParentForm mdiParent, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userId = userId;
            _notesListForm = notesListForm;
            _mdiParent = mdiParent;
            _serviceProvider = serviceProvider;
            this.Load += CreateNoteForm_Load;
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
                    categories = new List<string> { "Work", "Study", "Other" };
                }

                cmbCategory.Items.AddRange(categories.ToArray());
            }
        }

        private void CreateNoteForm_Load(object sender, EventArgs e)
        {
            SetRoundedButton(btnSave, 26);
            SetRoundedButton(btnBackToNotes, 26);
            SetRoundedButton(btnCancel, 26);

            // LoadCategories();

            categorySelector.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(categorySelector);
            categorySelector.CategoryChanged += CategorySelector_CategoryChanged;

        }

        private void CategorySelector_CategoryChanged(object sender, EventArgs e)
        {
            // 🔹 تحديث `MDIParentForm` عند تغيير التصنيف
            _mdiParent.UpdateCategoryLabel(categorySelector.SelectedCategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Title and Content are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                var newNote = new Note
                {
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    Category = categorySelector.SelectedCategory,
                    ReminderDate = dtpReminder.Checked ? dtpReminder.Value : (DateTime?)null,
                    UserID = _userId
                };

                context.Notes.Add(newNote);
                context.SaveChanges();
            }

            MessageBox.Show("Note Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (this.MdiParent is MDIParentForm parentForm)
            {
                parentForm.UpdateCategoryLabel(categorySelector.SelectedCategory);
            }
            // تحديث قائمة الملاحظات بعد الحفظ
            _notesListForm.LoadNotes();

            // تفريغ الحقول
            txtTitle.Clear();
            txtContent.Clear();
            cmbCategory.SelectedIndex = -1;
            dtpReminder.Value = DateTime.Now;
            dtpReminder.Checked = false;
        }

        private void btnBackToNotes_Click(object sender, EventArgs e)
        {
            _notesListForm.Show();
            _notesListForm.LoadNotes(); // تحديث القائمة
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MDIParentForm form = new MDIParentForm(_userId, _serviceProvider);
            form.ShowDialog();
            this.Hide();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
