namespace elshaday_test_api.Models
{
    public class User
    {

        public enum AdminRole
        {
            admin,
            user
        }
        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public AdminRole Role { get; set; }
    }
}
