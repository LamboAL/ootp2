using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

  
namespace ootp2.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name", ResourceType = typeof(Resources.Resource))]
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
