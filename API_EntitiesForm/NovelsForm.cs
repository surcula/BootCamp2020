using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API_EntitiesForm
{
    public class NovelsForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public int SerieId { get; set; }
        [Required]
        [MaxLength(75)]
        public string Serie { get; set; }
        [Required]
        [MaxLength(50)]
        public string Authors { get; set; }
        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Informations { get; set; }
        [Required]
        [MaxLength(50)]
        public string Langue { get; set; }
        [Required]
        [MaxLength(20)]
        public string Dimension { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Published { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        public int TypeId { get; set; }
    }
}
