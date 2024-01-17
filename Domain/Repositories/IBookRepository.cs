using LibraryApi.Domain.Models;

namespace LibraryApi.Domain.Repositories;

public interface IBookRepository{
    List<Book> GetAll();
    Book GetById(Guid id);
    void Update(Book book);
}