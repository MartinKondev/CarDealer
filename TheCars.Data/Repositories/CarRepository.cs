using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCars.Data.Entities;

namespace TheCars.Data.Repositories
{
    public class CarRepository : GenericRepository<Car>
    {
        //public IList<Car> Search(Car searchDTO)
        //{
        //    var props = searchDTO.GetType().GetProperties();
        //    var query = context.Cars.All();

        //    foreach (var prop in props)
        //    {
        //        var key = nameof(prop);
        //        var value = prop.GetValue(prop);
        //        query.
        //    }
        //    return new List<Car>();
        //}
    }
}
