using System.ComponentModel.DataAnnotations;

namespace webApiMiljo.MODELS
{
    public class Address
    {
        public Address()
        {

        }
        [Key]
        public int? AddressID { get; set; }
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? City { get; set; }
        public int? CityZipCode { get; set; }

        public Address(string streetName, string streetNumber, string city, int cityZipCode)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            CityZipCode = cityZipCode;

        }
    }
}
