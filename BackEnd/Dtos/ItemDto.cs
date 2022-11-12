using AcademyTest.Entities;

namespace AcademyTest.Dtos
{
    public record ItemDto{
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public int Quantity { get; init; }
        public User? Owner { get; init; }
        public int UserId { get; init; }

    }
}