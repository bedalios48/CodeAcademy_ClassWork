using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Interfaces
{
    public interface IUserWrapper
    {
        LocalUserDto Bind(LocalUser user);
    }
}