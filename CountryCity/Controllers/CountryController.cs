using CountryCity.Data;
using CountryCity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountryCity.Controllers
{
    public class CountryController : Controller
    {

        private readonly CountryContext _context;

        public CountryController(CountryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Country> allCountries = _context.Country.ToList();

            ViewBag.allCountries=allCountries;

            return View();
        }

        public JsonResult GetCity(int id)
        {
            List<City> cities = _context.City
                                .Where(x => x.CountryId == id).ToList();

            return Json(cities);
        }
    }
}
