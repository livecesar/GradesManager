using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GradesManager.Models
{
    public class StudentModel
    {
        public int id { get; set; }

        // The restrictions placed here (Required...) are processed in the client, by JQuery

        [Required(ErrorMessage = "You need to fill this field.")]
        [Display(Name ="Name")]
        public string FirstName { get; set; }

        [Display(Name ="Middle Name")]
        public string SecondName { get; set; }

        [Required(ErrorMessage ="You need to fill this field.")]
        [Display(Name = "First Last Name")]
        public string FirstLastName { get; set; }

        [Display(Name ="Second Last Name")]
        public string SecondLastName { get; set; }

        [Required(ErrorMessage = "You need to fill this field.")]
        [Range(100000, 9999999999, ErrorMessage = "You need to enter a valid Student DNI")]
        public string DNI { get; set; }
    }
}