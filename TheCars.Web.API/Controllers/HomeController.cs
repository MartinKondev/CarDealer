using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TheCars.Web.API.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[Marto]
        public string Index(int f)
        {
            return "asdf";
        }
    }

    public class MartoAttribute : Attribute
    {
        public int MyProperty { get; set; } = 182;
    }
}