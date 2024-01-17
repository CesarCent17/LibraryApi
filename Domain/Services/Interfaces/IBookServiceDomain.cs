namespace LibraryApi.Domain.Interfaces;

public interface IBookServiceDomain{
    void Loan(Guid Id);
}