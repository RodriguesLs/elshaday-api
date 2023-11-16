namespace elshaday_test_api.Models
{
    public class Person
    {
        public enum PersonType
        {
            legal,
            juridic
        }

        public enum RoleType
        {
            customer,
            supplier,
            employee
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public PersonType Type { get; set; }
        public string Document {  get; set; }
        public string? Nickname { get; set; }

        public RoleType Role { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
