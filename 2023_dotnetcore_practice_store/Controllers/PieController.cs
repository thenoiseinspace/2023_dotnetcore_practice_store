using _2023_dotnetcore_practice_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2023_dotnetcore_practice_store.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository; 

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            ViewBag.CurrentCategory = "Cheese cakes"; 
            return View(_pieRepository.AllPies) ; 
        } 
    } 
}
