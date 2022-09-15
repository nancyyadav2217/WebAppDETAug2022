using Library.Api.Models;

namespace Library.Api.Services
{
    public interface IBookServices
    {
        IEnumerable<Book> GetAll();
        Book Add(Book newBook);
        Book GetById(Guid id);
        void Remove(Guid id);
    }
}
