﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        [StringLength(30, ErrorMessage ="The Field {0} must contain between {2} and {1} characters",MinimumLength = 3)]
        [Required(ErrorMessage ="You must enter the field {0}")]
        [Display(Name="Supplier Name")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Contact First Name")]
        public string ContactFirstName { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Contact Last Name")]
        public string ContactLastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}