using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace moment3._2.Models
{
    public class User
    {
        public User()
        {
        }

        // Properties
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Display(Name = "Rented Records")]
        public string RentedRecords { get; set; }
    }
}
