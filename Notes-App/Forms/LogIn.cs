using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Notes_Manager;
using Digital_Notes_Manager.Exceptions;
using Digital_Notes_Manager.Forms;
using Digital_Notes_Manager.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace FR_Project.Presentation
{
    public partial class LogIn : Form
    {
        private readonly AuthServices _authServices;
        private readonly IServiceProvider _serviceProvider;

        public LogIn(AuthServices authServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authServices = authServices;
            _serviceProvider = serviceProvider;
            this.KeyPreview = true;

            // Add KeyDown event handlers to textboxes
            txtUserName.KeyDown += new KeyEventHandler(txtUserName_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(txtPassword_KeyDown);
        }

        private void SignUpbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _authServices.Login(txtUserName.Text, txtPassword.Text);
                
                // Store user session
                SessionManager.UserName = txtUserName.Text;
                SessionManager.SetPassword(txtPassword.Text);

                using (var context = new AppDbContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.Username == txtUserName.Text);
                    if (user != null)
                    {
                        var mdiParent = new MDIParentForm(user.UserId, _serviceProvider);
                        NotesListForm notesListForm = new NotesListForm(mdiParent, _serviceProvider);
                        CreateNoteForm createNoteForm = new CreateNoteForm(user.UserId, notesListForm, mdiParent, _serviceProvider);
                        mdiParent.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (InvalidUserNotExists ex)
            {
                var result = MessageBox.Show(
                    $"User not found. Would you like to create an account?",
                    "Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var signUpForm = _serviceProvider.GetRequiredService<SignUp>();
                    signUpForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetRoundedButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            SetRoundedButton(btnLogin, 26);
        }

        private void dontHaveAnAccountBTN_Click(object sender, EventArgs e)
        {
            var signUpForm = _serviceProvider.GetRequiredService<SignUp>();
            signUpForm.Show();
            this.Hide();
        }

        // Add KeyDown event handler
        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            // Keep Escape key handling on the form
            if (e.KeyCode == Keys.Escape)
            {
                // Close the form
                this.Close();
                e.Handled = true; // Mark the event as handled
            }
        }

        // KeyDown handler for txtUserName
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the login button click event
                btnLogin.PerformClick();
                e.Handled = true; // Mark the event as handled
                e.SuppressKeyPress = true; // Suppress the default key press
            }
        }

        // KeyDown handler for txtPassword
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the login button click event
                btnLogin.PerformClick();
                e.Handled = true; // Mark the event as handled
                e.SuppressKeyPress = true; // Suppress the default key press
            }
        }
    }
}
