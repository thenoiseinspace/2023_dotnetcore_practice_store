using System.Collections;

namespace _2023_dotnetcore_practice_store.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
