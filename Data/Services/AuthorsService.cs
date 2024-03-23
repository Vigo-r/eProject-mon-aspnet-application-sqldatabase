using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class AuthorsService : EntityBaseRepository<Author>, IAuthorsService
    {

        public AuthorsService(AppDbContext context) : base (context) { }

    }
}
