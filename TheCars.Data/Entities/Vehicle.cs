using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCars.Data.Entities
{
    public abstract class Vehicle
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Make Make { get; set; }

        [Required]
        public Model Model { get; set; }

        [Required]
        [Range(1, Double.MaxValue)]
        public int YearManifactured { get; set; }

        [Required]
        public Location Location { get; set; }

        [Required]
        public bool IsNew { get; set; }

        [Required]
        public double Weight { get; set; }

        public virtual IList<VehicleExtra> Extras { get; set; }
    }
}
