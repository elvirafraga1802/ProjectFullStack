using AcademyTest.Context;
using AcademyTest.Dtos;
using AcademyTest.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademyTest.Repositories
{
    public class UserService : IUserRepository
    {
        public DataContext repository;

        public UserService(DataContext repository)
        {
            this.repository = repository;
        }

        public Task<User> CreateUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await repository.Users.ToListAsync();
        }


        public Task ReadItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

       
    }
}