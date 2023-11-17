namespace elshaday_test_api.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonId { get; set; }
        public Person? Person { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
