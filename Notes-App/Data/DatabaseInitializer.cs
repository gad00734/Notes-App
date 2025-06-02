
using Microsoft.EntityFrameworkCore;

namespace Digital_Notes_Manager
{
    public static class DatabaseInitializer
    {

        public static void SeedData(AppDbContext context)
        {
            context.Database.Migrate();
            if (!context.Users.Any())
            {
                context.Users.AddRange(new[]{
                    new User { Username = "admin", PasswordHash = "hashedpassword123" },
                    new User  { Username = "user1", PasswordHash = "hashedpassword456" }
                });

                context.SaveChanges();
            }

            if (!context.Notes.Any())
            {
                context.AddRange(new[]{
                    new Note
                    {
                     
                        Title = "Meeting Notes",
                        Content = "Discuss project deadlines with the team. Follow up on client feedback.",
                        Category = "Work",
                        CreationDate = DateTime.Now.AddDays(-5),
                        ReminderDate = DateTime.Now.AddDays(1),
                        UserID = 1 // Assume UserID 1 exists
                    },
                    new Note
                    {
                        Title = "Grocery List",
                        Content = "Milk, eggs, bread, vegetables, and coffee.",
                        Category = "Personal",
                        CreationDate = DateTime.Now.AddDays(-3),
                        ReminderDate = null, // No reminder
                        UserID = 1
                    },
                    new Note
                    {
                        Title = "Book Ideas",
                        Content = "Sci-fi novel outline: AI rebellion in 2050.",
                        Category = "Ideas",
                        CreationDate = DateTime.Now.AddDays(-2),
                        ReminderDate = DateTime.Now.AddDays(7),
                        UserID = 2 // Assume UserID 2 exists
                    },
                    new Note
                    {
                        Title = "Fitness Plan",
                        Content = "Monday: Cardio, Wednesday: Weights, Friday: Yoga.",
                        Category = "Health",
                        CreationDate = DateTime.Now.AddDays(-1),
                        ReminderDate = DateTime.Now.AddDays(3),
                        UserID = 2
                    },
                    new Note
                    {
                        Title = "Project Tasks",
                        Content = "1. Fix login bug. 2. Update documentation. 3. Test search feature.",
                        Category = "Work",
                        CreationDate = DateTime.Now,
                        ReminderDate = DateTime.Now.AddHours(2), // Near-future reminder
                        UserID = 1

                    }
                }

                 );
                context.SaveChanges();
            }
        }
    }
}