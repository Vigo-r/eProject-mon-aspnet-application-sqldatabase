using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        void IAuthorsService.Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        void IAuthorsService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Author>> IAuthorsService.GetAll()
        {
            var result = await _context.Authors.ToListAsync();
            return result;
        }

        Author IAuthorsService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Author IAuthorsService.Update(int id, Author newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
