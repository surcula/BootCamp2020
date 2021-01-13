using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api_ModelClient.Entities
{
    public class User
    {
       
        public int Id { get; set; }
       
        public string Email { get; set; }
        
        public string Passwd { get; set; }
        
        public string LastName { get; set; }
        
        public string FirstName { get; set; }
        
        public DateTime Birthdate { get; set; }
        
        public string Address { get; set; }
       
        public int Cp { get; set; }
        public string Land { get; set; }

        public int Phone { get; set; }

    }
}
