using LibraryApi.Domain.Models;

namespace LibraryApi.Application.Services.Interfaces;

public interface IBookService{
    List<Book> GetAll();
    Book GetById(Guid id);
    void Update(Book book);
}