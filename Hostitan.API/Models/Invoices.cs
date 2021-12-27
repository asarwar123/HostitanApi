namespace Hostitan.API.Models
{
    public class Invoices
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public Guid subs_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime due_date { get; set; }
        public Status status {get;set;} = Status.active;
    }
}