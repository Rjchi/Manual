using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Manual.Models
{
    public class Ficha
    {
        [Key]
        public int FichaId { get; set; }
        [Required]
        [StringLength(50)]
        public string Programa { get; set; }
        [Required]
        [StringLength (30)]
        public string Codigo { get; set; }

        [Required]
        [DataType(DataType.Date)]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime FechaInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime FechaFin { get; set; }
    }
}