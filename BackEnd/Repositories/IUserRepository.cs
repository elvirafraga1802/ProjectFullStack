using AcademyTest.Entities;

namespace AcademyTest.Repositories
{
    public interface IUserRepository
    {
        Task <User>CreateUserAsync(Guid id);
        Task <IEnumerable<User>> GetUsersAsync();
        Task <User> GetUserAsync(Guid id);
        Task ReadItemAsync(Guid id);
        Task UpdateUserAsync(Guid id);
        Task DeleteUserAsync(Guid id);
    }
}