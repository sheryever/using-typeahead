using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Typeahead.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult TestData(string query)
        {

            var data = new DummyData[]
            {
                new DummyData {Value = "Alabama"}, new DummyData {Value = "Alaska"}, new DummyData {Value = "Arizona"}, new DummyData {Value = "Arkansas"},
                new DummyData {Value = "California"},
                new DummyData {Value = "Colorado"}, new DummyData {Value = "Connecticut"}, new DummyData {Value = "Delaware"}, new DummyData {Value = "Florida"},
                new DummyData {Value = "Georgia"}, new DummyData {Value = "Hawaii"},
                new DummyData {Value = "Idaho"}, new DummyData {Value = "Illinois"}, new DummyData {Value = "Indiana"}, new DummyData {Value = "Iowa"},
                new DummyData {Value = "Kansas"}, new DummyData {Value = "Kentucky"}, new DummyData {Value = "Louisiana"},
                new DummyData {Value = "Maine"}, new DummyData {Value = "Maryland"}, new DummyData {Value = "Massachusetts"}, new DummyData {Value = "Michigan"},
                new DummyData {Value = "Minnesota"},
                new DummyData {Value = "Mississippi"}, new DummyData {Value = "Missouri"}, new DummyData {Value = "Montana"}, new DummyData {Value = "Nebraska"},
                new DummyData {Value = "Nevada"}, new DummyData {Value = "new DummyData Hampshire"},
                new DummyData {Value = "new DummyData Jersey"}, new DummyData {Value = "new DummyData Mexico"}, new DummyData {Value = "new DummyData York"},
                new DummyData {Value = "North Carolina"}, new DummyData {Value = "North Dakota"},
                new DummyData {Value = "Ohio"}, new DummyData {Value = "Oklahoma"}, new DummyData {Value = "Oregon"}, new DummyData {Value = "Pennsylvania"},
                new DummyData {Value = "Rhode Island"},
                new DummyData {Value = "South Carolina"}, new DummyData {Value = "South Dakota"}, new DummyData {Value = "Tennessee"},
                new DummyData {Value = "Texas"}, new DummyData {Value = "Utah"}, new DummyData {Value = "Vermont"},
                new DummyData {Value = "Virginia"}, new DummyData {Value = "Washington"}, new DummyData {Value = "West Virginia"},
                new DummyData {Value = "Wisconsin"}, new DummyData {Value = "Wyoming"}
            };
            return Json( data.Where(d => d.Value.Contains(query)) , JsonRequestBehavior.AllowGet);
        }

        public class DummyData
        {
            public string Value { get; set; }
            public string FullName { get { return Value + " is Full Name"; } }
        }
    }
}