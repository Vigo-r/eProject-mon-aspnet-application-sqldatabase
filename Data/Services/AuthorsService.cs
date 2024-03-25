using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Author author)
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var authorToDelete = await _context.Authors.FindAsync(id);
            if (authorToDelete != null)
            {
                _context.Authors.Remove(authorToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            return await _context.Authors.FirstOrDefaultAsync(n => n.AuthorId == id);
        }

        public async Task<Author> UpdateAsync(int id, Author newAuthor)
        {
            var authorToUpdate = await _context.Authors.FirstOrDefaultAsync(a => a.AuthorId == id);
            if (authorToUpdate != null)
            {
                authorToUpdate.FullName = newAuthor.FullName;
                authorToUpdate.Bio = newAuthor.Bio;
                // Update other fields as necessary
                await _context.SaveChangesAsync();
                return authorToUpdate;
            }
            return null;
        }
    }
}
