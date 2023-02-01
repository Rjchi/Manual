using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Manual.Models
{
    public class Aprendiz
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(20)]
        public string Document { get; set; }

        [Required, StringLength(30)]
        public string Names { get; set; }

        [Required, StringLength(90)]
        public string lastsName { get; set; }
    }
}