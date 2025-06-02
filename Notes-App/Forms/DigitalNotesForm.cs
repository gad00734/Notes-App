using Digital_Notes_Manager.Forms;
using Org.BouncyCastle.Asn1.Ocsp;
using System;

namespace Digital_Notes_Manager
{
    public partial class DigitalNotesForm : Form
    {
        NoteServices _noteServices;
        public DigitalNotesForm(NoteServices noteServices)
        {
            _noteServices = noteServices;
            this.IsMdiContainer = true;
            this.Width = 1500;
            this.Height = 1500;
            InitializeMenu();
            Note note = new Note()
            {
                NoteID = 0,
                Category = "any thing ",
                Content = "Note Test",
                CreationDate = DateTime.Now,
                ReminderDate = DateTime.Now,
               
                Title = "title",


            };


            CreateNoteUI(note);
        }

        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            fileMenu.DropDownItems.Add("New", null, NewFile_Click);
            fileMenu.DropDownItems.Add("Open", null, OpenFile_Click);
            fileMenu.DropDownItems.Add("Save", null, SaveFile_Click);
            fileMenu.DropDownItems.Add("Exit", null, ExitApp_Click);

            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");
            editMenu.DropDownItems.Add("Cut", null, CutText_Click);
            editMenu.DropDownItems.Add("Copy", null, CopyText_Click);
            editMenu.DropDownItems.Add("Paste", null, PasteText_Click);
            editMenu.DropDownItems.Add("Format", null, FormatText_Click);

            ToolStripMenuItem viewMenu = new ToolStripMenuItem("View");
            viewMenu.DropDownItems.Add("Notes List", null, ViewNotesList_Click);
            viewMenu.DropDownItems.Add("Tile Windows", null, TileWindows_Click);
            viewMenu.DropDownItems.Add("Cascade Windows", null, CascadeWindows_Click);

            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");
            helpMenu.DropDownItems.Add("About", null, ShowAbout_Click);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(editMenu);
            menuStrip.Items.Add(viewMenu);
            menuStrip.Items.Add(helpMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
           NoteEditorForm noteEditorForm= new NoteEditorForm()
           {
               MdiParent= this,              
           };
            noteEditorForm.StartPosition = FormStartPosition.Manual;
            noteEditorForm.Location= new Point(

            (this.ClientSize.Width - noteEditorForm.Width) / 2,

            (this.ClientSize.Height - noteEditorForm.Height) / 2

             );
            noteEditorForm.Show();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open File Clicked");
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save File Clicked");
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cut Clicked");
        }

        private void CopyText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy Clicked");
        }

        private void PasteText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paste Clicked");
        }

        private void FormatText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Format Clicked");
        }

        private void ViewNotesList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notes List Clicked");
        }

        private void TileWindows_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CascadeWindows_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ShowAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MDI Application v1.0\nCreated by You", "About");
        }



        private void CreateNoteUI(Note note)
        {
            // Create a panel for the note
            Panel notePanel = new Panel
            {
                Size = new Size(600, 200),
                Location = new Point(50, 50),
                BackColor = Color.FromName("green"),
                Tag = note.NoteID 
            };


            TextBox titleBox = new TextBox
            {
                Text = note.Title,
                Width = notePanel.Width,
               
                Location = new Point(15, 10),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BorderStyle = BorderStyle.None, 
                BackColor = Color.Transparent,
                ReadOnly = true                     
            };

            titleBox.Click += (s, e) => titleBox.ReadOnly = false;
            notePanel.Controls.Add(titleBox);

            RichTextBox contentBox = new RichTextBox
            {
                Text = note.Content,
                Location = new Point(15, 40),
                Size = new Size(230, 120),
                BorderStyle = BorderStyle.None,
                BackColor = notePanel.BackColor
            };
            notePanel.Controls.Add(contentBox);

            // Add delete button
            Button deleteButton = new Button
            {
                Text = "×",
                Location = new Point(220, 0),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat
            };
/*            deleteButton.Click += (s, e) => DeleteNote(note.Id);
*/
            notePanel.Controls.Add(deleteButton);

            // Add drag/resize handlers (if needed)
            /*            notePanel.MouseDown += NotePanel_MouseDown;
            */
            // Add to the main form or MDI parent
            this.Controls.Add(notePanel);
        }












        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}