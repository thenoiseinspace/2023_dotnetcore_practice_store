using System.Collections;

namespace _2023_dotnetcore_practice_store.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category>AllCategories =>
               new ArrayList<Category>
               {
                   new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruity pies"}
                   new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"}
                   new Category{CategoryId=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
               }
    }
}
