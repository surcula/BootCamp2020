﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Asp_ModelClient.Entities
{
    public class Novels
    {
        public Novels()
        {

        }

        public Novels(int id, string title, int serieId, string authors, string serialNumber, double price, string informations, string langue, string dimension, DateTime published, int typeId)
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
    }
}

