namespace AuthApi.Application.DTOs
{
    public record ChangePasswordDTO
    (
        string Email,
        string NewPassword,
        string ConfirmPassword
    );
}
