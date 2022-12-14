using App1121.Interfaces;
using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Services
{
    public class UserWrapper : IUserWrapper
    {
        public LocalUserDto Bind(LocalUser user)
        {
            return new LocalUserDto(user.Username, user.Name);
        }
    }
}
