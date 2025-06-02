using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using FR_Project.Presentation;
using Digital_Notes_Manager.Forms;
using Digital_Notes_Manager.Utilities;
using Microsoft.Extensions.Hosting;

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
            // Move service configuration to CreateHostBuilder
            // var services = new ServiceCollection();

            // Add configuration
            // var configuration = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json")
            //     .Build();

            // services.AddDbContext<AppDbContext>(options =>
            //     options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // services.AddTransient<NoteServices>();
            // services.AddTransient<AuthServices>();
            // services.AddTransient<FR_Project.Presentation.LogIn>();
            // services.AddTransient<DigitalNotesForm>();
            // services.AddTransient<FR_Project.Presentation.SignUp>();
            // services.AddTransient<WelcomePage>();
            // services.AddTransient<MDIParentForm>();
            // services.AddTransient<CreateNoteForm>();

            var host = CreateHostBuilder().Build();
            var serviceProvider = host.Services;

            DatabaseInitializer.SeedData(serviceProvider.GetRequiredService<AppDbContext>());

            ApplicationConfiguration.Initialize();

            // Change the startup form to WelcomePage
            Application.Run(serviceProvider.GetRequiredService<FR_Project.Presentation.WelcomePage>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Add configuration
                    var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

                    services.AddTransient<NoteServices>();
                    services.AddTransient<AuthServices>();
                    services.AddTransient<FR_Project.Presentation.LogIn>();
                    services.AddTransient<DigitalNotesForm>();
                    services.AddTransient<FR_Project.Presentation.SignUp>();
                    services.AddTransient<WelcomePage>();
                    services.AddTransient<MDIParentForm>();
                    services.AddTransient<CreateNoteForm>();
                    services.AddTransient<EditNoteForm>();
                    services.AddTransient<DeleteNoteForm>();

                });
        }
    }
}