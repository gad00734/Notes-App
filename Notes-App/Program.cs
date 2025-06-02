using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using FR_Project.Presentation;
using Digital_Notes_Manager.Forms;
namespace Digital_Notes_Manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Add configuration
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // ? ??? ?? ???????
                .AddJsonFile("appsettings.json")
                .Build();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddTransient<NoteServices>();
            services.AddTransient<AuthServices>();
            services.AddTransient<LogIn>();
            services.AddTransient<DigitalNotesForm>();
            services.AddTransient<SignUp>();
            services.AddTransient<WelcomePage>();
            services.AddTransient<MDIParentForm>();
            services.AddTransient<CreateNoteForm>();


            var serviceProvider = services.BuildServiceProvider();

            DatabaseInitializer.SeedData(serviceProvider.GetRequiredService<AppDbContext>());

            ApplicationConfiguration.Initialize();

            Application.Run(serviceProvider.GetRequiredService<LogIn>());
        }
    }
}