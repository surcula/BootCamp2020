using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_ProjetPersoBootcamp2020.Models
{
    public  class UserForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        
        public string Email { get; set; }
        [DisplayName("Mot de passe")]
        [MaxLength(20)]
        [Required]
        public string Passwd { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthdate { get; set; }
        [MaxLength(50)]
        [Required]
        public string Address { get; set; }
        
        [Required]
        public int Cp { get; set; }
        [MaxLength(50)]
        [Required]
        public string Land { get; set; }
        [MaxLength(15)]
        [Required]
        public string Phone { get; set; }
    }
}
