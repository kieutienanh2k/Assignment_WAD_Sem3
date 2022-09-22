﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_WAD.Models
{
    public class Genre
    {
        [Required]
        public long GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}