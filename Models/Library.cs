using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Library
    {
        [Key]

        public int LibraryId { get; set; }

        [Display(Name = "Library Name")]
        public string Name { get; set; }

        [Display(Name = "Library Description")]
        public string Description { get; set; }

        [Display(Name = "Library Logo")]
        public string Logo { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
