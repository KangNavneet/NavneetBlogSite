using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace NavneetBlogSite.Models
{
    public class BlogPost
    {

        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [StringLength(1060, MinimumLength = 3)]
        [Required]

        public string Content { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]

        public string AuthorEmail { get; set; }
        
    }
}
