using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Author : IEntityBase
    {
        [Key]   
        public int AuthorId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name Is Required")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography Is Required")]
        public string Bio { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture Is Required")]
        public string ProfilePictureURL { get; set; }

        //Relationships

        public List<Author_Book> Authors_Books { get; set; }
    }
}
