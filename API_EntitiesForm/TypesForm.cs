﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API_EntitiesForm
{
    public class TypesForm
    {
        private object id;
        private object nom;

        public TypesForm(object nom)
        {
            this.nom = nom;
        }

        public TypesForm(object id, object nom)
        {
            this.id = id;
            this.nom = nom;
        }

        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
