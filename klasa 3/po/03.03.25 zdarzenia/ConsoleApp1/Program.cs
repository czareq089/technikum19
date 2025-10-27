using System.Security.Cryptography;
using System.Text;

class Program
{
    public enum Role
    {
        Administrator,
        Manager,
        User
    }

    public class User
    {
        public string username { get; set; }
        public List<Role> Roles { get; set; }

        public User(string Username)
        {
            username = Username;
            Roles = new List<Role>();
        }

        public void AddRole(Role role)
        {
            if (!Roles.Contains(role))
            {
                Roles.Add(role);
            }
        }
    }

    public class RBAC
    {
        //RBAC  -->   Role Base Access Control
        private readonly Dictionary<Role, List<string>> rolePermission;

        public RBAC()
        {
            rolePermission = new Dictionary<Role, List<string>>()
            {

                { Role.Administrator, new List<string>() { "Read", "Write", "Delete" } },
                { Role.Manager, new List<string>() { "Read", "Write" } },
                { Role.User, new List<string>() { "Read" } }
            };
        }

        bool HasPermission(User user, string permission)
        {
            foreach (var role in user.Roles)
            {
                if (rolePermission.ContainsKey(role) && rolePermission[role].Contains(permission))
                {
                    return true;
                }
            }
            return false;
        }

    }

    public class PasswordManager
    {
        private const string passwordFilePath = "userPasswords.txt";
        public static event Action<string, bool> PasswordVerified;

        static PasswordManager()
        {
            if (!File.Exists(passwordFilePath))
            {
                File.Create(passwordFilePath).Dispose();
            }
        }

        public static void SavePassword(string username, string password)
        {
            if (File.ReadLines(passwordFilePath).Any(line => line.Split(',')[0] == username))
            {
             Console.WriteLine($"Użytkownik {username} już istnieje");
             return;
            }

            string hashedPassword = HashPassword(password);
            File.AppendAllText(passwordFilePath, $"{username},{hashedPassword}\n");
            Console.WriteLine($"Użytkownik {username} został dodany pomyślnie");
        }

        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
               var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); 
               return Convert.ToBase64String(bytes);
            }
        }

        public static bool VerifyPassword(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            foreach (var line in File.ReadLines(passwordFilePath))
            {
                var parts = line.Split(',');
                if (parts[0] == username && parts[1] == hashedPassword)
                {
                     PasswordVerified.Invoke(username, true);
                }
            }
            PasswordVerified.Invoke(username, false);
            return false;
        }
        
    }

    public static void Main(string[] args)
    {
        PasswordManager.PasswordVerified += (username, success) =>
            Console.WriteLine($"Logowanie użytkownika {username}: {(success ? "udane" : "nieudane")}");
        
        PasswordManager.SavePassword("admin", "admin");
        Console.WriteLine("Wprowadź użytkownika: ");
        string username = Console.ReadLine();
        Console.WriteLine("Wprowadź hasło: ");
        string password = Console.ReadLine();

        if (!PasswordManager.VerifyPassword(username, password))
        {
            Console.WriteLine("Niepoprawna nazwa użytkownika lub hasło!");
            return;
        }

        Console.WriteLine("Zalogowano pomyślnie!");
        
    }
}