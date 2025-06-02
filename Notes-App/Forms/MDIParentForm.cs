using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Digital_Notes_Manager.Forms
{
    public partial class MDIParentForm : Form
    {
        private int _userID;
        private NotesListForm notesListForm;

        // CategorySelector categorySelector = new CategorySelector();

        public MDIParentForm(int userID)
        {
            _userID = userID;
            InitializeComponent();

        }

        private void NewFileToolItem_Click(object sender, EventArgs e)
        {
            NoteEditor childForm = new NoteEditor();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFileToolItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the content of the selected file
                    string fileContent = File.ReadAllText(openFileDialog.FileName);

                    // Create a new NoteEditor MDI child form
                    NoteEditorForm childForm = new NoteEditorForm();
                    childForm.MdiParent = this;

                    // Set the content of the NoteEditor
                    childForm.LoadNoteContent(fileContent);

                    childForm.Text = Path.GetFileName(openFileDialog.FileName); // Set the form title to the file name

                    childForm.Show();

                    // MessageBox.Show("File opened: " + openFileDialog.FileName);
                    // Developer 4: Implement actual file opening logic
                }
            }
        }

        private void SaveFileToolItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Developer 4: Implement actual save logic
                    if (ActiveMdiChild is NoteEditorForm activeEditor)
                    {
                        try
                        {
                            // Get content from the active NoteEditorForm
                            string fileContent = activeEditor.NoteContent;

                            // Save the content to the selected file path
                            File.WriteAllText(saveFileDialog.FileName, fileContent);

                            MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            activeEditor.Text = Path.GetFileName(saveFileDialog.FileName); // Update form title after saving
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No active note editor to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // MessageBox.Show("File saved: " + saveFileDialog.FileName);
                }
            }
        }

        private void ExitFileToolItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutTextToolItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is NoteEditorForm editor)
            {
                editor.CutText();
            }
        }

        private void CopyTextToolItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is NoteEditorForm editor)
            {
                editor.CopyText();
            }
        }

        private void PasteTextToolItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is NoteEditorForm editor)
            {
                editor.PasteText();
            }
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListForm != null)
            {
                notesListForm.Visible = !notesListForm.Visible;
            }
            // dataGridViewNotes.Visible = !dataGridViewNotes.Visible;
        }


        private void TitleWindowToolItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void CascadeWindowToolItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notes App - ", "About");
        }

        private void MDIParentForm_Load(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);

            notesListForm = new NotesListForm(this);

            //  categorySelector.CategoryChanged += UpdateCategoryLabel;
        }
        public void UpdateCategoryLabel(string category)
        {
            label1.Text = $"The Note from category {category} is added";
            label1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CreateNoteForm createNoteForm = new CreateNoteForm(_userID, notesListForm, this);
            createNoteForm.Show();
        }
    }
}
