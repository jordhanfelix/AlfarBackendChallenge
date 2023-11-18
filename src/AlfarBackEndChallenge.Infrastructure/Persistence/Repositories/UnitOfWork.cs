using AlfarBackEndChallenge.Application.Contracts.Infrastructure.Persistence;

namespace AlfarBackEndChallenge.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            CustomerRepository = new CustomerRepository(context);
        }

        public ICustomerRepository CustomerRepository { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}