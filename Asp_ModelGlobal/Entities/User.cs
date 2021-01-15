using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Asp_ModelGlobal.Entities
{
    public class User
    {
        public User(int id, string email, string passwd, string lastName, string firstName, DateTime birthdate, string address, int cp, string land, string phone)
        {
            Id = id;
            Email = email;
            Passwd = passwd;
            LastName = lastName;
            FirstName = firstName;
            Birthdate = birthdate;
            Address = address;
            Cp = cp;
            Land = land;
            Phone = phone;
        }
        public User()
        {

        }
        public int Id { get; set; }
       
        public string Email { get; set; }
        
        public string Passwd { get; set; }
        
        public string LastName { get; set; }
        
        public string FirstName { get; set; }
        
        public DateTime Birthdate { get; set; }
        
        public string Address { get; set; }
       
        public int Cp { get; set; }
        public string Land { get; set; }

        public string Phone { get; set; }
     
    }
}
