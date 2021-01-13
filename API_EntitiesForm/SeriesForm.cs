using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API_EntitiesForm
{
    public class SeriesForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string Nom { get; set; }
    }
}
