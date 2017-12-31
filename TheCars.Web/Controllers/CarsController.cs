using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using TheCars.Data.Repositories;
using Newtonsoft.Json;
using TheCars.Data.Entities;

namespace TheCars.Web.Controllers
{
    public class CarsController : ApiController
    {
        CarRepository carRepository;

        public CarsController()
        {
            carRepository = new CarRepository(); 
        }

        [HttpGet]
        public async Task<JsonResult<IList<Car>>> GetAllCars()
        {
            var cars = await carRepository.GetAll();
            var result = Json(cars);
            return result;
        }
    }
}