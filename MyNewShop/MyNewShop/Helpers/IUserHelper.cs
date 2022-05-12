using Microsoft.AspNetCore.Identity;
using MyNewShop.Data.Entities;
using MyNewShop.Models;

namespace MyNewShop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<User> AddUserAsync(AddUserVM model);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginVM model);

        Task LogoutAsync();


    }
}
