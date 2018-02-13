using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "First Name")]
        public string ContactFirstName { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Last Name")]
        public string ContactLastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string address { get; set; }

        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Document")]
        public string Document { get; set; }

        //Relacion con DocumentType
        public int DocumentTypeID { get; set; }

        //Lado UNO 
        public virtual DocumentType DocumentType { get; set; }

        //Relacion muchos de (Una order tiene Muchos Customer)
        public virtual ICollection<Order> Order { get; set; }

    }
}