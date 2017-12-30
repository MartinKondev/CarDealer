using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheCars.Data.Entities
{
    public class FuelType
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IList<Car> Cars { get; set; }
    }
}