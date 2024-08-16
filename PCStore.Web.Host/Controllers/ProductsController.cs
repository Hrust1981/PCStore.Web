using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using PCStore.Web.Core.Abstractions.Products;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.EntitiesDTO.Update;

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
        public async Task<ActionResult<ProductsEntityDTO>> CreateProduct([FromBody] CreateProductsEntity createProduct)
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
        public async Task<ActionResult<ProductsEntityDTO>> GetProduct(Guid id)
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
        public async Task<ActionResult<ProductsEntityDTO>> GetAllProducts()
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
        public async Task<ActionResult<ProductsEntityDTO>> UpdateProduct([FromBody] UpdateProductsEntity updateProduct)
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
            var isProductDeleted = await productService.DeleteProductAsync(id);
            if (!isProductDeleted)
            {
                return NotFound();
            }
            return Ok(isProductDeleted);
        }
    }
}
