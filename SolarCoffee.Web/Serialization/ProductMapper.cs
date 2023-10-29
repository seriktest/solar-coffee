using SolarCoffee.Data.Models;
using SolarCoffee.Web.ViewModels;

namespace SolarCoffee.Web.Serialization; 

/// <summary>
/// Serializes a Product object into a ProductModel object.
/// </summary>
/// <param name="product">The Product object to be serialized.</param>
/// <returns>A new ProductModel object with the serialized data.</returns>
public class ProductMapper {
    public static ProductModel SerializeProductModel(Product product) {
        return new ProductModel {
            Id = product.Id,
            CreatedOn = product.CreatedOn,
            UpdatedOn = product.UpdatedOn,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            IsTaxable = product.IsTaxable,
            IsArchived = product.IsArchived
        };
    }
    
    /// <summary>
    /// Serializes a ProductModel object into a Product object.
    /// </summary>
    /// <param name="product">The ProductModel object to serialize.</param>
    /// <returns>The serialized Product object.</returns>
    public static Product SerializeProductModel(ProductModel product) {
        return new Product {
            Id = product.Id,
            CreatedOn = product.CreatedOn,
            UpdatedOn = product.UpdatedOn,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            IsTaxable = product.IsTaxable,
            IsArchived = product.IsArchived
        };
    }
}


