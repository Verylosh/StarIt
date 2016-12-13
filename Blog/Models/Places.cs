using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Places
    {
        [Key]
        public int IdOfPlace { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string NameOfPlace { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string AdresOfPlace { get; set; }
        
        public int RatingOfPlace { get; set; }


        public int CreatorId { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }

    }
}