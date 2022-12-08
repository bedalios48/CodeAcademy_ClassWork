using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        LocalUser Register(RegistrationRequest registrationRequest);
    }
}
