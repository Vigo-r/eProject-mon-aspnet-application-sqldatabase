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

        public string PublisherName { get; set; }

        public string PublisherDescription { get; set; }

        public string PublisherPictureURL { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
