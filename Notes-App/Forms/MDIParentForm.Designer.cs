namespace Digital_Notes_Manager.Forms
{
    partial class MDIParentForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewFileToolItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripComboBox1 = new ToolStripComboBox();
            OpenFileToolItem = new ToolStripMenuItem();
            SaveFileToolItem = new ToolStripMenuItem();
            ExitFileToolItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            CutTextToolItem = new ToolStripMenuItem();
            CopyTextToolItem = new ToolStripMenuItem();
            PasteTextToolItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toggleToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            TitleWindowToolItem = new ToolStripMenuItem();
            CascadeWindowToolItem = new ToolStripMenuItem();
            AboutHelpToolItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewNotes = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, windowToolStripMenuItem, AboutHelpToolItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(640, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFileToolItem, OpenFileToolItem, SaveFileToolItem, ExitFileToolItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewFileToolItem
            // 
            NewFileToolItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripComboBox1 });
            NewFileToolItem.Name = "NewFileToolItem";
            NewFileToolItem.Size = new Size(224, 26);
            NewFileToolItem.Text = "New";
            NewFileToolItem.Click += NewFileToolItem_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // OpenFileToolItem
            // 
            OpenFileToolItem.Name = "OpenFileToolItem";
            OpenFileToolItem.Size = new Size(224, 26);
            OpenFileToolItem.Text = "Open";
            OpenFileToolItem.Click += OpenFileToolItem_Click;
            // 
            // SaveFileToolItem
            // 
            SaveFileToolItem.Name = "SaveFileToolItem";
            SaveFileToolItem.Size = new Size(224, 26);
            SaveFileToolItem.Text = "Save";
            SaveFileToolItem.Click += SaveFileToolItem_Click;
            // 
            // ExitFileToolItem
            // 
            ExitFileToolItem.Name = "ExitFileToolItem";
            ExitFileToolItem.Size = new Size(224, 26);
            ExitFileToolItem.Text = "Exit";
            ExitFileToolItem.Click += ExitFileToolItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CutTextToolItem, CopyTextToolItem, PasteTextToolItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // CutTextToolItem
            // 
            CutTextToolItem.Name = "CutTextToolItem";
            CutTextToolItem.Size = new Size(224, 26);
            CutTextToolItem.Text = "Cut";
            CutTextToolItem.Click += CutTextToolItem_Click;
            // 
            // CopyTextToolItem
            // 
            CopyTextToolItem.Name = "CopyTextToolItem";
            CopyTextToolItem.Size = new Size(224, 26);
            CopyTextToolItem.Text = "Copy";
            CopyTextToolItem.Click += CopyTextToolItem_Click;
            // 
            // PasteTextToolItem
            // 
            PasteTextToolItem.Name = "PasteTextToolItem";
            PasteTextToolItem.Size = new Size(224, 26);
            PasteTextToolItem.Text = "Paste";
            PasteTextToolItem.Click += PasteTextToolItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toggleToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // toggleToolStripMenuItem
            // 
            toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            toggleToolStripMenuItem.Size = new Size(224, 26);
            toggleToolStripMenuItem.Text = "Toggle Notes List";
            toggleToolStripMenuItem.Click += toggleToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TitleWindowToolItem, CascadeWindowToolItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(78, 24);
            windowToolStripMenuItem.Text = "Window";
            // 
            // TitleWindowToolItem
            // 
            TitleWindowToolItem.Name = "TitleWindowToolItem";
            TitleWindowToolItem.Size = new Size(147, 26);
            TitleWindowToolItem.Text = "Title";
            TitleWindowToolItem.Click += TitleWindowToolItem_Click;
            // 
            // CascadeWindowToolItem
            // 
            CascadeWindowToolItem.Name = "CascadeWindowToolItem";
            CascadeWindowToolItem.Size = new Size(147, 26);
            CascadeWindowToolItem.Text = "Cascade";
            CascadeWindowToolItem.Click += CascadeWindowToolItem_Click;
            // 
            // AboutHelpToolItem
            // 
            AboutHelpToolItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            AboutHelpToolItem.Name = "AboutHelpToolItem";
            AboutHelpToolItem.Size = new Size(55, 24);
            AboutHelpToolItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // dataGridViewNotes
            // 
            dataGridViewNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotes.Location = new Point(0, 29);
            dataGridViewNotes.Margin = new Padding(2);
            dataGridViewNotes.Name = "dataGridViewNotes";
            dataGridViewNotes.RowHeadersWidth = 62;
            dataGridViewNotes.Size = new Size(640, 308);
            dataGridViewNotes.TabIndex = 6;
            dataGridViewNotes.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 34);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 1);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(521, 3);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 1;
            button1.Text = "Create Note";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MDIParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 337);
            Controls.Add(panel1);
            Controls.Add(dataGridViewNotes);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "MDIParentForm";
            Text = "MDIParentForm";
            this.BackColor = System.Drawing.Color.Black;
            Load += MDIParentForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewFileToolItem;
        private ToolStripMenuItem OpenFileToolItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem SaveFileToolItem;
        private ToolStripMenuItem ExitFileToolItem;
        private ToolStripMenuItem CutTextToolItem;
        private ToolStripMenuItem CopyTextToolItem;
        private ToolStripMenuItem PasteTextToolItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toggleToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem TitleWindowToolItem;
        private ToolStripMenuItem CascadeWindowToolItem;
        private ToolStripMenuItem AboutHelpToolItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private DataGridView dataGridViewNotes;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripComboBox toolStripComboBox1;
        private Panel panel1;
        private Label label1;
        private Button button1;
    }
}