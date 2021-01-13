using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API_EntitiesForm
{
    public  class UserForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        
        public string Email { get; set; }
        [DisplayName("Mot de passe")]
        [
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
