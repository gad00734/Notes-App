namespace FR_Project.Presentation
{
    partial class SignUp
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
            label1 = new Label();
            label3 = new Label();
            UserNametxt = new TextBox();
            Passwordtxt = new TextBox();
            SignUpbt = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(226, 215);
            label1.Name = "label1";
            label1.Size = new Size(125, 31);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(227, 275);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // UserNametxt
            // 
            UserNametxt.Location = new Point(443, 221);
            UserNametxt.Name = "UserNametxt";
            UserNametxt.Size = new Size(201, 27);
            UserNametxt.TabIndex = 4;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(444, 281);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.PasswordChar = '*';
            Passwordtxt.Size = new Size(201, 27);
            Passwordtxt.TabIndex = 6;
            // 
            // SignUpbt
            // 
            SignUpbt.BackColor = Color.AliceBlue;
            SignUpbt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpbt.Location = new Point(305, 385);
            SignUpbt.Name = "SignUpbt";
            SignUpbt.Size = new Size(271, 61);
            SignUpbt.TabIndex = 7;
            SignUpbt.Text = "Sign Up";
            SignUpbt.UseVisualStyleBackColor = false;
            SignUpbt.Click += SignUpbt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(236, 102);
            label2.Name = "label2";
            label2.Size = new Size(408, 54);
            label2.TabIndex = 8;
            label2.Text = "Create New Account";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(914, 677);
            Controls.Add(label2);
            Controls.Add(SignUpbt);
            Controls.Add(Passwordtxt);
            Controls.Add(UserNametxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox UserNametxt;
        private TextBox Passwordtxt;
        private Button SignUpbt;
        private Label label2;
    }
}