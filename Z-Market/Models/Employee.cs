using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The Field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The Field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0:C3}", ApplyFormatInEditMode = false)]
        public decimal Salary { get; set; }

        [Display(Name = "Bonus Percent")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float BonusPercent { get; set; }


        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "You must enter {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "You must enter {0}")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string URL { get; set; }

        //Atrinuto para Manegar la Relacion con DocumentType
        [Required(ErrorMessage = "You must enter {0}")]
        public int DocumentTypeID { get; set; }

        //virtual = Modificador de Acceso
        public virtual DocumentType DocumentType { get; set; }

        //Squema NotMapped Para que no añada como campo en la Base de datos
        [NotMapped]
        public String Name
        {
            get{ return FirstName + " " + LastName; }
        }

        [NotMapped]
        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }   
        }


    }
}