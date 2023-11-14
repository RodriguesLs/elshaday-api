namespace elshaday_test_api.Models
{
    public class Person
    {
        public enum PersonType
        {
            legal,
            juridic
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public PersonType Type { get; set; }
        public string Document {  get; set; }
        public string Nickname { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
