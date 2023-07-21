using Microsoft.AspNetCore.Mvc;
using modelbinding.Models;
using System.Security.Cryptography;

namespace modelbinding.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            CitiesInfo model = new CitiesInfo();
           // model.CountryInfosList.Add(new CountryInfo { CId = 0, CName = "Select Country" });
            model.CountryInfosList.Add(new CountryInfo { CId = 101, CName = "India" });
            model.CountryInfosList.Add(new CountryInfo { CId = 102, CName = "Pakistan" });
            model.CountryInfosList.Add(new CountryInfo { CId = 103, CName = "England" });
            model.CountryInfosList.Add(new CountryInfo { CId = 104, CName = "China" });
            model.CountryInfosList.Add(new CountryInfo { CId = 105, CName = "America" });

            return View(model);
        }

        [HttpPost]
        public IActionResult StateData(int cid) 
        { 
            List<StateInfo> states = new List<StateInfo>()
            {
                new StateInfo(){SId=1,CId=101,SName="UP"},
                new StateInfo(){SId=2,CId=101,SName="East Punjab"},
                new StateInfo(){SId=3,CId=102,SName="West Punjab"},
                new StateInfo(){SId=4,CId=102,SName="Sindh"},
                new StateInfo(){SId=5,CId=103,SName="England"},
                new StateInfo(){SId=6,CId=103,SName="Scotland"},
                new StateInfo(){SId=7,CId=104,SName="Guangdong"},
                new StateInfo(){SId=8,CId=104,SName="Shangai"},
                new StateInfo(){SId=9,CId=105,SName="California"},
                new StateInfo(){SId=10,CId=105,SName="Newyork"},
            };
            CitiesInfo model = new CitiesInfo();
            model.StateInfosList = states.Where(s=>s.CId==cid).ToList();
            return Json(model);
        }

        [HttpPost]
        public IActionResult CityData(int sid)
        {
            List<CityInfo> citi = new List<CityInfo>()
            {
                new CityInfo(){CityId=1,SId=1,CityName="Patna"},
                new CityInfo(){CityId=2,SId=1,CityName="Allahbad"},
                new CityInfo(){CityId=3,SId=2,CityName="Amritsar"},
                new CityInfo(){CityId=4,SId=2,CityName="Chandigarh"},
                new CityInfo(){CityId=5,SId=3,CityName="Lahore"},
                new CityInfo(){CityId=6,SId=3,CityName="Gujranwala"},
                new CityInfo(){CityId=7,SId=4,CityName="Karachi"},
                new CityInfo(){CityId=8,SId=4,CityName="Hyderabad"},
                new CityInfo(){CityId=9,SId=5,CityName="London"},
                new CityInfo(){CityId=10,SId=5,CityName="Manchster"},
            };
            CitiesInfo model = new CitiesInfo();
            model.CityInfosList = citi.Where(c => c.SId == sid).ToList();
            return Json(model);
        }
    }
}
