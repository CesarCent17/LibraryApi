using LibraryApi.Domain.Models;
using LibraryApi.Domain.Repositories;

namespace LibraryApi.Infrastructure.Data;

public class BookRepository : IBookRepository
{
    public List<Book> GetAll()
    {
        List<Book> listBook = new List<Book>();
        var book1984 = new Book(){
            Id = Guid.NewGuid(),
            Title = "1984",
            Author = "George Orwell",
            IsAvailableForLoan = true
        };

         var bookTLQ = new Book(){
            Id = Guid.NewGuid(),
            Title = "The Last Question",
            Author = "Isaac Asimov",
            IsAvailableForLoan = true
        };
        listBook.Add(book1984);
        listBook.Add(bookTLQ);
        
        return listBook;
    }

    public Book GetById(Guid id)
    {
        return GetAll().FirstOrDefault(x => x.Id == id);
    }

    public void Update(Book book)
    {
    }
}
