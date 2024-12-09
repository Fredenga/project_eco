using AuthApi.Application.DTOs;
using SharedLib.ResponseBody;

namespace AuthApi.Application.Interfaces
{
    public interface IUser
    {
        Task<Response> Register(UserDTO user);
        Task<Response> Login(LoginDTO user);

        Task<FetchedUserDTO> GetUser(int userId);
        Task<Response> Logout();
        Task<Response> ChangePassword(ChangePasswordDTO info);
        Task<Response> ResetPassword(string email);
    }
}
