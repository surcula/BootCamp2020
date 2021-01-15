using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api_ModelClient.Entities
{
    public class Novels
    {
        public Novels()
        {

        }

        public Novels(string title, int serieId, string serie, string authors, string serialNumber, double price, string informations,string langue, string dimension, DateTime published, string type,int typeId)
        {
            
            Title = title;
            SerieId = serieId;
            Serie = serie;
            Authors = authors;
            SerialNumber = serialNumber;
            Price = price;
            Informations = informations;
            Langue = langue;
            Dimension = dimension;
            Published = published;
            Type = type;
            TypeId = typeId;
        }

        public Novels(int id, string title, int serieId, string serie, string authors, string serialNumber, double price, string informations, string langue, string dimension, DateTime published, string type, int typeId)
        {
            Id = id;
            Title = title;
            SerieId = serieId;
            Serie = serie;
            Authors = authors;
            SerialNumber = serialNumber;
            Price = price;
            Informations = informations;
            Langue = langue;
            Dimension = dimension;
            Published1 = published;
            Type = type;
            TypeId = typeId;
        }

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
        public int TypeId { get; set; }
        public DateTime Published1 { get; }
    }
}
