namespace FR_Project.Presentation
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SignUp = new Button();
            label2 = new Label();
            LogInbt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(579, 588);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(606, 144);
            label1.Name = "label1";
            label1.Size = new Size(530, 127);
            label1.TabIndex = 1;
            label1.Text = "Ready to get your Notes?";
            label1.Click += label1_Click;
            // 
            // SignUp
            // 
            SignUp.BackColor = SystemColors.ButtonHighlight;
            SignUp.FlatStyle = FlatStyle.Flat;
            SignUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp.Location = new Point(770, 395);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(235, 56);
            SignUp.TabIndex = 2;
            SignUp.Text = "Sign Up";
            SignUp.UseCompatibleTextRendering = true;
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += GetStartbt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(783, 476);
            label2.Name = "label2";
            label2.Size = new Size(213, 25);
            label2.TabIndex = 3;
            label2.Text = "Already have an Acount ?";
            // 
            // LogInbt
            // 
            LogInbt.BackColor = SystemColors.ButtonHighlight;
            LogInbt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInbt.Location = new Point(770, 504);
            LogInbt.Name = "LogInbt";
            LogInbt.Size = new Size(235, 56);
            LogInbt.TabIndex = 4;
            LogInbt.Text = "Log In";
            LogInbt.UseVisualStyleBackColor = false;
            LogInbt.Click += LogInbt_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1185, 587);
            Controls.Add(LogInbt);
            Controls.Add(label2);
            Controls.Add(SignUp);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "WelcomePage";
            Text = "WelcomePage";
            Load += WelcomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button SignUp;
        private Label label2;
        private Button LogInbt;
    }
}