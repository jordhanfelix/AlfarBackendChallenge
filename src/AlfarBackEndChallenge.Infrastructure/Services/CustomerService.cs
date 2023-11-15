using AlfarBackEndChallenge.Application.Contracts.Infrastructure.Persistence;
using AlfarBackEndChallenge.Application.Contracts.Infrastructure.Services;

namespace AlfarBackEndChallenge.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _uow;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

    }
}