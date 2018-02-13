using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class DocumentType
    {
        [Key]
        [Display(Name = "Document Type")]
        public int DocumentTypeID { get; set; }

        [Display(Name ="Document")]
        public string Description { get; set; }

        //Relacion ICollection<Clase> Propiedad
        //Tipo Documento Maneja una relacion de 1 *(Varios) con esta tabla(Employee)
        //Un documento puede tener una relacion de unos a varios con empleados
        public virtual ICollection<Employee> Employee { get; set; }

        //Relacion de Un Document a Varios DocumentType
        public virtual ICollection<Customer> Customers{ get; set; }
    }
}