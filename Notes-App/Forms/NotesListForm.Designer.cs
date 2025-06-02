namespace Digital_Notes_Manager.Forms
{
    partial class NotesListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvNotes = new DataGridView();
            cmbCategory = new ComboBox();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreateNote = new Button();
            btnDeleteNote = new Button();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).BeginInit();
            SuspendLayout();
            // 
            // dgvNotes
            // 
            dgvNotes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotes.Location = new Point(110, 176);
            dgvNotes.Margin = new Padding(3, 4, 3, 4);
            dgvNotes.Name = "dgvNotes";
            dgvNotes.RowHeadersWidth = 51;
            dgvNotes.Size = new Size(619, 263);
            dgvNotes.TabIndex = 0;
            dgvNotes.CellContentDoubleClick += dgvNotes_CellContentDoubleClick;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(554, 116);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(174, 28);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(122, 116);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(305, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(37, 112);
            label1.Name = "label1";
            label1.Size = new Size(81, 29);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(456, 112);
            label2.Name = "label2";
            label2.Size = new Size(99, 29);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(26, 12);
            label3.Name = "label3";
            label3.Size = new Size(94, 38);
            label3.TabIndex = 5;
            label3.Text = "Notes";
            // 
            // btnCreateNote
            // 
            btnCreateNote.BackColor = Color.White;
            btnCreateNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateNote.Location = new Point(454, 475);
            btnCreateNote.Margin = new Padding(3, 4, 3, 4);
            btnCreateNote.Name = "btnCreateNote";
            btnCreateNote.Size = new Size(127, 44);
            btnCreateNote.TabIndex = 6;
            btnCreateNote.Text = "Add Note";
            btnCreateNote.UseVisualStyleBackColor = false;
            btnCreateNote.Click += btnCreateNote_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteNote.Location = new Point(601, 473);
            btnDeleteNote.Margin = new Padding(3, 4, 3, 4);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(128, 44);
            btnDeleteNote.TabIndex = 7;
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFile.Location = new Point(122, 472);
            btnOpenFile.Margin = new Padding(3, 4, 3, 4);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(113, 47);
            btnOpenFile.TabIndex = 8;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(257, 475);
            btnSaveFile.Margin = new Padding(3, 4, 3, 4);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(122, 44);
            btnSaveFile.TabIndex = 9;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // NotesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(813, 600);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnCreateNote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(cmbCategory);
            Controls.Add(dgvNotes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NotesListForm";
            Text = "SearchForm";
            Load += NotesListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNotes;
        private ComboBox cmbCategory;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreateNote;
        private Button btnDeleteNote;
        private Button btnOpenFile;
        private Button btnSaveFile;
    }
}