using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCars.Data.Entities
{
    public class Car : Vehicle
    {
        public int SeatsCount { get; set; }

        [Required]
        public bool AutomaticGear { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        [Required]
        public double Size { get; set; }

        [Required]
        public bool Is4x4 { get; set; }
    }
}
