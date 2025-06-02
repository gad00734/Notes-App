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

namespace FR_Project.Presentation
{
    public partial class SignUp : Form
    {
        AuthServices _authServices;
        public SignUp(AuthServices  authServices)
        {
            InitializeComponent();
            _authServices = authServices;
            
        }

        private void SignUpbt_Click(object sender, EventArgs e)
        {
            string? userName = UserNametxt.Text;
            string? password = Passwordtxt.Text;
            if (userName != null && userName.Trim() != ""
                && password != null && password.Trim() != null)
            {
                try
                {
                    _authServices.CreateUser(userName, password);
                }
                catch (InvalidUserExists ex)
                {
                    MessageBox.Show(ex.Message);

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error !");
                }

            }
            else
            {
                MessageBox.Show("User Name Or password is Empty");
            }

            /*if (userOperation.EmaiAlreadyExists(Emailtxt.Text))
            {
                MessageBox.Show("This email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!userOperation.ValaidEmail(Emailtxt.Text))
            {
                MessageBox.Show("Please enter invalaid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = userOperation.CreateNewUser(UserNametxt.Text, Emailtxt.Text, Passwordtxt.Text);
            if (user == null)
            {
                MessageBox.Show("Please Try again To Sign Up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sign Up Successful ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }
*/

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
