namespace Digital_Notes_Manager.Forms
{
    partial class NoteEditor
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
            richTextBox1 = new RichTextBox();
            btnUnderline = new Button();
            btnItalic = new Button();
            btnBold = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(499, 250);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnUnderline
            // 
            btnUnderline.Location = new Point(398, 262);
            btnUnderline.Margin = new Padding(2, 2, 2, 2);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(90, 27);
            btnUnderline.TabIndex = 1;
            btnUnderline.Text = "UnderLine";
            btnUnderline.UseVisualStyleBackColor = true;
            btnUnderline.Click += btnUnderline_Click_1;
            // 
            // btnItalic
            // 
            btnItalic.Location = new Point(204, 262);
            btnItalic.Margin = new Padding(2, 2, 2, 2);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(90, 27);
            btnItalic.TabIndex = 2;
            btnItalic.Text = "Italic";
            btnItalic.UseVisualStyleBackColor = true;
            btnItalic.Click += btnItalic_Click_1;
            // 
            // btnBold
            // 
            btnBold.Location = new Point(10, 262);
            btnBold.Margin = new Padding(2, 2, 2, 2);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(90, 27);
            btnBold.TabIndex = 3;
            btnBold.Text = "Bold";
            btnBold.UseVisualStyleBackColor = true;
            btnBold.Click += btnBold_Click_1;
            // 
            // NoteEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 298);
            Controls.Add(btnBold);
            Controls.Add(btnItalic);
            Controls.Add(btnUnderline);
            Controls.Add(richTextBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NoteEditor";
            Text = "NoteEditor";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnUnderline;
        private Button btnItalic;
        private Button btnBold;
    }
}