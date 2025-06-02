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
        AuthServices _authServices;
        private readonly IServiceProvider _serviceProvider;

        public LogIn(AuthServices authServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authServices = authServices;
            _serviceProvider = serviceProvider;
        }

        private void SignUpbt_Click(object sender, EventArgs e)
        {
            try
            {
                _authServices.Login(txtUserName.Text, txtPassword.Text);
                DialogResult result = MessageBox.Show("LOGIN SUCCESS ^^ ");

                SessionManager.UserName = txtUserName.Text;
                SessionManager.SetPassword(txtPassword.Text);

                if (result == DialogResult.OK)
                {
                    using (var context = new AppDbContext())
                    {
                        var user = context.Users.FirstOrDefault(u => u.Username == txtUserName.Text);
                        if (user != null)
                        {
                            var mdiParent = new MDIParentForm(user.UserId); // إنشاء MDIParentForm
                            NotesListForm notesListForm = new NotesListForm(mdiParent); // تمرير mdiParent إلى NotesListForm
                            CreateNoteForm createNoteForm = new CreateNoteForm(user.UserId, notesListForm, mdiParent); // تمرير mdiParent إلى CreateNoteForm
                            mdiParent.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (InvalidUserNotExists ex)
            {
                DialogResult result = MessageBox.Show(
                    $"Error: {ex?.Message} Do You Want Create Account?",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    _serviceProvider.GetRequiredService<SignUp>().Show();
                    this.Hide();
                }
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

        private void dontHaveAnAccountBTN(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<SignUp>().Show();
            this.Hide();
        }
    }
}
