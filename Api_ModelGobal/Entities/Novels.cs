using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api_ModelGobal.Entities
{
    public class Novels
    {
       
        public int Id { get; set; }
        public string Title { get; set; }       
        public int SerieId { get; set; }
        public string Serie { get; set; }       
        public string Authors { get; set; }       
        public string SerialNumber { get; set; }       
        public double Price { get; set; }        
        public string Informations { get; set; }        
        public string Langue { get; set; }       
        public string Dimension { get; set; }        
        public DateTime Published { get; set; }        
        public string Type { get; set; }
    }
}
