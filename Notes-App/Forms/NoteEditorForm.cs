using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Forms
{
    public partial class NoteEditorForm : Form
    {
        public string NoteContent => rtbContent.Text;
        public string NoteTitle { get; set; }
        public NoteEditorForm()
        {
            InitializeComponent();
            this.Controls.Add(rtbContent);

        }

        private RichTextBox rtbContent = new RichTextBox
        {
            Dock = DockStyle.Fill,
            BorderStyle = BorderStyle.None,
            BackColor= Color.Green,
            Location = new Point(50,50)
        };

        public void LoadNoteContent(string content)
        {
            rtbContent.Text = content;
        }

        public void CutText()
        {
            if (rtbContent.SelectedText != "")
            {
                rtbContent.Cut();
            }
        }

        public void CopyText()
        {
            if (rtbContent.SelectedText != "")
            {
                rtbContent.Copy();
            }
        }

        public void PasteText()
        {
            if (Clipboard.GetText() != "")
            {
                rtbContent.Paste();
            }
        }

        private void NoteEditorForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
