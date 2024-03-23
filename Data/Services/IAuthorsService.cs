using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IAuthorsService : IEntityBaseRepository<Author>
    {
        /*
        Task<IEnumerable<Author>> GetAll();

        Author GetById(int id);
        void Add(Author author);

        Author Update(int id, Author newAuthor);

        void Delete(int id);
        */
    }
}
