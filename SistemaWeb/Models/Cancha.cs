﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Cancha
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(5)]
        public int Capacidad { get; set; }
        [Required, MinLength(0)]
        public int Numero_Cancha { get; set; }
        [Required]
        public bool Esta_Ocupado { get; set; }
        public string? Foto { get; set; } //almacenar la ubicación de fotos
        //Cargar Foto
        [NotMapped] //No va migrar en BdD
        [Display(Name = "Cargar Foto")]
        public IFormFile? FotoFile { get; set; }

        //Relaciones 1 ----> *
        public virtual List<Alquiler>? Alquilers { get; set; }
    }
}
