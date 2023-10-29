using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models;

public class Customer
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(200)]
    public string LastName { get; set; } = string.Empty;
    
    public virtual CustomerAddress PrimaryAddresses { get; set; } = null!;
}