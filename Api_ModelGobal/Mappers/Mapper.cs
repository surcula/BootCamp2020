using Api_ModelGobal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Api_ModelGobal.Mappers
{
    static class Mapper
    {
        internal static Novels ToNovels(this IDataRecord dr)
        {
            return new Novels
            {
                Id = (int)dr["Id"],
                Title = (string)dr["Title"],
                Serie = (string)dr["Serie"],
                SerieId = (int)dr["SerieId"],
                Authors = (string)dr["Authors"],
                SerialNumber = (string)dr["SerialNumber"],
                Price = (double)dr["Price"],
                Informations = (string)dr["informations"],
                Langue = (string)dr["Langue"],
                Dimension = (string)dr["Dimension"],
                Published = (DateTime)dr["Published"],
                Type = (string)dr["Type"]
            };
        }
        internal static Series ToSeries(this IDataRecord dr)
        {
            return new Series
            {
                Id = (int)dr["Id"],
                Nom = (string)dr["Nom"]
            };
        }
        internal static Types ToTypes (this IDataRecord dr)
        {
            return new Types
            {
                Id = (int)dr["Id"],
                Type = (string)dr["Type"]
            };
        }
        internal static User ToUser (this IDataRecord dr)
        {
            return new User
            {
                Id = (int)dr["Id"],
                Email = (string)dr["Email"],
                Passwd = (string)dr["passwd"],
                LastName = (string)dr["LastName"],
                FirstName = (string)dr["FirstName"],
                Birthdate = (DateTime)dr["Birthdate"],
                Address = (string)dr["Address"],
                Cp = (int)dr["Cp"],
                Land = (string)dr["Land"],
                Phone = (int)dr["Phone"]

            };
        }
    }
}
