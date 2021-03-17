using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SzablonStrony.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica:")]

        public string Street { get; set; }
        [Display(Name = "Twoj kod pocztowy:")]
        public string ZipCode { get; set; }
        [Display(Name = "Twoje miasto:")]
        public string City { get; set; }
        [Display(Name = "Twoj telefon:")]
        public int Number { get; set; }
    }
}
