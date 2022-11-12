using AcademyTest.Dtos;
using AcademyTest.Entities;
using AcademyTest.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace AcademyTest.Controllers
{
    [ApiController]
    [Route("users")]

    public class UserController : ControllerBase
    {
        public IUserRepository repository;
        public UserController(IUserRepository repository)
        {
            this.repository = repository;            
        }

        [HttpGet("GetAll")] 
        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
           var users =(await repository.GetUsersAsync()).Select(user => user.AsDto());
           return users;
            
        }
         

        [HttpGet("{id}")] 
        public async Task <ActionResult<UserDto>> GetUserAsync(Guid id)
        {
           var user = await repository.GetUserAsync(id);

           if(user is null)
           {
            return NotFound();
           }
           return user.AsDto();
            
        }
        
        [HttpPost]
        public async Task <ActionResult<UserDto>> CreateUser(CreateUserDto id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task <UserDto> UpdateUser(Guid id)
        {
            throw  new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task <UserDto> DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}