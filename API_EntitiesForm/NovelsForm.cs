﻿using System;
using System.Collections.Generic;
using System.Text;

namespace API_EntitiesForm
{
    public class NovelsForm
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
