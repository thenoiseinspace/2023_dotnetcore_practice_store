using System.Collections;

namespace _2023_dotnetcore_practice_store.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable <Pie> Pies { get; set; }
        //he creates a Using Statement for pie above, but doesn't say how he does it. He selects using BethanysPieShop.Models;
        //hit alt enter for something close
        public string CurrentCategory { get; set; }
    }
}
