using Digital_Notes_Manager;
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
using Microsoft.Extensions.DependencyInjection;

namespace FR_Project.Presentation
{
    public partial class SignUp : Form
    {
        private readonly AuthServices _authServices;
        private readonly IServiceProvider _serviceProvider;

        public SignUp(AuthServices authServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authServices = authServices;
            _serviceProvider = serviceProvider;
        }

        private void SignUpbt_Click(object sender, EventArgs e)
        {
            string? userName = UserNametxt.Text;
            string? password = Passwordtxt.Text;
            if (userName != null && userName.Trim() != ""
                && password != null && password.Trim() != "")
            {
                try
                {
                    _authServices.CreateUser(userName, password);
                    MessageBox.Show("Registration successful! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Redirect to login page
                    var loginForm = _serviceProvider.GetRequiredService<LogIn>();
                    loginForm.Show();
                    this.Hide();
                }
                catch (InvalidUserExists ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("An error occurred during registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = _serviceProvider.GetRequiredService<LogIn>();
            loginForm.Show();
            this.Hide();
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

        private void SignUp_Load(object sender, EventArgs e)
        {
            SetRoundedButton(SignUpbt, 26);
        }
    }
}
