namespace elshaday_test_api.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
