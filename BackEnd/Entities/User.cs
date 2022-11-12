using AcademyTest.Dtos;

namespace AcademyTest.Entities
{
    public record User
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public long Phone { get; init; }

 

    public UserDto AsDto(){
        return new UserDto(){
            Id = this.Id,
            Name = this.Name,
            Email = this.Email,
            Phone = this.Phone
        };
    }
}
}