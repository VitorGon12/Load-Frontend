using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using countrie.Models;
using Newtonsoft.Json;
using System.Linq;

namespace countrie.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index()
        {
            var result = GetCountries();
            return View(result);
        }

        public Countries GetCountries()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"https://restcountries.com/v3.1/all");
            var _countries = JsonConvert.DeserializeObject<List<Countrie>>(json);
            var result = new Countries { countries = _countries };
            return result;
        }

        public PartialViewResult searchCountries(string filtro,string regiao)
        {
            try
            {
                if(filtro!=null)
                {

                var model = GetCountries();
                var result = new Countries { countries = model.countries.Where(x => x.name.official.ToLower().Contains(filtro) && x.region.Contains(regiao)).ToList()};
                return PartialView("_PartialView",result);
                }
                else
                {
                    var model = GetCountries();
                    var result = new Countries { countries = model.countries.Where(x => x.region.Contains(regiao)).ToList()};

                    return PartialView("_PartialView", model);

                }
            }
            catch
            {
                return PartialView();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
