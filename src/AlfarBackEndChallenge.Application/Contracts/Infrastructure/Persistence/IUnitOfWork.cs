namespace AlfarBackEndChallenge.Application.Contracts.Infrastructure.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }
        Task Save();
    }
}
