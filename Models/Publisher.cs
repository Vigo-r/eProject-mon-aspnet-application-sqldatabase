using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }

        [Display(Name = "Publisher Description")]
        public string PublisherDescription { get; set; }

        [Display(Name = "Publisher Picture")]
        public string PublisherPictureURL { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
