namespace SolarCoffee.Data.Models;

public class SalesOrder
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public Customer Customer { get; set; } = null!;
    public ICollection<SalesOrderItem> SalesOrderItems { get; set; } = null!;
    public bool IsPaid { get; set; }
}