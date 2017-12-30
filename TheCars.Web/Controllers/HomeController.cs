using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace TheCars.Web.Controllers
{
    public class HomeController : ApiController
    {
        public HomeController()
        {

        }

        [HttpGet]
        public string Test()
        {
            return "Gotovo";
        }

        //[HttpGet]
        //public string TestJson()
        //{
        //    return "asdf".
        //}
    }
}
