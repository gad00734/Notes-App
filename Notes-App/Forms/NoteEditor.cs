using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Forms
{
    public partial class NoteEditor : Form
    {
        public NoteEditor()
        {
            InitializeComponent();
        }

        public void CutText()
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        public void CopyText()
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
        }

        public void PasteText()
        {
            if (Clipboard.GetText() != "")
            {
                richTextBox1.Paste();
            }
        }

        private void btnBold_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.Font, System.Drawing.FontStyle.Bold);
        }

        private void btnItalic_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.Font, System.Drawing.FontStyle.Italic);
        }

        private void btnUnderline_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.Font, System.Drawing.FontStyle.Underline);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
