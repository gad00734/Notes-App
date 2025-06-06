﻿
namespace Digital_Notes_Manager.Forms
{
    partial class EditNoteForm
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
            txtTitle = new TextBox();
            cmbCategory = new ComboBox();
            dtpReminder = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            txtContent = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(111, 169);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(114, 27);
            txtTitle.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(350, 169);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(138, 28);
            cmbCategory.TabIndex = 2;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(574, 169);
            dtpReminder.Margin = new Padding(3, 4, 3, 4);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(228, 27);
            dtpReminder.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(136, 452);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 47);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(593, 452);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 47);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(59, 220);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(755, 204);
            txtContent.TabIndex = 6;
            txtContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(50, 165);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkCyan;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(239, 165);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 10;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(504, 169);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 11;
            label4.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(59, 61);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 12;
            label2.Text = "Edit Note..";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(816, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 47);
            button1.TabIndex = 13;
            button1.Text = "Main";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditNoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtContent);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpReminder);
            Controls.Add(cmbCategory);
            Controls.Add(txtTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditNoteForm";
            Text = "EditNoteForm";
            Load += EditNoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private ComboBox cmbCategory;
        private DateTimePicker dtpReminder;
        private Button btnSave;
        private Button btnCancel;
        private RichTextBox txtContent;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private EventHandler richTextBox1_TextChanged;
        private Button button1;
    }
}