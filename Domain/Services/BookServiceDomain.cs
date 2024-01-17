using LibraryApi.Application.Services.Interfaces;
using LibraryApi.Domain.Interfaces;

namespace LibraryApi.Domain.Services;

public class BookServiceDomain : IBookServiceDomain
{
    private readonly IBookService _bookService;
    public BookServiceDomain(IBookService bookService){
        _bookService = bookService;
    }
    public void Loan(Guid Id)
    {
        var book = _bookService.GetById(Id);
        book.IsAvailableForLoan = false;
        _bookService.Update(book);
    }
}
