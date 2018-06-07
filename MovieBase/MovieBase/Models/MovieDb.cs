using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieBase.Models
{
    public class MovieDb
    {
        [Key]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public string Link { get; set; }
        public string PictureLink { get; set; }
        public string Added { get; set; }
    }
}