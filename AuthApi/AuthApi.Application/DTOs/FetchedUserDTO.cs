using AuthApi.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AuthApi.Application.DTOs
{
    public record FetchedUserDTO
    (        
       int ID,
       [Required, MaxLength(1000), MinLength(3)]
        string Username,
       [Required, EmailAddress]
        string Email,
       string? Avatar,
       [Required]
        UserRole Role,
       [Required]
        UserStatus Status,
        DateTime CreatedAt
    );
}
