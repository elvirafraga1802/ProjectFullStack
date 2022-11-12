using System.ComponentModel.DataAnnotations;

namespace AcademyTest.Dtos
{
    public record CreateUserDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public string Email { get; init; }
        [Required]
        public int Phone { get; init; }
    }
}