using System.Collections;

namespace _2023_dotnetcore_practice_store.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pies> AllPies =>
            new List<Pie>
            {
                new Pie {PieId= 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"},
                new Pie {PieId= 2, Name="Cheesecake", Price=18.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"},
                new Pie {PieId= 3, Name="Rhubarb Pie", Price=15.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"},
                new Pie {PieId= 4, Name="Pumpkin Pie", Price=12.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"},
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstorDefault(p => p.PieId == pieId);
        }
    }
}
