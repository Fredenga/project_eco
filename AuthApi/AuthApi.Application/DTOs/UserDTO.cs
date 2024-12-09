using AuthApi.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AuthApi.Application.DTOs
{
    public record UserDTO(
    int ID,
    [Required, MaxLength(1000), MinLength(3)]
    string Username,
    [Required, EmailAddress]
    string Email,
    [Required]
    string Password,
    string? Avatar,
    [Required]
    UserRole Role,
    [Required]
    UserStatus Status
);
}
