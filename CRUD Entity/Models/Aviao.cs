﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_Entity.Models
{
    public class Aviao
    {
        [Key]
        [Required]
        public int IdAviao { get; set; }
        [Required]
        [Display(Name = "Piloto")]
        [ForeignKey("Pilotos")]
        public int PilotoRefId { get; set; }
        [Required]
        [Display(Name = "Piloto")]
        public Piloto Pilotos { get; set; }
        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

    }
}