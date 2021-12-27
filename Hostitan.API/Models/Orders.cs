namespace Hostitan.API.Models
{
    public class Orders
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public Guid customer_id { get; set; }
        public Status status { get; set; } = Status.placed;
        public DateTime created_at { get; set; }
        
    }
}