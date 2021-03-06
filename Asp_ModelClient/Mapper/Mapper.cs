﻿using Asp_ModelClient.Entities;
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
                SerieId = n.SerieId,
                Authors = n.Authors,
                SerialNumber = n.SerialNumber,
                Price = n.Price,
                Informations = n.Informations,
                Langue = n.Langue,
                Dimension = n.Dimension,
                Published = n.Published,                
                TypeId = n.TypeId,
            };
        }
        public static Global.Series ToGlobal(this Series s)
        {
            return new Global.Series()
            {
                Id = s.Id,
                Nom = s.Nom
            };
        }
        public static Series ToClient(this Global.Series s)
        {
            return new Series()
            {
                Id = s.Id,
                Nom = s.Nom
            };
        }
        public static Global.Types ToGlobal(this Types t)
        {
            return new Global.Types()
            {
                Id = t.Id,
                Type = t.Type
            };
        }
        public static Types ToClient(this Global.Types t)
        {
            return new Types()
            {
                Id = t.Id,
                Type = t.Type
            };
        }
        internal static Global.User ToGlobal(this User u)
        {
            return new Global.User
            {
                Id = u.Id,
                Email = u.Email,
                Passwd = u.Passwd,
                LastName = u.LastName,
                FirstName = u.FirstName,
                Birthdate = u.Birthdate,
                Address = u.Address,
                Cp = u.Cp,
                Land = u.Land,
                Phone = u.Phone
            };
        }
        internal static User ToClient(this Global.User u)
        {
            return new User
            {
                Id = u.Id,
                Email = u.Email,
                Passwd = u.Passwd,
                LastName = u.LastName,
                FirstName = u.FirstName,
                Birthdate = u.Birthdate,
                Address = u.Address,
                Cp = u.Cp,
                Land = u.Land,
                Phone = u.Phone
            };
        }
    }
}
