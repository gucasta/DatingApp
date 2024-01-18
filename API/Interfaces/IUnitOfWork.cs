namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get;}
        IMessageRepository MessageRespository {get;}
        ILikesRepository LikesRepository {get;}
        Task<bool> Complete();
        bool HasChanges();
    }
}