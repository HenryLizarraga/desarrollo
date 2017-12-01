using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace desarrollo.Models
{
    public class team
    { 
        [Key]
        public int IdTeam { get; set; }
        public string TeamNaME { get; set; }
    }
}