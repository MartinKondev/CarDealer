using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheCars.Data.Entities
{
    public class Car : Vehicle
    {
        [Range(1, 100)]
        public int SeatsCount { get; set; }

        [Required]
        public bool AutomaticGear { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        [Required]
        [Range(0.1, 100)]
        public double EngineSize { get; set; }

        [Required]
        public bool Is4x4 { get; set; }
    }
}
