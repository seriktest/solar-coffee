using Microsoft.AspNetCore.Mvc;
using SolarCoffee.Services.Product;

namespace SolarCoffee.Web.Controllers; 

[ApiController]
public class ProductController: ControllerBase {
    private readonly Logger<ProductController> _logger;
    private readonly IProductService _productService;
    

    public ProductController(Logger<ProductController> logger, IProductService productService) {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet("/api/product")]
    public ActionResult GetProducts() {
        _logger.LogInformation("Getting All products");
        return Ok();
    }
}