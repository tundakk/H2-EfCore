using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApiMiljo.MODELS
{
    public class Customer
    {
        public Customer(){}
        [Key]
        public int? CustomerId { get; set; } // evt set private til set
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }

        public string? Email { get; set; }
        
        public DateTime? UserCreated { get; set; }

        //properties fra Address
        public int? AddressID { get; set; }
        
        [ForeignKey("AddressID")]

        public Address? UserAddress { get; set; }

        public Customer(string firstname, string lastname, int age, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Email = email;
            UserCreated = DateTime.Now;
        }
    }
}
