using Microsoft.Extensions.Logging;
using Testing.Domain.Entities;
using Testing.Infrastructure.Interfaces;

namespace Testing.Infrastructure.Implements
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TestingDbContext _context;
        private readonly ILogger<UnitOfWork> _logger;

        public IUserRepository UserRepository { get; private set; }

        public UnitOfWork(TestingDbContext context, ILogger<UnitOfWork> logger)
        {
            _context = context;
            _logger = logger;

            UserRepository = new UserRepository(context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
