using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Asp_ModelGlobal.Entities
{
    public class Types
    {
        public Types(int id, string type)
        {
            Id = id;
            Type = type;
        }
        public Types()
        {

        }
        public int Id { get; set; }    
        public string  Type { get; set; }       
    }
}
