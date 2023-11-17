using elshaday_test_api.Models.Enumerables;

namespace elshaday_test_api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PersonType Type { get; set; }
        public string Document {  get; set; }
        public string? Nickname { get; set; }

        public RoleType Role { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Department> Departments { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
