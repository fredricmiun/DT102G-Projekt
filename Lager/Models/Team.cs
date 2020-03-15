using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Lager.Models
{
    public class Team
    {
        public int Id { get; set; }
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Surname")]
        public string LastName { get; set; }
        [DisplayName("Biography")]
        public string Bio { get; set; } 

    }
}
