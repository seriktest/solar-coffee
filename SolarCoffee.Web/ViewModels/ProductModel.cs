namespace SolarCoffee.Web.ViewModels; 
/// <summary>
/// Product entity DTO
/// </summary>
public class ProductModel {
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0;
    public  bool IsTaxable { get; set; } = false;
    public bool IsArchived { get; set; } = false;
}