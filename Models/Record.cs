using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace moment3._2.Models
{
    public class Record
    {
        // Constructor
        public Record()
        {
        }

        // Properties
        [Display(Name = "Record ID")]
        public int Id { get; set; }
        [Display(Name = "Record")]
        public string RecordName { get; set; }
        public string Artist { get; set; }
        [Display(Name = "Release")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Rented")]
        public bool IsRented { get; set; }
        [Display(Name = "Was rented")]
        public DateTime RentDate { get; set; }
    }
}
