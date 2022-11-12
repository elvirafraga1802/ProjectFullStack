using AcademyTest.Entities;

namespace AcademyTest.Repositories
{
    public class InMemUserRepository
    {

        private readonly List<User> users = new()
        {
            new User{Id = Guid.NewGuid(),Name = "Elvira", Email = "elvira.fraga@hotmail.com", Phone = 4427127244},
            new User{Id = Guid.NewGuid(),Name = "Andres", Email = "20", Phone = 44267425961},
            new User{Id = Guid.NewGuid(),Name = "Gustavo", Email = "30", Phone = 4427895614 }
        };


        public IEnumerable<User> GetUsers()
        {
            return users;
        }
        public User GetItem(Guid id)
        {
            throw new NotImplementedException();
            //return this.users.Where(u => u.Id == id).SingleOrDefault();
        }

        
    }
}