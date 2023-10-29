using Microsoft.AspNetCore.Mvc;
using SolarCoffee.Services.Product;
using SolarCoffee.Web.Serialization;

namespace SolarCoffee.Web.Controllers; 

[ApiController]
public class ProductController: ControllerBase {
    private readonly ILogger<ProductController> _logger;
    private readonly IProductService _productService;
    

    public ProductController(ILogger<ProductController> logger, IProductService productService) {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet("/api/product")]
    public ActionResult GetProducts() {
        _logger.LogInformation("Getting All products");
        var products = _productService.GetAllProducts();
        var productsViewModel = products.Select(ProductMapper.SerializeProductModel);
        return Ok(productsViewModel);
    }
}