using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string FullName { get; set; }

        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }

        //Relationships

        public List<Author_Book> Authors_Books { get; set; }
    }
}