using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASP_ProjetPersoBootcamp2020.Models
{
    public class NovelsForm
    {
        public NovelsForm()
        {
        }

        public NovelsForm(int id, string title, int serieId,string authors, string serialNumber, double price, string informations, string langue, string dimension, DateTime published, int typeId)
        {
            Id = id;
            Title = title;
            SerieId = serieId;
            Authors = authors;
            SerialNumber = serialNumber;
            Price = price;
            Informations = informations;
            Langue = langue;
            Dimension = dimension;
            Published = published;
            TypeId = typeId;
        }
       
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public int SerieId { get; set; } 
        public IEnumerable<SelectListItem> Series { get; set; }
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
        public int TypeId { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
    }
}
