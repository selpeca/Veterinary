﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Display(Name="Documento de identidad")]
        [Required]
        public string Document { get; set; }

        [Display(Name = "Primer nombre")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Teléfono fijo")]
        [Required]
        public int FixedPhone { get; set; }

        [Display(Name = "Móvil")]
        [Required]
        public string CellPhone { get; set; }

        [Display(Name = "Dirección")]
        [Required]
        public string  Address { get; set; }

        public string FullName=>$"{FirstName}  {LastName}";   



    }
}
