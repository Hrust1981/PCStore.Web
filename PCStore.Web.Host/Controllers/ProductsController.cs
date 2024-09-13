using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using PCStore.Web.Core.Abstractions.Products;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.ModelsDto.Update;

namespace PCStore.Web.Host.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductsController(IProductsService productService) : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        [HttpPost]
        public async Task<ActionResult<ProductsDto>> CreateProduct([FromBody] CreateProductsDto createProduct)
        {
            var product = await productService.CreateProductAsync(createProduct);
            return Ok(product);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProductsDto>> GetProduct(Guid id)
        {
            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        [HttpGet]
        public async Task<ActionResult<ProductsDto>> GetAllProducts()
        {
            var products = await productService.GetAllProductsAsync();
            return Ok(products);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        public async Task<ActionResult<ProductsDto>> UpdateProduct([FromBody] UpdateProductsDto updateProduct)
        {
            var product = await productService.GetProductByIdAsync(updateProduct.Id);
            if (product == null)
            {
                return NotFound();
            }
            var updatableProduct = await productService.UpdateProductAsync(updateProduct);
            return Ok(updatableProduct);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeleteProduct(Guid id)
        {
            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var isProductDeleted = await productService.DeleteProductAsync(id);
            return Ok(isProductDeleted);
        }
    }
}
