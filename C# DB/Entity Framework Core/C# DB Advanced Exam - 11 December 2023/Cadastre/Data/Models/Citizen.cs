﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastre.Data.Enumerations;

namespace Cadastre.Data.Models
{
    public class Citizen
    {
        public Citizen()
        {
            PropertiesCitizens = new HashSet<PropertyCitizen>();
        }

        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public MaritalStatus MaritalStatus { get; set; }

        public ICollection<PropertyCitizen> PropertiesCitizens { get; set; }
    }
}
