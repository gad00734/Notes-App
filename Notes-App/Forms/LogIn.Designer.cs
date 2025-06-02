namespace FR_Project.Presentation
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lbUserName = new Label();
            lbPassword = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(240, 364);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(206, 63);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += SignUpbt_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.MenuBar;
            txtPassword.Location = new Point(337, 282);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(255, 43);
            txtPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.MenuBar;
            txtUserName.Location = new Point(337, 215);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(255, 42);
            txtUserName.TabIndex = 12;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            lbUserName.ForeColor = SystemColors.ButtonHighlight;
            lbUserName.Location = new Point(158, 211);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(132, 31);
            lbUserName.TabIndex = 10;
            lbUserName.Text = "UserName";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.Transparent;
            lbPassword.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            lbPassword.ForeColor = SystemColors.ButtonHighlight;
            lbPassword.Location = new Point(158, 294);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(123, 31);
            lbPassword.TabIndex = 9;
            lbPassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(199, 86);
            label1.Name = "label1";
            label1.Size = new Size(299, 50);
            label1.TabIndex = 15;
            label1.Text = "Welcome Back !";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(421, 471);
            label2.Name = "label2";
            label2.Size = new Size(277, 31);
            label2.TabIndex = 16;
            label2.Text = "Don`t Have An Account";
            label2.Click += dontHaveAnAccountBTN;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(726, 552);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Controls.Add(lbPassword);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lbUserName;
        private Label lbPassword;
        private Label label1;
        private Label label2;
    }
}