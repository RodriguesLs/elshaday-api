using elshaday_test_api.Models;

namespace elshaday_test_api.ModelViews
{
    public class ResponseDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
