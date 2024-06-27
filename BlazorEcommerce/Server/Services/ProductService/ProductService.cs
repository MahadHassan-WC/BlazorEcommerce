
namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new  ServiceResponse<Product>(); 
            var product = await _context.Products.FindAsync(productId); 
            if (product == null)
            {
                response.Success = false;
                response.Message = $"Product not found for this id:{productId}";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async  Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync() 

            };  
            return response;
        }
    }
}
