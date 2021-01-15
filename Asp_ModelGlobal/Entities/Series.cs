using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Asp_ModelGlobal.Entities
{
    public class Series
    {
        public Series(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
        public Series()
        {

        }
        public int Id { get; set; }

        public string Nom { get; set; }
    }
}
