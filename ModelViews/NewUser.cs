using elshaday_test_api.Models.Enumerables;

namespace elshaday_test_api.ModelViews
{
    public class NewUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public AdminRole Role { get; set; }
    }
}
