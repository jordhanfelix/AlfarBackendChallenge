using AlfarBackEndChallenge.Application.Contracts.Infrastructure.Persistence;
using AlfarBackEndChallenge.Domain.Entities;

namespace AlfarBackEndChallenge.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}