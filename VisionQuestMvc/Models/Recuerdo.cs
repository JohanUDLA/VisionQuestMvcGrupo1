using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisionQuestMvc.Models
{
    public class Recuerdo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TituloRecuerdo { get; set; }


        [Required]
        public string TipoRecuerdo { get; set; }

        [Range(1, 100)]
        [Required]
        public int Claridad { get; set; }
       

        [Required]
        public int SintezoideId { get; set; }

        public virtual ICollection<Sintezoide> Sintezoides { get; set; }
    }
}