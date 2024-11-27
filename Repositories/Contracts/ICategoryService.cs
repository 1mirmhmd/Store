using Entities.Models;

namespace Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category>GetAllCategories(bool trackChanges);
    }
}