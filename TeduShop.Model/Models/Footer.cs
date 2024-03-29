﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer : AudiTable
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
