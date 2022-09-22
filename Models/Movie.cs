using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_WAD.Models
{
    public class Movie
    {
        [Required]
        public long MovieId { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Movie Title must be between 6 and 250 character.", MinimumLength=6)]
        public string MovieTitle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(60, 180, ErrorMessage = "Running time must be between 60 to 180")]
        public int RunningTime { get; set; }
        [Required]
        public long Genreid { get; set; }

        public virtual Genre Genre { get; set; }

    }
}