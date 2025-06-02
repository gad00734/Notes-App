namespace Digital_Notes_Manager.Forms
{
    partial class DeleteNoteForm
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
            lblMessage = new Label();
            btnConfirmDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.ButtonHighlight;
            lblMessage.Location = new Point(14, 75);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(164, 32);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Delete Note..";
            // 
            // btnConfirmDelete
            // 
            btnConfirmDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmDelete.Location = new Point(72, 297);
            btnConfirmDelete.Margin = new Padding(3, 4, 3, 4);
            btnConfirmDelete.Name = "btnConfirmDelete";
            btnConfirmDelete.Size = new Size(138, 44);
            btnConfirmDelete.TabIndex = 1;
            btnConfirmDelete.Text = "Delete Note";
            btnConfirmDelete.UseVisualStyleBackColor = true;
            btnConfirmDelete.Click += btnConfirmDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(271, 297);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 44);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DeleteNoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(480, 475);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmDelete);
            Controls.Add(lblMessage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteNoteForm";
            Text = "DeleteNoteForm";
            Load += DeleteNoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnConfirmDelete;
        private Button btnCancel;
    }
}