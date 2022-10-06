namespace Testing.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        Task CompleteAsync();
    }
}
