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

            var data = State.GetDummyData();
            return Json( data.Where(d => d.Number.ToString().Contains(query) ) , JsonRequestBehavior.AllowGet);
        }


    }
    public class State
    {
        public State()
        {
 
        }
        public string Number { get; set; }
       public string Name { get; set; }

       public static State[] _States { get; set; }
        public static State[] GetDummyData()
        {
            var randum = new Random(125333);
            
            return _States ?? (_States = new State[]
            {
                new State {Name = "Alabama", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Alaska", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Arizona", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Arkansas", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "California", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Colorado", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Connecticut", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Delaware", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Florida", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Georgia", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Hawaii", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Idaho", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Illinois", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Indiana", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Iowa", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Kansas", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Kentucky", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Louisiana", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Maine", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Maryland", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Massachusetts", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Michigan", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Minnesota", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Mississippi", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Missouri", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Montana", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Nebraska", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Nevada", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "new State Hampshire", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "new State Jersey", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "new State Mexico", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "new State York", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "North Carolina", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "North Dakota", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Ohio", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Oklahoma", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Oregon", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Pennsylvania", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Rhode Island", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "South Carolina", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "South Dakota", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Tennessee", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Texas", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Utah", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Vermont", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Virginia", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Washington", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "West Virginia", Number = randum.Next(340000, 900000).ToString()},
                new State {Name = "Wisconsin", Number = randum.Next(340000, 900000).ToString()}, new State {Name = "Wyoming", Number = randum.Next(340000, 900000).ToString()}
            });
        }
    }
}