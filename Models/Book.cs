using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Book
    {
        [Key]

        public int BookId { get; set; }

        [Display(Name = "Book Name")]
        public string Name { get; set; }

        [Display(Name = "Book Description")]
        public string Description { get; set; }

        [Display(Name = "Book Cover")]
        public string CoverURL { get; set; }

        public double Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public BookGenre BookGenre { get; set; }

        //Relationships

        public List<Author_Book> Authors_Books { get; set; }

        // Library

        public int LibraryId { get; set; }
        [ForeignKey("LibraryId")]

        public Library Library { get; set; }


        // Publisher

        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]

        public Publisher Publisher { get; set; }
    }
}
