namespace Hostitan.API.Models
{
    public class Customers
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public Status status { get; set; } = Status.active;
        public DateTime created_at { get; set; } = DateTime.Now;
    }
}