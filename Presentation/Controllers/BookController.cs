using LibraryApi.Application.Services.Interfaces;
using LibraryApi.Domain.Interfaces;
using LibraryApi.Domain.Models;
using LibraryApi.Presentation.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Presentation.Controllers;

[ApiController]
[Route("api/book")]
public class BookController : ControllerBase{
    private readonly IBookService _bookService;
    private readonly IBookServiceDomain _bookServiceDomain;
    public BookController(IBookService bookService, IBookServiceDomain bookServiceDomain)
    {
        _bookService = bookService;
        _bookServiceDomain = bookServiceDomain;
    }

    [HttpGet]
    public ActionResult<ApiResponse<IEnumerable<Book>>> GetAll()
    {
        var response = _bookService.GetAll();
        return Ok(new ApiResponse<IEnumerable<Book>>(true, "We got the book list successfully", response, (int)StatusCodeEnum.OK));
    }

    [HttpPost("loan/{id}")]
    public ActionResult<ApiResponse<Guid>> Loan(Guid id)
    {
        _bookServiceDomain.Loan(id);
        return Ok(new ApiResponse<Guid>(true, "Successfully borrowed book.", id, (int)StatusCodeEnum.OK));    
    }

}