using LibraryApi.Application.Services.Interfaces;
using LibraryApi.Domain.Models;
using LibraryApi.Domain.Repositories;

namespace LibraryApi.Application.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    public BookService(IBookRepository bookRepository){
        _bookRepository = bookRepository;
    }
    public List<Book> GetAll()
    {
        var listBook = _bookRepository.GetAll();
        return listBook;
    }

    public Book GetById(Guid id)
    {
        var book = _bookRepository.GetById(id);
        return book;
    }

    public void Update(Book book)
    {
        _bookRepository.Update(book);
    }
}
