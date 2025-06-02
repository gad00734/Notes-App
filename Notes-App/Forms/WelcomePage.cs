using Microsoft.Extensions.DependencyInjection;
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
    public partial class WelcomePage : Form
    {
        IServiceProvider _serviceProvider;
        public WelcomePage(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            SetRoundedButton(SignUp, 26);
            SetRoundedButton(LogInbt, 26);
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

        private void GetStartbt_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<SignUp>().Show();
           
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInbt_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<LogIn>().Show();
            this.Hide();
        }
    }
}
