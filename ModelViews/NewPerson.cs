using elshaday_test_api.Models;
using elshaday_test_api.Models.Enumerables;

namespace elshaday_test_api.ModelViews
{
    public class NewPerson
    {
        public string Name { get; set; }
        public PersonType Type { get; set; }
        public string Document { get; set; }
        public string? Nickname { get; set; }
        public RoleType Role { get; set; }
        public NewAddress Address { get; set; }
    }
}
