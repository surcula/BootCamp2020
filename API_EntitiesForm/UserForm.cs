using System;

namespace API_EntitiesForm
{
    public  class UserForm
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
