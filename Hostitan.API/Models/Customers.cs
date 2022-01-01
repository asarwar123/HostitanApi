using System.ComponentModel.DataAnnotations;

namespace Hostitan.API.Models
{
    public class Customers
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(32)]
        public string first_name { get; set; }

        [Required] 
        [MaxLength(32)]
        public string last_name { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MaxLength(16)]
        public string city { get; set; }
        
        public Status status { get; set; } = Status.active;

        [DataType(DataType.DateTime)]
        public DateTime created_at { get; set; } = DateTime.Now;
        public Customers(){}
        
        public Customers(string _firstname,string _lastname,string _city,string _email)
        {
            this.first_name = _firstname;
            this.last_name = _lastname;
            this.city = _city;
            this.email = _email;
        }

    }
}