using AuthApi.Domain.Enums;

namespace AuthApi.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public string? Avatar { get; set; }
        public required UserRole Role { get; set; }
        public required UserStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedAt { get; set; }
    }
}
