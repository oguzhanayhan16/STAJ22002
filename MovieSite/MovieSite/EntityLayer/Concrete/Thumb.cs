﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Thumb
    {
        [Key]
        public int ThumbID { get; set; }

        public int MovieID { get; set; }
        [ForeignKey("MovieID")]
        public Movie Movie { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

    }
}
