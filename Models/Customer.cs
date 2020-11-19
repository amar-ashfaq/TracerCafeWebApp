using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TracerCafeWebApp.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Title is required")]
        [StringLength(20, MinimumLength = 2)]
        public string Title { get; set; }

        [DisplayName("Firstname")]
        [Required(ErrorMessage = "Firstname is required")]
        [StringLength(35, MinimumLength = 2)]
        public string FirstName { get; set; }

        [DisplayName("Lastname")]
        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(35, MinimumLength = 1)]
        public string LastName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required")]
        [Range(1, 130)]
        public int Age { get; set; }

        [DisplayName("Street")]
        [Required(ErrorMessage = "Street is required")]
        [StringLength(60, MinimumLength = 5)]
        public string Address1 { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Address2 { get; set; }

        [DisplayName("County")]
        [Required(ErrorMessage = "County is required")]
        [StringLength(50, MinimumLength = 5)]
        public string Address3 { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Country is required")]
        [StringLength(60, MinimumLength = 5)]
        public string Address4 { get; set; }

        [DisplayName("Postcode")]
        [Required(ErrorMessage = "Postcode is required")]
        [RegularExpression(@"([A-Za-z]{1,2}[0-9]{1,2}[A-Za-z]?[ ]?)([0-9]{1}[A-Za-z]{2})$", ErrorMessage = "Please enter Postcode in correct format")]
        public string Postcode { get; set; }

        [DisplayName("Telephone")]
        [Required(ErrorMessage = "Telephone is required")]
        [RegularExpression(@"((\+44(\s\(0\)\s|\s0\s|\s)?)|0)7\d{3}(\s)?\d{6}$", ErrorMessage = "Please enter Telephone in correct format")]
        public string Telephone { get; set; }
    }
}