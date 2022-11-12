using AcademyTest.Dtos;
using AcademyTest.Entities;

namespace AcademyTest
{
    public static class Extensions
    {
        public static UserDto AsDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Phone = (int)user.Phone
            };
        }
    }
}