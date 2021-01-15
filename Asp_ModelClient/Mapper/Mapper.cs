using Asp_ModelClient.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Global = Asp_ModelGlobal.Entities;

namespace Asp_ModelClient.Mapper
{
    public static class Mapper
    {
        public static Global.Novels ToGobal(this Novels n)
        {
            return new Global.Novels()
            {
                Id = n.Id,
                Title = n.Title,
                Serie = n.Serie,
                SerieId = n.SerieId,
                Authors = n.Authors,
                SerialNumber = n.SerialNumber,
                Price = n.Price,
                Informations = n.Informations,
                Langue = n.Langue,
                Dimension = n.Dimension,
                Published = n.Published,
                Type = n.Type,
                TypeId = n.TypeId

            };
        }
        public static Novels ToClient(this Global.Novels n)
        {
            return new Novels()
            {
                Id = n.Id,
                Title = n.Title,
                Serie = n.Serie,
                SerieId = n.SerieId,
                Authors = n.Authors,
                SerialNumber = n.SerialNumber,
                Price = n.Price,
                Informations = n.Informations,
                Langue = n.Langue,
                Dimension = n.Dimension,
                Published = n.Published,
                Type = n.Type,
                TypeId = n.TypeId,
            };
        }
    }
}
