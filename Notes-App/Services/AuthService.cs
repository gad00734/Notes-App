using Digital_Notes_Manager.Exceptions;
using Digital_Notes_Manager.Utilities;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Digital_Notes_Manager
{
    public class AuthServices
    {
        private readonly AppDbContext _context;
        public  AuthServices(AppDbContext context)
        {
            _context = context;
        }

       public void Login(string userName,string password)
       {
         var user = _context.Users.FirstOrDefault(x=>x.Username.Equals(userName)
         && x.PasswordHash==password);

           if (user == null)
                throw new InvalidUserNotExists($"Can`t Find User {userName}");
        }
        public void CreateUser(string username, string password)
        {
            if (ChickIfUserAlreadySignUp(username))
                throw new InvalidUserExists($"User {username} Already Exist");
            
            User user = new User();
            user.Username = username;
            user.PasswordHash = password;
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public bool ChickIfUserAlreadySignUp(string userName)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == userName);
            return user != null;
        }
        public User GetUser(string userName)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == userName);
            if (user != null)
                throw new NullReferenceException("Can`t Find User Please make Sure valid UserName");
            return user;
        }

        public int LoadUserId(string userName)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == userName);
            if (user != null)
                return user.UserId;
            throw new NullReferenceException("Can`t Find User Please make Sure valid UserName");
        }
    }
}
