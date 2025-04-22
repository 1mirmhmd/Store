using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        // Önerilmeyen kullanım!
        private readonly IServiceManager _manager;
        // Dosya adı konusunda sorunla karşılaşması durumunda haa vereceğinden dolayı ViewComponent eklenir
        public ProductSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.ProductService.GetAllProducts(false).Count().ToString();
        }
    }
}