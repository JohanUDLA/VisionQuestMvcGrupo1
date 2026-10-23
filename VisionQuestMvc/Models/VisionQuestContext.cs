using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VisionQuestMvc.Models
{
    public class VisionQuestContext : DbContext
    {
        public VisionQuestContext() : base("name=VisionQuestContext") { }

        public DbSet<Sintezoide> Sintezoides { get; set; }
        public DbSet<Recuerdo> Recuerdos { get; set; }
    }
}