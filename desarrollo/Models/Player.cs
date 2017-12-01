using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace desarrollo.Models
{
    public class Player
    {
        [Key]
        public int IdPlayer { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public String Position { get; set; }
        public int IdTeam { get; set; }
        public team Team { get; set; }
    }
}