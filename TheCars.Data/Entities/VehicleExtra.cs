using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCars.Data.Entities
{
    public class VehicleExtra
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IList<Vehicle> Cars { get; set; }
    }
}
