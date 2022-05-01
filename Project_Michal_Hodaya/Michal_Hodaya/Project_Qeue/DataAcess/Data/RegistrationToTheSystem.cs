using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class RegistrationToTheSystem
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string BusinessName { get; set; }
        [Required]
        public string TypeOfBusiness { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int MobilePhoneNumber { get; set; }

    }
}
