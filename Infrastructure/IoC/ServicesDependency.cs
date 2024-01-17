using LibraryApi.Application.Services;
using LibraryApi.Application.Services.Interfaces;
using LibraryApi.Domain.Interfaces;
using LibraryApi.Domain.Repositories;
using LibraryApi.Domain.Services;
using LibraryApi.Infrastructure.Data;

namespace LibraryApi.Infrastructure.IoC;

public static class ServicesDependency
{
    public static void AddServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IBookServiceDomain, BookServiceDomain>();
    }
}