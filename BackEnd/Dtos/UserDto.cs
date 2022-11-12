namespace AcademyTest.Dtos
{
    public record UserDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public long Phone { get; init; }
    }
}