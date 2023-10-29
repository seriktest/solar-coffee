namespace SolarCoffee.Data.Models;

public class Customer
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    
    public virtual ICollection<CustomerAddress> PrimaryAddresses { get; set; } = null!;
}