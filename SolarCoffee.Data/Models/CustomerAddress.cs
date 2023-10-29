using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models;

public class CustomerAddress
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
    
    [MaxLength(100)]
    public string AddressLine1 { get; set; } = string.Empty;
    [MaxLength(100)]
    public string AddressLine2 { get; set; } = string.Empty;
    [MaxLength(32)]
    public string City { get; set; } = string.Empty;
    [MaxLength(10)]
    public string State { get; set; } = string.Empty;
    [MaxLength(10)]
    public string PostalCode { get; set; } = string.Empty;
    [MaxLength(30)]
    public string Country { get; set; } = string.Empty;
}