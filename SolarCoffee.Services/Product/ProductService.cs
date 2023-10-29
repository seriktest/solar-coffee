using SolarCoffee.Data;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Services.Product; 

public class ProductService : IProductService {
    private readonly SolarDbContext _db;
    public ProductService(SolarDbContext db) {
        _db = db;
    }

    /// <summary>
    /// Retrieves all products from the database.
    /// </summary>
    /// <returns>A collection of Product objects.</returns>
    public ICollection<Data.Models.Product> GetAllProducts() {
        return _db.Products.ToList();
    }

    /// <summary>
    /// Retrieves a product from the database by its ID.
    /// </summary>
    /// <param name="id">The ID of the product to retrieve.</param>
    /// <returns>The product with the specified ID.</returns>
    public Data.Models.Product GetProductById(int id) {
        return _db.Products.Find(id);
    }

    /// <summary>
    /// Creates a new product in the database and returns a ServiceResponse object
    /// containing the created product, a success flag, a timestamp, and a message.
    /// </summary>
    /// <param name="product">The product to be created.</param>
    /// <returns>A ServiceResponse object containing the created product, a success flag,
    /// a timestamp, and a message.</returns>
    public ServiceResponse<Data.Models.Product> CreateProduct(Data.Models.Product product) {
        try {
            _db.Add(product);
            
            var inventory = new ProductInventory {
                Product = product,
                InQuantityOnHand = 0,
                IdealQuantity = 10
            };
            _db.ProductInventories.Add(inventory);
            
            _db.SaveChanges();

            return new ServiceResponse<Data.Models.Product> {
                Success = true,
                Data = product,
                Time = DateTime.UtcNow,
                Message = "Product created",
            };
        }
        catch (Exception e) {
            return new ServiceResponse<Data.Models.Product> {
                Success = false,
                Data = product,
                Time = DateTime.UtcNow,
                Message = e.StackTrace
            };
        }
    }

    /// <summary>
    /// Archives a product by marking it as archived in the database.
    /// </summary>
    /// <param name="id">The ID of the product to archive.</param>
    /// <returns>A ServiceResponse containing the archived product,
    /// or an error message if the operation failed.</returns>
    public ServiceResponse<Data.Models.Product> ArchiveProduct(int id) {
        try {
            var product = _db.Products.Find(id);
            if (product != null) product.IsArchived = true;
            _db.SaveChanges();
            return new ServiceResponse<Data.Models.Product> {
                Success = true,
                Data = product,
                Time = DateTime.UtcNow,
                Message = "Product archived"
            };
        }
        catch (Exception e) {
            return new ServiceResponse<Data.Models.Product> {
                Success = false,
                Data = null,
                Time = DateTime.UtcNow,
                Message = e.StackTrace
            };
        }
    }
}