using Microsoft.Extensions.Logging;
using Testing.Domain.Entities;
using Testing.Infrastructure.Interfaces;

namespace Testing.Infrastructure.Implements
{
    public class UserRepository: RepositoryBase<User>, IUserRepository
    {
        public UserRepository(TestingDbContext _context, ILogger logger)
           : base(_context, logger)
        {
        }
    }
}
