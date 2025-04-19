using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        // yukarıdaki iki satır seçilerek Servicemanager ctor oluşturuldu 
        public ServiceManager(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;
    }
}