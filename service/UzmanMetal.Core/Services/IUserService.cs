using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UzmanMetal.Core.Models;

namespace UzmanMetal.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<ApplicationUser>> GetAllUsers();
        Task<ApplicationUser> GetUserById(int id);
        Task<ApplicationUser> CreateUser(ApplicationUser newUser);
        Task UpdateUser(ApplicationUser userToUpdated, ApplicationUser user);
        Task DeleteUser(ApplicationUser user);
    }
}