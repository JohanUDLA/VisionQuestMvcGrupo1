using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VisionQuestMvc.Models
{
    public class Sintezoide
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string nombre { get; set; }


        [Required]
        public string Modelo { get; set; }

        [Range(1, 10)]
        [Required]
        public int NivelIA { get; set; }
      
       

        [Required]
        public string FuenteEnergia { get; set; }

        public virtual ICollection<Recuerdo> Recuerdos { get; set; }
    }
}