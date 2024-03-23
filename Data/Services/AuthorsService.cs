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
        async Task IAuthorsService.AddAsync(Author author)
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
        }

        async Task IAuthorsService.DeleteAsync(int id)
        {
            var result = await _context.Authors.FirstOrDefaultAsync(n => n.AuthorId == id);
            _context.Authors.Remove(result);
            await _context.SaveChangesAsync();
        }

        async Task<IEnumerable<Author>> IAuthorsService.GetAllAsync()
        {
            var result = await _context.Authors.ToListAsync();
            return result;
        }

        async Task<Author> IAuthorsService.GetByIdAsync(int id)
        {
            var result = await _context.Authors.FirstOrDefaultAsync(n => n.AuthorId == id);
            return result;
        }

        async Task<Author> IAuthorsService.UpdateAsync(int id, Author newAuthor)
        {
            _context.Update(newAuthor);
            await _context.SaveChangesAsync();
            return newAuthor;
        }
    }
}
